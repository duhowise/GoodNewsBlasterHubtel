using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace GoodNewsBlaster.Sms
{
    public partial class SmsForm : Form
    {
        private ImportControl importControl;
        private SmsControl smsControl;
        private ConfigurationControl configurationControl;

        private string configureEndpoint = string.Empty;
        public SmsForm()
        {
          
            InitializeComponent();
            Load += SmsForm_Load;
        }

       
        private void SmsForm_Load(object sender, EventArgs e)
        {
            this.configurationControl =new ConfigurationControl();
            this.smsControl = new SmsControl();
            this.importControl = new ImportControl();

            ContentArea.Controls.Clear();
            importControl.Anchor = AnchorStyles.None;
            smsControl.Dock = DockStyle.Fill;
            ContentArea.Controls.Add(importControl);


            }

        private void Import_Click(object sender, EventArgs e)
        {
            Slider.Left = ((BunifuFlatButton) sender).Left;
            Slider.Width = ((BunifuFlatButton) sender).Width;
           AddControl(importControl);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Slider.Left = ((BunifuFlatButton) sender).Left;
            Slider.Width = ((BunifuFlatButton) sender).Width;
            AddControl(smsControl);
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
           AddControl(configurationControl);
        }
    }
}
