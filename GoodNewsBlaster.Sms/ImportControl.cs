using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ExcelDataReader;

namespace GoodNewsBlaster.Sms
{
    public partial class ImportControl : UserControl
    {
        private readonly NotifyIcon _notifyIcon;

       public static List<Member> Members;
        private DataSet _dataSet;

        public ImportControl(NotifyIcon notifyIcon)
        {
            _notifyIcon = notifyIcon;
            InitializeComponent();
            ImportData.Click += ImportData_Click;
            clear.Click += Clear_Click;
            _dataSet = new DataSet();
            Members = new List<Member>();
            ImportedFilename.Text = $@"File: no file Imported";

        }
        

        private void Clear_Click(object sender, EventArgs e)
        {
            NamesGrid.DataSource = null;
            ImportedFilename.Text = $@"File: no file Imported";

        }

        private void ImportData_Click(object sender, EventArgs e)
        {
            ImportMembers();
        }

        private void ImportMembers()
        {

            using (var openFileDialog = new OpenFileDialog()
                {Filter = @"Excel 1996-2007 Files |*.xls;*.xlsx;", ValidateNames = true})
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImportedFilename.Text = $@"File: {openFileDialog.SafeFileName}";
                    try
                    {
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            IExcelDataReader reader;
                            reader = openFileDialog.FilterIndex == 2
                                ? ExcelReaderFactory.CreateBinaryReader(stream)
                                : ExcelReaderFactory.CreateOpenXmlReader(stream);

                            _dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = _ => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });

                            NamesGrid.Rows.Clear();
                            Members.Clear();
                            Members=new List<Member>();
                            foreach (DataTable dt in _dataSet.Tables)
                            {
                                foreach (DataRow dataRow in dt.Rows)
                                {
                                    var mem=new Member
                                    {
                                        Name = dataRow[0] as string,
                                        Number = dataRow[1] as string
                                    };


                                    Members.Add(mem);
                                }
                            }

                            Members.RemoveAll(x => x.Number == null);
                            var source=new BindingSource(Members,null);
                            NamesGrid.DataSource = source;
                            reader.Close();
                            _notifyIcon.Icon = SystemIcons.Application;
                            _notifyIcon.ShowBalloonTip(3000,"Import Members",$"{Members.Count} Member(s) imported successfully",ToolTipIcon.Info);
                        }

                        ImportedFilename.Text = $@"{ImportedFilename.Text} {NamesGrid.Rows.Count}";

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, @"File Read Error");
                    }
                }

            }
        }

        private void SaveImport_Click(object sender, EventArgs e)
        {
            //ExtractInformation();
            NamesGrid.DataSource = Members;
        }
    }

    
}
