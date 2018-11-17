using System;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace GoodNewsBlaster.Sms
{
    public partial class SmsForm : Form
    {
        private ImportControl _importControl;
        private SmsControl _smsControl;
        private ConfigurationControl _configurationControl;

        private string _configureEndpoint = string.Empty;
        public SmsForm()
        {
          
            InitializeComponent();
            Load += SmsForm_Load;
        }

       
        private void SmsForm_Load(object sender, EventArgs e)
        {
            this._configurationControl =new ConfigurationControl();
            this._smsControl = new SmsControl(notifyIcon);
            this._importControl = new ImportControl(notifyIcon);

            ContentArea.Controls.Clear();
            _importControl.Anchor = AnchorStyles.None;
            _smsControl.Dock = DockStyle.Fill;
            ContentArea.Controls.Add(_importControl);
            

            }

        private void Import_Click(object sender, EventArgs e)
        {
            Slider.Left = ((BunifuFlatButton) sender).Left;
            Slider.Width = ((BunifuFlatButton) sender).Width;
           AddControl(_importControl);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Slider.Left = ((BunifuFlatButton) sender).Left;
            Slider.Width = ((BunifuFlatButton) sender).Width;
            AddControl(_smsControl);
        }

        private void AddControl(Control control)
        {
            ContentArea.Controls.Clear();
            control.Width = ContentArea.Width -10;
            ContentArea.Controls.Add(control);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }

        private void Config_Click(object sender, EventArgs e)
        {
            Slider.Left = ((BunifuFlatButton) sender).Left;
            Slider.Width = ((BunifuFlatButton) sender).Width;
           AddControl(_configurationControl);
        }
    }
}
