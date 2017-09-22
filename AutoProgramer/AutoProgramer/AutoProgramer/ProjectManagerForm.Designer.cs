namespace AutoProgramer
{
    partial class ProjectManagerForm
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
            this.Project_DataGridView = new System.Windows.Forms.DataGridView();
            this.AddProject_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Project_txt = new System.Windows.Forms.TextBox();
            this.Hex_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Manu_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Model_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PCB_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PartName_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Fireware_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Hex_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Hex_lbl = new System.Windows.Forms.Label();
            this.CheckSum_lbl = new System.Windows.Forms.Label();
            this.Barcode_cbx = new System.Windows.Forms.CheckBox();
            this.Barcode_txt = new System.Windows.Forms.TextBox();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Project_DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Project_DataGridView
            // 
            this.Project_DataGridView.AllowUserToAddRows = false;
            this.Project_DataGridView.AllowUserToDeleteRows = false;
            this.Project_DataGridView.AllowUserToResizeColumns = false;
            this.Project_DataGridView.AllowUserToResizeRows = false;
            this.Project_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Project_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Project_DataGridView.Location = new System.Drawing.Point(-1, 0);
            this.Project_DataGridView.MultiSelect = false;
            this.Project_DataGridView.Name = "Project_DataGridView";
            this.Project_DataGridView.ReadOnly = true;
            this.Project_DataGridView.RowTemplate.Height = 23;
            this.Project_DataGridView.Size = new System.Drawing.Size(1026, 444);
            this.Project_DataGridView.TabIndex = 0;
            this.Project_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Project_DataGridView_CellClick);
            // 
            // AddProject_btn
            // 
            this.AddProject_btn.Location = new System.Drawing.Point(865, 108);
            this.AddProject_btn.Name = "AddProject_btn";
            this.AddProject_btn.Size = new System.Drawing.Size(129, 23);
            this.AddProject_btn.TabIndex = 1;
            this.AddProject_btn.Text = "Add Project";
            this.AddProject_btn.UseVisualStyleBackColor = true;
            this.AddProject_btn.Click += new System.EventHandler(this.AddProject_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(865, 71);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(129, 23);
            this.Delete_btn.TabIndex = 3;
            this.Delete_btn.Text = "Delect Project";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Location = new System.Drawing.Point(306, 9);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(129, 23);
            this.Refresh_btn.TabIndex = 4;
            this.Refresh_btn.Text = "Refresh/Search";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project:";
            // 
            // Project_txt
            // 
            this.Project_txt.Location = new System.Drawing.Point(72, 9);
            this.Project_txt.Name = "Project_txt";
            this.Project_txt.Size = new System.Drawing.Size(158, 21);
            this.Project_txt.TabIndex = 6;
            // 
            // Hex_txt
            // 
            this.Hex_txt.Location = new System.Drawing.Point(363, 45);
            this.Hex_txt.Name = "Hex_txt";
            this.Hex_txt.ReadOnly = true;
            this.Hex_txt.Size = new System.Drawing.Size(407, 21);
            this.Hex_txt.TabIndex = 8;
            this.Hex_txt.Click += new System.EventHandler(this.Hex_txt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hex path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Check sum:";
            // 
            // Manu_txt
            // 
            this.Manu_txt.Location = new System.Drawing.Point(86, 44);
            this.Manu_txt.Name = "Manu_txt";
            this.Manu_txt.Size = new System.Drawing.Size(144, 21);
            this.Manu_txt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Manufacture:";
            // 
            // Model_txt
            // 
            this.Model_txt.Location = new System.Drawing.Point(372, 78);
            this.Model_txt.Name = "Model_txt";
            this.Model_txt.Size = new System.Drawing.Size(148, 21);
            this.Model_txt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Model name:";
            // 
            // PCB_txt
            // 
            this.PCB_txt.Location = new System.Drawing.Point(625, 77);
            this.PCB_txt.Name = "PCB_txt";
            this.PCB_txt.Size = new System.Drawing.Size(145, 21);
            this.PCB_txt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "PCB name:";
            // 
            // PartName_txt
            // 
            this.PartName_txt.Location = new System.Drawing.Point(76, 111);
            this.PartName_txt.Name = "PartName_txt";
            this.PartName_txt.Size = new System.Drawing.Size(154, 21);
            this.PartName_txt.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "Part name:";
            // 
            // Fireware_txt
            // 
            this.Fireware_txt.Location = new System.Drawing.Point(118, 77);
            this.Fireware_txt.Name = "Fireware_txt";
            this.Fireware_txt.Size = new System.Drawing.Size(112, 21);
            this.Fireware_txt.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fireware version:";
            // 
            // Hex_OpenFileDialog
            // 
            this.Hex_OpenFileDialog.FileName = "Hex_OpenFileDialog";
            this.Hex_OpenFileDialog.Filter = "|*.hex";
            // 
            // Hex_lbl
            // 
            this.Hex_lbl.AutoSize = true;
            this.Hex_lbl.Location = new System.Drawing.Point(384, 12);
            this.Hex_lbl.Name = "Hex_lbl";
            this.Hex_lbl.Size = new System.Drawing.Size(35, 12);
            this.Hex_lbl.TabIndex = 21;
            this.Hex_lbl.Text = "-----";
            // 
            // CheckSum_lbl
            // 
            this.CheckSum_lbl.AutoSize = true;
            this.CheckSum_lbl.Location = new System.Drawing.Point(584, 12);
            this.CheckSum_lbl.Name = "CheckSum_lbl";
            this.CheckSum_lbl.Size = new System.Drawing.Size(35, 12);
            this.CheckSum_lbl.TabIndex = 22;
            this.CheckSum_lbl.Text = "-----";
            // 
            // Barcode_cbx
            // 
            this.Barcode_cbx.AutoSize = true;
            this.Barcode_cbx.Location = new System.Drawing.Point(299, 114);
            this.Barcode_cbx.Name = "Barcode_cbx";
            this.Barcode_cbx.Size = new System.Drawing.Size(126, 16);
            this.Barcode_cbx.TabIndex = 23;
            this.Barcode_cbx.Text = "Use Barcode Name:";
            this.Barcode_cbx.UseVisualStyleBackColor = true;
            // 
            // Barcode_txt
            // 
            this.Barcode_txt.Location = new System.Drawing.Point(431, 109);
            this.Barcode_txt.Name = "Barcode_txt";
            this.Barcode_txt.Size = new System.Drawing.Size(339, 21);
            this.Barcode_txt.TabIndex = 24;
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(106, 9);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(182, 21);
            this.Search_txt.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "Search Project:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Refresh_btn);
            this.groupBox1.Controls.Add(this.Search_txt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(577, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 36);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete_btn);
            this.groupBox2.Controls.Add(this.AddProject_btn);
            this.groupBox2.Controls.Add(this.Barcode_txt);
            this.groupBox2.Controls.Add(this.Barcode_cbx);
            this.groupBox2.Controls.Add(this.CheckSum_lbl);
            this.groupBox2.Controls.Add(this.Hex_lbl);
            this.groupBox2.Controls.Add(this.Fireware_txt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.PartName_txt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.PCB_txt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Model_txt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Manu_txt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Hex_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Project_txt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 486);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 147);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // ProjectManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Project_DataGridView);
            this.Name = "ProjectManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Isa3Project Manager";
            ((System.ComponentModel.ISupportInitialize)(this.Project_DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Project_DataGridView;
        private System.Windows.Forms.Button AddProject_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Project_txt;
        private System.Windows.Forms.TextBox Hex_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Manu_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Model_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PCB_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PartName_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Fireware_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog Hex_OpenFileDialog;
        private System.Windows.Forms.Label Hex_lbl;
        private System.Windows.Forms.Label CheckSum_lbl;
        private System.Windows.Forms.CheckBox Barcode_cbx;
        private System.Windows.Forms.TextBox Barcode_txt;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}