namespace GoodNewsBlaster.Sms
{
    partial class SmsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmsForm));
            this.Header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Config = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Send = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Slider = new System.Windows.Forms.PictureBox();
            this.Import = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ContentArea = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Header.Controls.Add(this.bunifuImageButton2);
            this.Header.Controls.Add(this.bunifuCustomLabel1);
            this.Header.Controls.Add(this.bunifuImageButton1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(924, 48);
            this.Header.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(872, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(52, 45);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(74, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(127, 21);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Good News SMS";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Config);
            this.panel1.Controls.Add(this.Send);
            this.panel1.Controls.Add(this.Slider);
            this.panel1.Controls.Add(this.Import);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 52);
            this.panel1.TabIndex = 1;
            // 
            // Config
            // 
            this.Config.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.Config.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Config.BorderRadius = 0;
            this.Config.ButtonText = "Configurations";
            this.Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Config.DisabledColor = System.Drawing.Color.Gray;
            this.Config.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config.Iconcolor = System.Drawing.Color.Transparent;
            this.Config.Iconimage = null;
            this.Config.Iconimage_right = null;
            this.Config.Iconimage_right_Selected = null;
            this.Config.Iconimage_Selected = null;
            this.Config.IconMarginLeft = 0;
            this.Config.IconMarginRight = 0;
            this.Config.IconRightVisible = true;
            this.Config.IconRightZoom = 0D;
            this.Config.IconVisible = true;
            this.Config.IconZoom = 90D;
            this.Config.IsTab = false;
            this.Config.Location = new System.Drawing.Point(208, 17);
            this.Config.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Config.Name = "Config";
            this.Config.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.Config.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.Config.OnHoverTextColor = System.Drawing.Color.White;
            this.Config.selected = false;
            this.Config.Size = new System.Drawing.Size(112, 24);
            this.Config.TabIndex = 3;
            this.Config.Text = "Configurations";
            this.Config.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Config.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Config.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config.Click += new System.EventHandler(this.Config_Click);
            // 
            // Send
            // 
            this.Send.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.Send.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Send.BorderRadius = 0;
            this.Send.ButtonText = "Send";
            this.Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send.DisabledColor = System.Drawing.Color.Gray;
            this.Send.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Iconcolor = System.Drawing.Color.Transparent;
            this.Send.Iconimage = null;
            this.Send.Iconimage_right = null;
            this.Send.Iconimage_right_Selected = null;
            this.Send.Iconimage_Selected = null;
            this.Send.IconMarginLeft = 0;
            this.Send.IconMarginRight = 0;
            this.Send.IconRightVisible = true;
            this.Send.IconRightZoom = 0D;
            this.Send.IconVisible = true;
            this.Send.IconZoom = 90D;
            this.Send.IsTab = false;
            this.Send.Location = new System.Drawing.Point(113, 17);
            this.Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Send.Name = "Send";
            this.Send.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.Send.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.Send.OnHoverTextColor = System.Drawing.Color.White;
            this.Send.selected = false;
            this.Send.Size = new System.Drawing.Size(87, 24);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Send.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Send.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Slider
            // 
            this.Slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Slider.Location = new System.Drawing.Point(18, 49);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(87, 5);
            this.Slider.TabIndex = 1;
            this.Slider.TabStop = false;
            // 
            // Import
            // 
            this.Import.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.Import.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Import.BorderRadius = 0;
            this.Import.ButtonText = "Import";
            this.Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Import.DisabledColor = System.Drawing.Color.Gray;
            this.Import.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import.Iconcolor = System.Drawing.Color.Transparent;
            this.Import.Iconimage = null;
            this.Import.Iconimage_right = null;
            this.Import.Iconimage_right_Selected = null;
            this.Import.Iconimage_Selected = null;
            this.Import.IconMarginLeft = 0;
            this.Import.IconMarginRight = 0;
            this.Import.IconRightVisible = true;
            this.Import.IconRightZoom = 0D;
            this.Import.IconVisible = true;
            this.Import.IconZoom = 90D;
            this.Import.IsTab = false;
            this.Import.Location = new System.Drawing.Point(18, 17);
            this.Import.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Import.Name = "Import";
            this.Import.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.Import.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.Import.OnHoverTextColor = System.Drawing.Color.White;
            this.Import.selected = false;
            this.Import.Size = new System.Drawing.Size(87, 24);
            this.Import.TabIndex = 0;
            this.Import.Text = "Import";
            this.Import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Import.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Import.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // ContentArea
            // 
            this.ContentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentArea.Location = new System.Drawing.Point(0, 100);
            this.ContentArea.Name = "ContentArea";
            this.ContentArea.Size = new System.Drawing.Size(924, 355);
            this.ContentArea.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(924, 455);
            this.Controls.Add(this.ContentArea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SmsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Good News";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Import;
        private System.Windows.Forms.PictureBox Slider;
        private Bunifu.Framework.UI.BunifuFlatButton Send;
        private System.Windows.Forms.Panel ContentArea;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton Config;
    }
}

