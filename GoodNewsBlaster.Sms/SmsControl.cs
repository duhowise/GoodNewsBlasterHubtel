using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smsgh.Api.Sdk.Smsgh;

namespace GoodNewsBlaster.Sms
{
    public partial class SmsControl : UserControl
    {
        private readonly NotifyIcon _notifyIcon;
        static List<Member> _members=new List<Member>();
        public delegate void DataExtractedEventHandler (object source, EventArgs args);
        public static event DataExtractedEventHandler DataExtractedEvent;

        public SmsControl(NotifyIcon notifyIcon)
        {
            _notifyIcon = notifyIcon;
            InitializeComponent();
            SingleSend.Checked = false;
            CheckList.Checked = false;
            SingleSendNumber.Enabled = false;
            SendMessage.Click += SendMessage_Click;
            SingleSend.Click += SingleSend_Click;
            CheckList.Click += CheckList_Click;
                    _notifyIcon.Icon = SystemIcons.Application;
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
             var errorResult = string.Empty;

            if (!string.IsNullOrWhiteSpace(source)||!string.IsNullOrWhiteSpace(username)||!string.IsNullOrWhiteSpace(password))
            {
                if (string.IsNullOrWhiteSpace(MessageContent.Text))
                {
                    _notifyIcon.ShowBalloonTip(3000, "SMS Prompt", @"Please enter a message to send", ToolTipIcon.Warning);
                }
                else
                {
                    var message = MessageContent.Text;
                    if (SingleSend.Checked)
                    {
                        if (!string.IsNullOrWhiteSpace(SingleSendNumber.Text))
                        {
                            _members.Add(new Member
                            {
                                Number = SingleSendNumber.Text
                            });
                        }
                        else
                        {
                    _notifyIcon.ShowBalloonTip(3000, "SMS Prompt", @"Single number cant be empty", ToolTipIcon.Warning);
                        }
                    }
                   if (CheckList.Checked)
                    {
                        OnDataExtractedEvent(this);
                        _members.AddRange(ImportControl.Members);
                    }

                   foreach (var member in _members)
                    {
                        try
                        {
                            var host = new ApiHost(new BasicAuth(username, password));
                            var api = new MessagingApi(host);
                            var msg = api.SendQuickMessage(source, member.Number,
                                message, true);

                            if (msg.Status!=0)
                            {
                                errorResult += $" \n Sending to {member.Number} failed with status code {msg.Status}";
                            }
                            await Task.FromResult(msg);
                        }
                        catch (Exception exception)
                        {
                            errorResult += $" \n Sending to {member.Number} failed with Exception {exception.Message}";
                        }
                    }

                    _notifyIcon.ShowBalloonTip(3000, "SMS Report", $"{errorResult} ", ToolTipIcon.Warning);
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
