using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

using DeviceMessaging;

using Microsoft.WindowsAzure;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Button1.Text = new Class2().ComputeButtonText();

            string serviceBusconnectionString = CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.ConnectionString");
            string storageConnectionString = CloudConfigurationManager.GetSetting("Microsoft.WindowsAzure.Storage.ConnectionString");
            
            var receiver = new ScaledMessageReceiver(serviceBusconnectionString, 10);

            var storageMessageWriter = new StorageMessageWriter(storageConnectionString);
            receiver.MessageProcessor = storageMessageWriter;
            receiver.ProcessWithBatching = true;

            receiver.LogMessageProperties = true;
            receiver.LogMessageBody = false;
            receiver.Run();

        }
    }
}