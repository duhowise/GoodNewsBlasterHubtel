using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodNewsBlaster.Sms
{
    public partial class SmsControl : UserControl
    {
        private string _reciepients = string.Empty;
        public SmsControl()
        {
            InitializeComponent();
            SendMessage.Click += SendMessage_Click            ;
        }

        private async void SendMessage_Click(object sender, EventArgs e)
        {
            var message=MessageContent.Text;
            var source=ConfigurationManager.AppSettings["Sender"];
            var username=ConfigurationManager.AppSettings["ApiKey"];
            var password=ConfigurationManager.AppSettings["ApiPass"];

            if (SingleSend.Checked)
            {
                if (!string.IsNullOrWhiteSpace(SingleSendNumber.Text))
                {
                    _reciepients =$"233{ SingleSendNumber.Text.Substring(1)}";
                }
            }
            else
            {
                MessageBox.Show(@"Single number cant be empty");
            }

            if (CheckList.Checked)
            {
                List<string> reciepientsNumbers=new List<string>();

                ImportControl.Members.ForEach(c=>reciepientsNumbers.Add(c.Number));
                //reciepientsNumbers = new List<string>();

                _reciepients = string.Join(",", reciepientsNumbers);
                //var reciepients = excelData.split();
            }
            


          var  configureEndpoint =
                $"http://dstr.connectbind.com:8080/sendsms?username=ushm-{username}&password={password}&type=0&dlr=1&destination={_reciepients}&source={source}&message={message}";


            var client = new HttpClient();
            var response= await client.PostAsync(configureEndpoint,null);
            var responseString = await response.Content.ReadAsStringAsync();
            if (!string.IsNullOrWhiteSpace(responseString))
            {
                MessageBox.Show(@"Success");
            }
        }
    }
}
