using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Spire.Xls;
using Spire.Xls.Collections;
using System.Data.OleDb;
using ExcelDataReader;

namespace ExcelMerger
{
    
    public partial class FRM_Main : Form
    {
        List<String> RawFiles = new List<string>();
         
        public FRM_Main()
        {
            InitializeComponent();
        }
        private void BTTN_StartMerge_Click(object sender, EventArgs e)
        {
            Workbook newbook = new Workbook();
            newbook.Version = ExcelVersion.Version2010;
            newbook.Worksheets.Clear();

            Workbook tempbook = new Workbook();

            string[] excelFiles = RawFiles.ToArray();

            for (int i = 0; i < excelFiles.Length; i++)
            {
                tempbook.LoadFromFile(excelFiles[i]);
                var results = GetAllWorksheets(excelFiles[i]);
                int s = 0;
                foreach (Worksheet sheets in results)
                {
                    s++;
                }

                for (int sn = 0; sn < s; sn++) {
                    Worksheet sheet = tempbook.Worksheets[sn];

                    newbook.Worksheets.AddCopy(sheet);
                }

            }
            SFD_File.Filter = "Excel |*.xlsx";
            SFD_File.FileName = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy@HHmm")) + "_" + "Excel_Merged_File";
            if (SFD_File.ShowDialog() == DialogResult.OK)
            {
                
                newbook.SaveToFile(SFD_File.FileName, ExcelVersion.Version2010);
                MessageBox.Show("Merge completed");
                System.Diagnostics.Process.Start(Path.GetDirectoryName(SFD_File.FileName));

                RawFiles.Clear();
                DGV_Files.DataSource = "";
                BTTN_StartMerge.Enabled = false;

            }

        }

        private void BTTN_FileSelect_Click(object sender, EventArgs e)
        {
            RawFiles.Clear();
            DataTable DT_Files = new DataTable();
            OFD_Files.Filter = "Excel Files| *.xlsx; *.xls";

            if (OFD_Files.ShowDialog() == DialogResult.OK)
            {
                string[] files = OFD_Files.FileNames;
                
                DT_Files.Columns.Add("File");
                
                foreach (string file in files)
                {
                    DT_Files.Rows.Add(file);
                    RawFiles.Add(file);
                }

                DGV_Files.DataSource = DT_Files;
            }

            if (DT_Files.Rows.Count >= 1){
            BTTN_StartMerge.Enabled = true;
            }

            

        }

        public static WorksheetsCollection GetAllWorksheets(string fileName)
        {
            //Initialize a new Workboook object
            Workbook workbook = new Workbook();

            //Load the document
            workbook.LoadFromFile(fileName);

            //Get all worksheets
            WorksheetsCollection worksheets = workbook.Worksheets;

            return worksheets;
        }
    }

}