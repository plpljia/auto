namespace AutoProgramer
{
    partial class ProjectSelectForm
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
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BarCode_picbox = new System.Windows.Forms.PictureBox();
            this.Barcode_cbx = new System.Windows.Forms.CheckBox();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Project_DataGridView = new System.Windows.Forms.DataGridView();
            this.Choose_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Choose_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarCode_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Project_DataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Location = new System.Drawing.Point(13, 46);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(129, 23);
            this.Refresh_btn.TabIndex = 4;
            this.Refresh_btn.Text = "Refresh/Search";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BarCode_picbox);
            this.groupBox1.Controls.Add(this.Barcode_cbx);
            this.groupBox1.Controls.Add(this.Search_txt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Refresh_btn);
            this.groupBox1.Location = new System.Drawing.Point(560, 463);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 79);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // BarCode_picbox
            // 
            this.BarCode_picbox.Image = global::AutoProgramer.Properties.Resources._1;
            this.BarCode_picbox.Location = new System.Drawing.Point(300, 9);
            this.BarCode_picbox.Name = "BarCode_picbox";
            this.BarCode_picbox.Size = new System.Drawing.Size(155, 69);
            this.BarCode_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BarCode_picbox.TabIndex = 31;
            this.BarCode_picbox.TabStop = false;
            this.BarCode_picbox.Visible = false;
            // 
            // Barcode_cbx
            // 
            this.Barcode_cbx.AutoSize = true;
            this.Barcode_cbx.Location = new System.Drawing.Point(198, 53);
            this.Barcode_cbx.Name = "Barcode_cbx";
            this.Barcode_cbx.Size = new System.Drawing.Size(96, 16);
            this.Barcode_cbx.TabIndex = 30;
            this.Barcode_cbx.Text = "Use Barcode:";
            this.Barcode_cbx.UseVisualStyleBackColor = true;
            this.Barcode_cbx.CheckedChanged += new System.EventHandler(this.Barcode_cbx_CheckedChanged);
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(112, 11);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(182, 21);
            this.Search_txt.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "Search Project:";
            // 
            // Project_DataGridView
            // 
            this.Project_DataGridView.AllowUserToAddRows = false;
            this.Project_DataGridView.AllowUserToDeleteRows = false;
            this.Project_DataGridView.AllowUserToResizeColumns = false;
            this.Project_DataGridView.AllowUserToResizeRows = false;
            this.Project_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Project_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Project_DataGridView.Location = new System.Drawing.Point(-3, 1);
            this.Project_DataGridView.MultiSelect = false;
            this.Project_DataGridView.Name = "Project_DataGridView";
            this.Project_DataGridView.ReadOnly = true;
            this.Project_DataGridView.RowTemplate.Height = 23;
            this.Project_DataGridView.Size = new System.Drawing.Size(1026, 444);
            this.Project_DataGridView.TabIndex = 28;
            this.Project_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Project_DataGridView_CellClick);
            // 
            // Choose_txt
            // 
            this.Choose_txt.Location = new System.Drawing.Point(112, 11);
            this.Choose_txt.Name = "Choose_txt";
            this.Choose_txt.ReadOnly = true;
            this.Choose_txt.Size = new System.Drawing.Size(182, 21);
            this.Choose_txt.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Choose_txt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Choose_btn);
            this.groupBox2.Location = new System.Drawing.Point(131, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 79);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "Choose Project:";
            // 
            // Choose_btn
            // 
            this.Choose_btn.Location = new System.Drawing.Point(13, 46);
            this.Choose_btn.Name = "Choose_btn";
            this.Choose_btn.Size = new System.Drawing.Size(129, 23);
            this.Choose_btn.TabIndex = 4;
            this.Choose_btn.Text = "Choose This Project";
            this.Choose_btn.UseVisualStyleBackColor = true;
            this.Choose_btn.Click += new System.EventHandler(this.Choose_btn_Click);
            // 
            // ProjectSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Project_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProjectSelectForm";
            this.Load += new System.EventHandler(this.ProjectSelectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarCode_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Project_DataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Project_DataGridView;
        private System.Windows.Forms.CheckBox Barcode_cbx;
        private System.Windows.Forms.PictureBox BarCode_picbox;
        private System.Windows.Forms.TextBox Choose_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Choose_btn;
    }
}