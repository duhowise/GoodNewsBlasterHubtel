using System;
using System.Collections.Generic;
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
        List<Member> tempMembers;
        private DataSet _dataSet;
        public ImportControl()
        {
            InitializeComponent();
            SmsControl.DataExtractedEvent += SmsControl_DataExtractedEvent            ;
            ImportData.Click += ImportData_Click ;
           
            clear.Click += Clear_Click            ;
            _dataSet=new DataSet();
            Members=new List<Member>();
            tempMembers=new List<Member>();
            ImportedFilename.Text =$@"File: no file Imported";

        }

        private void SmsControl_DataExtractedEvent(object source, EventArgs args)
        {
           ExtractInformation();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NamesGrid.DataSource = null;
            ImportedFilename.Text =$@"File: no file Imported";

        }

        private void ImportData_Click(object sender, EventArgs e)
        {
            ImportMembers();
        }

        private void ImportMembers()
        {
            using (var openFileDialog = new OpenFileDialog() { Filter =@"Excel 1996-2007 Files |*.xls;*.xlsx;", ValidateNames = true })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
				
                    try
                    {
                        FileStream fs = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                        ImportedFilename.Text =$@"File: {openFileDialog.SafeFileName}";
                        var reader = ExcelReaderFactory.CreateReader(fs);
                        _dataSet = reader.AsDataSet(new ExcelDataSetConfiguration
                        {
                            ConfigureDataTable = data => new ExcelDataTableConfiguration
                            {
                                UseHeaderRow = true
                            }
                        });
                       foreach (DataTable table in _dataSet.Tables)
                        {
                            NamesGrid.DataSource = _dataSet.Tables[table.TableName].DefaultView;                       
                        }
                        foreach (DataGridViewRow row in NamesGrid.Rows)
                        {
                            var val = row.Cells[1].Value as string;
                           if (string.IsNullOrWhiteSpace(val))
                            {
                                NamesGrid.Rows.Remove(row);
                            }        
                        }
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
            foreach (DataGridViewRow row in NamesGrid.Rows)
            {
                string val = row.Cells[1].Value as string;
                if (string.IsNullOrEmpty(val))
                {
                    NamesGrid.Rows.Remove(row);
                }        
            }
            foreach (DataGridViewRow row in NamesGrid.Rows)
            {
               
                if ( !string.IsNullOrEmpty(Convert.ToString(row.Cells[1].Value)))
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
            NamesGrid.DataSource = Members;
        }
    }
}
