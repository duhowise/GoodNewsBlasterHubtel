using System;
using System.Configuration;
using System.Windows.Forms;

namespace GoodNewsBlaster.Sms
{
    public partial class ConfigurationControl : UserControl
    {
        public ConfigurationControl()
        {
            InitializeComponent();
            SaveConfig.Click += SaveConfig_Click;

           SenderName.Text=ConfigurationManager.AppSettings["Sender"];
           ApiUser.Text=ConfigurationManager.AppSettings["ApiKey"];
           ApiPassword.Text=ConfigurationManager.AppSettings["ApiPass"];
        }

        private void SaveConfig_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ApiUser.Text)||!string.IsNullOrWhiteSpace(ApiPassword.Text)||!string.IsNullOrWhiteSpace(SenderName.Text))
            {
                var config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

                config.AppSettings.Settings.Remove("ApiKey");
                config.AppSettings.Settings.Add("ApiKey", ApiUser.Text); 
                config.AppSettings.Settings.Remove("ApiPass");
                config.AppSettings.Settings.Add("ApiPass", ApiPassword.Text); 
                config.AppSettings.Settings.Remove("Sender");
                config.AppSettings.Settings.Add("Sender", SenderName.Text);

                config.Save(ConfigurationSaveMode.Modified);

                MessageBox.Show(@"Success");
            }
            else
            {
                MessageBox.Show(@"All Feilds are Required", @"Heads Up");
            }
        }
    }
}

