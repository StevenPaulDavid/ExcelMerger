namespace ExcelMerger
{
    partial class FRM_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.TLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.LAB_Step1 = new System.Windows.Forms.Label();
            this.BTTN_FileSelect = new System.Windows.Forms.Button();
            this.DGV_Files = new System.Windows.Forms.DataGridView();
            this.LAB_Notes = new System.Windows.Forms.Label();
            this.BTTN_StartMerge = new System.Windows.Forms.Button();
            this.OFD_Files = new System.Windows.Forms.OpenFileDialog();
            this.SFD_File = new System.Windows.Forms.SaveFileDialog();
            this.TLP_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Files)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP_Main
            // 
            this.TLP_Main.ColumnCount = 2;
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 515F));
            this.TLP_Main.Controls.Add(this.LAB_Step1, 0, 0);
            this.TLP_Main.Controls.Add(this.BTTN_FileSelect, 1, 1);
            this.TLP_Main.Controls.Add(this.DGV_Files, 0, 2);
            this.TLP_Main.Controls.Add(this.LAB_Notes, 0, 7);
            this.TLP_Main.Controls.Add(this.BTTN_StartMerge, 1, 8);
            this.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Main.Location = new System.Drawing.Point(0, 0);
            this.TLP_Main.Margin = new System.Windows.Forms.Padding(4);
            this.TLP_Main.Name = "TLP_Main";
            this.TLP_Main.RowCount = 9;
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Main.Size = new System.Drawing.Size(517, 638);
            this.TLP_Main.TabIndex = 0;
            // 
            // LAB_Step1
            // 
            this.TLP_Main.SetColumnSpan(this.LAB_Step1, 2);
            this.LAB_Step1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_Step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Step1.Location = new System.Drawing.Point(3, 0);
            this.LAB_Step1.Name = "LAB_Step1";
            this.LAB_Step1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LAB_Step1.Size = new System.Drawing.Size(511, 30);
            this.LAB_Step1.TabIndex = 0;
            this.LAB_Step1.Text = "Select the files to merge";
            this.LAB_Step1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BTTN_FileSelect
            // 
            this.BTTN_FileSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTTN_FileSelect.Location = new System.Drawing.Point(388, 33);
            this.BTTN_FileSelect.Name = "BTTN_FileSelect";
            this.BTTN_FileSelect.Size = new System.Drawing.Size(126, 30);
            this.BTTN_FileSelect.TabIndex = 1;
            this.BTTN_FileSelect.Text = "Browse";
            this.BTTN_FileSelect.UseVisualStyleBackColor = true;
            this.BTTN_FileSelect.Click += new System.EventHandler(this.BTTN_FileSelect_Click);
            // 
            // DGV_Files
            // 
            this.DGV_Files.AllowUserToDeleteRows = false;
            this.DGV_Files.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Files.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGV_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TLP_Main.SetColumnSpan(this.DGV_Files, 2);
            this.DGV_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Files.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_Files.Location = new System.Drawing.Point(3, 69);
            this.DGV_Files.Name = "DGV_Files";
            this.DGV_Files.Size = new System.Drawing.Size(511, 377);
            this.DGV_Files.TabIndex = 2;
            // 
            // LAB_Notes
            // 
            this.TLP_Main.SetColumnSpan(this.LAB_Notes, 2);
            this.LAB_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_Notes.Location = new System.Drawing.Point(3, 449);
            this.LAB_Notes.Name = "LAB_Notes";
            this.LAB_Notes.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.LAB_Notes.Size = new System.Drawing.Size(511, 150);
            this.LAB_Notes.TabIndex = 9;
            this.LAB_Notes.Text = "Excel Merger will create a new Excel file with all sheets for each workbook\r\n\r\nEx" +
    "cel Merger is limited to 5 sheets per workbook and 200 rows per sheet";
            // 
            // BTTN_StartMerge
            // 
            this.BTTN_StartMerge.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTTN_StartMerge.Enabled = false;
            this.BTTN_StartMerge.Location = new System.Drawing.Point(388, 602);
            this.BTTN_StartMerge.Name = "BTTN_StartMerge";
            this.BTTN_StartMerge.Size = new System.Drawing.Size(126, 33);
            this.BTTN_StartMerge.TabIndex = 10;
            this.BTTN_StartMerge.Text = "Merge";
            this.BTTN_StartMerge.UseVisualStyleBackColor = true;
            this.BTTN_StartMerge.Click += new System.EventHandler(this.BTTN_StartMerge_Click);
            // 
            // OFD_Files
            // 
            this.OFD_Files.FileName = "Select Excel Files";
            this.OFD_Files.Multiselect = true;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 638);
            this.Controls.Add(this.TLP_Main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Merger";
            this.TLP_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Files)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_Main;
        private System.Windows.Forms.Button BTTN_FileSelect;
        private System.Windows.Forms.Label LAB_Notes;
        private System.Windows.Forms.Button BTTN_StartMerge;
        private System.Windows.Forms.OpenFileDialog OFD_Files;
        private System.Windows.Forms.DataGridView DGV_Files;
        private System.Windows.Forms.Label LAB_Step1;
        private System.Windows.Forms.SaveFileDialog SFD_File;
    }
}

