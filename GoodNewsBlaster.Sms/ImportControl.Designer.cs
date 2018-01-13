namespace GoodNewsBlaster.Sms
{
    partial class ImportControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImportedFilename = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ImportData = new Bunifu.Framework.UI.BunifuThinButton2();
            this.clear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveImport = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NamesGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.NamesGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 319);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImportedFilename);
            this.panel1.Controls.Add(this.ImportData);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.SaveImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 46);
            this.panel1.TabIndex = 1;
            // 
            // ImportedFilename
            // 
            this.ImportedFilename.AutoSize = true;
            this.ImportedFilename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportedFilename.Location = new System.Drawing.Point(3, 13);
            this.ImportedFilename.Name = "ImportedFilename";
            this.ImportedFilename.Size = new System.Drawing.Size(0, 21);
            this.ImportedFilename.TabIndex = 9;
            // 
            // ImportData
            // 
            this.ImportData.ActiveBorderThickness = 1;
            this.ImportData.ActiveCornerRadius = 20;
            this.ImportData.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.ImportData.ActiveForecolor = System.Drawing.Color.White;
            this.ImportData.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ImportData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ImportData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImportData.BackgroundImage")));
            this.ImportData.ButtonText = "Import";
            this.ImportData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ImportData.IdleBorderThickness = 1;
            this.ImportData.IdleCornerRadius = 20;
            this.ImportData.IdleFillColor = System.Drawing.Color.White;
            this.ImportData.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ImportData.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ImportData.Location = new System.Drawing.Point(451, 6);
            this.ImportData.Margin = new System.Windows.Forms.Padding(5);
            this.ImportData.Name = "ImportData";
            this.ImportData.Size = new System.Drawing.Size(93, 39);
            this.ImportData.TabIndex = 8;
            this.ImportData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clear
            // 
            this.clear.ActiveBorderThickness = 1;
            this.clear.ActiveCornerRadius = 20;
            this.clear.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.clear.ActiveForecolor = System.Drawing.Color.White;
            this.clear.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear.BackgroundImage")));
            this.clear.ButtonText = "Clear";
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clear.IdleBorderThickness = 1;
            this.clear.IdleCornerRadius = 20;
            this.clear.IdleFillColor = System.Drawing.Color.White;
            this.clear.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clear.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clear.Location = new System.Drawing.Point(348, 6);
            this.clear.Margin = new System.Windows.Forms.Padding(5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(93, 39);
            this.clear.TabIndex = 7;
            this.clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveImport
            // 
            this.SaveImport.ActiveBorderThickness = 1;
            this.SaveImport.ActiveCornerRadius = 20;
            this.SaveImport.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.SaveImport.ActiveForecolor = System.Drawing.Color.White;
            this.SaveImport.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveImport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaveImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveImport.BackgroundImage")));
            this.SaveImport.ButtonText = "&Save";
            this.SaveImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveImport.IdleBorderThickness = 1;
            this.SaveImport.IdleCornerRadius = 20;
            this.SaveImport.IdleFillColor = System.Drawing.Color.White;
            this.SaveImport.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveImport.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveImport.Location = new System.Drawing.Point(554, 5);
            this.SaveImport.Margin = new System.Windows.Forms.Padding(5);
            this.SaveImport.Name = "SaveImport";
            this.SaveImport.Size = new System.Drawing.Size(93, 39);
            this.SaveImport.TabIndex = 6;
            this.SaveImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NamesGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NamesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.NamesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NamesGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.NamesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NamesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NamesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.NamesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NamesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.NamesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NamesGrid.DoubleBuffered = true;
            this.NamesGrid.EnableHeadersVisualStyles = false;
            this.NamesGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.NamesGrid.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.NamesGrid.Location = new System.Drawing.Point(0, 0);
            this.NamesGrid.Name = "NamesGrid";
            this.NamesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.NamesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NamesGrid.Size = new System.Drawing.Size(662, 319);
            this.NamesGrid.TabIndex = 0;
            // 
            // ImportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel2);
            this.Name = "ImportControl";
            this.Size = new System.Drawing.Size(662, 319);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid NamesGrid;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 ImportData;
        private Bunifu.Framework.UI.BunifuThinButton2 clear;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveImport;
        private Bunifu.Framework.UI.BunifuCustomLabel ImportedFilename;
    }
}
