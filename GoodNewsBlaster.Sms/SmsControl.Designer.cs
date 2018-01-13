namespace GoodNewsBlaster.Sms
{
    partial class SmsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmsControl));
            this.MessageContent = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.CheckList = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SingleSendNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SingleSend = new Bunifu.Framework.UI.BunifuCheckbox();
            this.SendMessage = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // MessageContent
            // 
            this.MessageContent.BorderColor = System.Drawing.Color.SeaGreen;
            this.MessageContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageContent.Location = new System.Drawing.Point(15, 22);
            this.MessageContent.Multiline = true;
            this.MessageContent.Name = "MessageContent";
            this.MessageContent.Size = new System.Drawing.Size(669, 241);
            this.MessageContent.TabIndex = 0;
            // 
            // CheckList
            // 
            this.CheckList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckList.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckList.Checked = true;
            this.CheckList.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckList.ForeColor = System.Drawing.Color.White;
            this.CheckList.Location = new System.Drawing.Point(16, 280);
            this.CheckList.Name = "CheckList";
            this.CheckList.Size = new System.Drawing.Size(20, 20);
            this.CheckList.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(42, 280);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(56, 20);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Use list";
            // 
            // SingleSendNumber
            // 
            this.SingleSendNumber.BorderColorFocused = System.Drawing.Color.Blue;
            this.SingleSendNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SingleSendNumber.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.SingleSendNumber.BorderThickness = 3;
            this.SingleSendNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SingleSendNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SingleSendNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SingleSendNumber.isPassword = false;
            this.SingleSendNumber.Location = new System.Drawing.Point(312, 270);
            this.SingleSendNumber.Margin = new System.Windows.Forms.Padding(4);
            this.SingleSendNumber.Name = "SingleSendNumber";
            this.SingleSendNumber.Size = new System.Drawing.Size(372, 30);
            this.SingleSendNumber.TabIndex = 3;
            this.SingleSendNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(218, 276);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(87, 20);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Single Send";
            // 
            // SingleSend
            // 
            this.SingleSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.SingleSend.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.SingleSend.Checked = true;
            this.SingleSend.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.SingleSend.ForeColor = System.Drawing.Color.White;
            this.SingleSend.Location = new System.Drawing.Point(192, 276);
            this.SingleSend.Name = "SingleSend";
            this.SingleSend.Size = new System.Drawing.Size(20, 20);
            this.SingleSend.TabIndex = 4;
            // 
            // SendMessage
            // 
            this.SendMessage.ActiveBorderThickness = 1;
            this.SendMessage.ActiveCornerRadius = 20;
            this.SendMessage.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.SendMessage.ActiveForecolor = System.Drawing.Color.White;
            this.SendMessage.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SendMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendMessage.BackgroundImage")));
            this.SendMessage.ButtonText = "Send";
            this.SendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendMessage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendMessage.IdleBorderThickness = 1;
            this.SendMessage.IdleCornerRadius = 20;
            this.SendMessage.IdleFillColor = System.Drawing.Color.White;
            this.SendMessage.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendMessage.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendMessage.Location = new System.Drawing.Point(579, 299);
            this.SendMessage.Margin = new System.Windows.Forms.Padding(5);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(105, 41);
            this.SendMessage.TabIndex = 8;
            this.SendMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(11, -1);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(141, 20);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Type Message Here:";
            // 
            // SmsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.SingleSend);
            this.Controls.Add(this.SingleSendNumber);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.CheckList);
            this.Controls.Add(this.MessageContent);
            this.Name = "SmsControl";
            this.Size = new System.Drawing.Size(723, 342);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox MessageContent;
        private Bunifu.Framework.UI.BunifuCheckbox CheckList;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox SingleSendNumber;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCheckbox SingleSend;
        private Bunifu.Framework.UI.BunifuThinButton2 SendMessage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}
