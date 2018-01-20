using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Windows.Forms;

namespace GoodNewsBlaster.Sms
{
    public partial class SmsControl : UserControl
    {
        static List<Member> _members=new List<Member>();
        private string _reciepients = String.Empty;

        public delegate void DataExtractedEventHandler (object source, EventArgs args);
        public static event DataExtractedEventHandler DataExtractedEvent;

        public SmsControl()
        {
            InitializeComponent();
            SingleSend.Checked = false;
            CheckList.Checked = false;
            SingleSendNumber.Enabled = false;
            SendMessage.Click += SendMessage_Click;
            SingleSend.Click += SingleSend_Click;
            CheckList.Click += CheckList_Click;
        }

        private void CheckList_Click(object sender, EventArgs e)
        {
            if (CheckList.Checked)
            {
                SingleSend.Checked = false;
            }
        }

        private void SingleSend_Click(object sender, EventArgs e)
        {

            if (SingleSend.Checked)
            {
                CheckList.Checked = false;
                SingleSendNumber.Enabled = true;

            }
        }

        private async void SendMessage_Click(object sender, EventArgs e)
        {
            var source=ConfigurationManager.AppSettings["Sender"];
            var username=ConfigurationManager.AppSettings["ApiKey"];
            var password=ConfigurationManager.AppSettings["ApiPass"];

            if (!string.IsNullOrWhiteSpace(source)||!string.IsNullOrWhiteSpace(username)||!string.IsNullOrWhiteSpace(password))
            {
                 
                if (!string.IsNullOrWhiteSpace(MessageContent.Text))
                {
                
                    var message=MessageContent.Text;
                
               

                    if (SingleSend.Checked)
                    {
                        if (!string.IsNullOrWhiteSpace(SingleSendNumber.Text))
                        {
                            _reciepients = $"233{ SingleSendNumber.Text.Substring(1)}";
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Single number cant be empty");
                    }

                    if (CheckList.Checked)
                    {
                        var reciepientsNumbers = new List<string>();
                        OnDataExtractedEvent(this);
                        _members.AddRange(ImportControl.Members);
                        _members.ForEach(c => reciepientsNumbers.Add(c.Number));
                        _reciepients = string.Join(",", reciepientsNumbers);
                    }
                    var  configureEndpoint =
                        $"http://121.241.242.114:8080/sendsms?username=ushm-{username}&password={password}&type=5&dlr=1&destination={_reciepients}&source={source}&message={message}";

                    try
                    {

                        var client = new HttpClient();
                        var response= await client.PostAsync(configureEndpoint,null);
                        var responseString = await response.Content.ReadAsStringAsync();
                        if (!String.IsNullOrWhiteSpace(responseString))
                        {
                            MessageBox.Show(@"Success");
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message,@"Success");

                    }
            }
            else
            {
                MessageBox.Show(@"Please enter a message to send");
            }   
            }
            else
            {
                MessageBox.Show(@"Please check configuration");
                
            }

        }

        private static void OnDataExtractedEvent(object source)
        {
            DataExtractedEvent?.Invoke(source, EventArgs.Empty);
        }
    }
}
