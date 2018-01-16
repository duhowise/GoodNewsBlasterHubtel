using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;
using Bunifu.Framework.UI;

namespace GoodNewsBlaster.Sms
{
    partial class SmsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(SmsControl));
            this.MessageContent = new BunifuCustomTextbox();
            this.CheckList = new BunifuCheckbox();
            this.bunifuCustomLabel1 = new BunifuCustomLabel();
            this.SingleSendNumber = new BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new BunifuCustomLabel();
            this.SingleSend = new BunifuCheckbox();
            this.SendMessage = new BunifuThinButton2();
            this.bunifuCustomLabel3 = new BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // MessageContent
            // 
            this.MessageContent.BorderColor = Color.SeaGreen;
            this.MessageContent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.MessageContent.Location = new Point(15, 22);
            this.MessageContent.Multiline = true;
            this.MessageContent.Name = "MessageContent";
            this.MessageContent.Size = new Size(669, 241);
            this.MessageContent.TabIndex = 0;
            // 
            // CheckList
            // 
            this.CheckList.BackColor = Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckList.ChechedOffColor = Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckList.Checked = true;
            this.CheckList.CheckedOnColor = Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckList.ForeColor = Color.White;
            this.CheckList.Location = new Point(16, 280);
            this.CheckList.Name = "CheckList";
            this.CheckList.Size = new Size(20, 20);
            this.CheckList.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new Point(42, 280);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new Size(56, 20);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Use list";
            // 
            // SingleSendNumber
            // 
            this.SingleSendNumber.BorderColorFocused = Color.Blue;
            this.SingleSendNumber.BorderColorIdle = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SingleSendNumber.BorderColorMouseHover = Color.Blue;
            this.SingleSendNumber.BorderThickness = 3;
            this.SingleSendNumber.Cursor = Cursors.IBeam;
            this.SingleSendNumber.Font = new Font("Century Gothic", 9.75F);
            this.SingleSendNumber.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SingleSendNumber.isPassword = false;
            this.SingleSendNumber.Location = new Point(312, 270);
            this.SingleSendNumber.Margin = new Padding(4);
            this.SingleSendNumber.Name = "SingleSendNumber";
            this.SingleSendNumber.Size = new Size(372, 30);
            this.SingleSendNumber.TabIndex = 3;
            this.SingleSendNumber.TextAlign = HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new Point(218, 276);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new Size(87, 20);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Single Send";
            // 
            // SingleSend
            // 
            this.SingleSend.BackColor = Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.SingleSend.ChechedOffColor = Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.SingleSend.Checked = true;
            this.SingleSend.CheckedOnColor = Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.SingleSend.ForeColor = Color.White;
            this.SingleSend.Location = new Point(192, 276);
            this.SingleSend.Name = "SingleSend";
            this.SingleSend.Size = new Size(20, 20);
            this.SingleSend.TabIndex = 4;
            // 
            // SendMessage
            // 
            this.SendMessage.ActiveBorderThickness = 1;
            this.SendMessage.ActiveCornerRadius = 20;
            this.SendMessage.ActiveFillColor = Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.SendMessage.ActiveForecolor = Color.White;
            this.SendMessage.ActiveLineColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendMessage.BackColor = Color.WhiteSmoke;
            this.SendMessage.BackgroundImage = ((Image)(resources.GetObject("SendMessage.BackgroundImage")));
            this.SendMessage.ButtonText = "Send";
            this.SendMessage.Cursor = Cursors.Hand;
            this.SendMessage.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.SendMessage.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendMessage.IdleBorderThickness = 1;
            this.SendMessage.IdleCornerRadius = 20;
            this.SendMessage.IdleFillColor = Color.White;
            this.SendMessage.IdleForecolor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendMessage.IdleLineColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendMessage.Location = new Point(579, 299);
            this.SendMessage.Margin = new Padding(5);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new Size(105, 41);
            this.SendMessage.TabIndex = 8;
            this.SendMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new Point(11, -1);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new Size(141, 20);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Type Message Here:";
            // 
            // SmsControl
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.SingleSend);
            this.Controls.Add(this.SingleSendNumber);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.CheckList);
            this.Controls.Add(this.MessageContent);
            this.Name = "SmsControl";
            this.Size = new Size(723, 342);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuCustomTextbox MessageContent;
        private BunifuCheckbox CheckList;
        private BunifuCustomLabel bunifuCustomLabel1;
        private BunifuMetroTextbox SingleSendNumber;
        private BunifuCustomLabel bunifuCustomLabel2;
        private BunifuCheckbox SingleSend;
        private BunifuThinButton2 SendMessage;
        private BunifuCustomLabel bunifuCustomLabel3;
    }
}
