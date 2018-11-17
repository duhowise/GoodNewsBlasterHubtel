using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ExcelDataReader;

namespace GoodNewsBlaster.Sms
{
    public partial class ImportControl : UserControl
    {

        public static List<Member> Members;
        BindingList<Member> tempMembers;
        private DataSet _dataSet;

        public ImportControl()
        {
            InitializeComponent();
            SmsControl.DataExtractedEvent += SmsControl_DataExtractedEvent;
            ImportData.Click += ImportData_Click;

            clear.Click += Clear_Click;
            _dataSet = new DataSet();
            Members = new List<Member>();
            tempMembers = new BindingList<Member>();
            ImportedFilename.Text = $@"File: no file Imported";

        }

        private void SmsControl_DataExtractedEvent(object source, EventArgs args)
        {
            ExtractInformation();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            MembersGrid.DataSource = null;
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

                            MembersGrid.Rows.Clear();
                            var all = new DataSet();
                            foreach (DataTable dt in _dataSet.Tables)
                            {
                                foreach (DataRow dataRow in dt.Rows)
                                {
                                    var mem=new Member
                                    {
                                        Name = dataRow[0] as string,
                                        Number = dataRow[1] as string
                                    };


                                    tempMembers.Add(mem);
                                }
                            }

                            MembersGrid.AutoGenerateColumns = true;

                            var source=new BindingSource(tempMembers,null);
                            MembersGrid.DataSource = source;
                            reader.Close();

                        }

                        ImportedFilename.Text = $@"{ImportedFilename.Text} {MembersGrid.Rows.Count}";

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, @"File Read Error");
                    }
                }

            }
        }

        public void ExtractInformation()
        {
            foreach (DataGridViewRow row in MembersGrid.Rows)
            {
                string val = row.Cells[1].Value as string;
                if (string.IsNullOrEmpty(val))
                {
                    MembersGrid.Rows.Remove(row);
                }
            }

            foreach (DataGridViewRow row in MembersGrid.Rows)
            {

                if (!string.IsNullOrEmpty(Convert.ToString(row.Cells[1].Value)))
                {
                    var memberInfo = new Member()
                    {
                        Name = Convert.ToString(row.Cells[0].Value),
                        Number = Convert.ToString(row.Cells[1].Value),
                    };

                    tempMembers.Add(memberInfo);
                }


                Thread.Sleep(20);
            }

            foreach (var member in tempMembers)
            {
                if (member.Number != null)
                {
                    var substring = member.Number.Substring(1);

                    member.Number = $"233{substring}";
                }
            }

            Members.AddRange(tempMembers);
        }

        private void SaveImport_Click(object sender, EventArgs e)
        {
            //ExtractInformation();
            MembersGrid.DataSource = Members;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class DataColumnAttribute : Attribute
    {
    }
}
