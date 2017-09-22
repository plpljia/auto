namespace AutoProgramer
{
    partial class UserForm
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
            this.User_DataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RemoveProject_btn = new System.Windows.Forms.Button();
            this.DelUser_btn = new System.Windows.Forms.Button();
            this.UpdateUser_btn = new System.Windows.Forms.Button();
            this.AddUser_btn = new System.Windows.Forms.Button();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectGroup_cbx = new System.Windows.Forms.ComboBox();
            this.UserGroup_cbx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProjectName_txt = new System.Windows.Forms.TextBox();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.FullName_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.User_DataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // User_DataGridView
            // 
            this.User_DataGridView.AllowUserToAddRows = false;
            this.User_DataGridView.AllowUserToDeleteRows = false;
            this.User_DataGridView.AllowUserToResizeColumns = false;
            this.User_DataGridView.AllowUserToResizeRows = false;
            this.User_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.User_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.User_DataGridView.Location = new System.Drawing.Point(2, 1);
            this.User_DataGridView.MultiSelect = false;
            this.User_DataGridView.Name = "User_DataGridView";
            this.User_DataGridView.ReadOnly = true;
            this.User_DataGridView.RowTemplate.Height = 23;
            this.User_DataGridView.Size = new System.Drawing.Size(765, 441);
            this.User_DataGridView.TabIndex = 1;
            this.User_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_DataGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.Password_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ProjectGroup_cbx);
            this.groupBox2.Controls.Add(this.UserGroup_cbx);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ProjectName_txt);
            this.groupBox2.Controls.Add(this.UserName_txt);
            this.groupBox2.Controls.Add(this.FullName_txt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 499);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 129);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RemoveProject_btn);
            this.groupBox3.Controls.Add(this.DelUser_btn);
            this.groupBox3.Controls.Add(this.UpdateUser_btn);
            this.groupBox3.Controls.Add(this.AddUser_btn);
            this.groupBox3.Location = new System.Drawing.Point(451, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 90);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Action";
            // 
            // RemoveProject_btn
            // 
            this.RemoveProject_btn.Location = new System.Drawing.Point(151, 58);
            this.RemoveProject_btn.Name = "RemoveProject_btn";
            this.RemoveProject_btn.Size = new System.Drawing.Size(129, 23);
            this.RemoveProject_btn.TabIndex = 24;
            this.RemoveProject_btn.Text = "Remove Project";
            this.RemoveProject_btn.UseVisualStyleBackColor = true;
            this.RemoveProject_btn.Click += new System.EventHandler(this.RemoveProject_btn_Click);
            // 
            // DelUser_btn
            // 
            this.DelUser_btn.Location = new System.Drawing.Point(150, 21);
            this.DelUser_btn.Name = "DelUser_btn";
            this.DelUser_btn.Size = new System.Drawing.Size(129, 23);
            this.DelUser_btn.TabIndex = 23;
            this.DelUser_btn.Text = "Delete User";
            this.DelUser_btn.UseVisualStyleBackColor = true;
            this.DelUser_btn.Click += new System.EventHandler(this.DelUser_btn_Click);
            // 
            // UpdateUser_btn
            // 
            this.UpdateUser_btn.Location = new System.Drawing.Point(15, 58);
            this.UpdateUser_btn.Name = "UpdateUser_btn";
            this.UpdateUser_btn.Size = new System.Drawing.Size(129, 23);
            this.UpdateUser_btn.TabIndex = 22;
            this.UpdateUser_btn.Text = "Update User";
            this.UpdateUser_btn.UseVisualStyleBackColor = true;
            this.UpdateUser_btn.Click += new System.EventHandler(this.UpdateUser_btn_Click);
            // 
            // AddUser_btn
            // 
            this.AddUser_btn.Location = new System.Drawing.Point(15, 21);
            this.AddUser_btn.Name = "AddUser_btn";
            this.AddUser_btn.Size = new System.Drawing.Size(129, 23);
            this.AddUser_btn.TabIndex = 21;
            this.AddUser_btn.Text = "Add User";
            this.AddUser_btn.UseVisualStyleBackColor = true;
            this.AddUser_btn.Click += new System.EventHandler(this.AddUser_btn_Click);
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(310, 54);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(125, 21);
            this.Password_txt.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "Password:";
            // 
            // ProjectGroup_cbx
            // 
            this.ProjectGroup_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectGroup_cbx.FormattingEnabled = true;
            this.ProjectGroup_cbx.Location = new System.Drawing.Point(87, 93);
            this.ProjectGroup_cbx.Name = "ProjectGroup_cbx";
            this.ProjectGroup_cbx.Size = new System.Drawing.Size(132, 20);
            this.ProjectGroup_cbx.TabIndex = 26;
            // 
            // UserGroup_cbx
            // 
            this.UserGroup_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserGroup_cbx.FormattingEnabled = true;
            this.UserGroup_cbx.Location = new System.Drawing.Point(87, 19);
            this.UserGroup_cbx.Name = "UserGroup_cbx";
            this.UserGroup_cbx.Size = new System.Drawing.Size(132, 20);
            this.UserGroup_cbx.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "ProjectGroup:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "UserGroup:";
            // 
            // ProjectName_txt
            // 
            this.ProjectName_txt.Location = new System.Drawing.Point(310, 93);
            this.ProjectName_txt.Name = "ProjectName_txt";
            this.ProjectName_txt.ReadOnly = true;
            this.ProjectName_txt.Size = new System.Drawing.Size(126, 21);
            this.ProjectName_txt.TabIndex = 14;
            this.ProjectName_txt.Click += new System.EventHandler(this.ProjectName_txt_Click);
            // 
            // UserName_txt
            // 
            this.UserName_txt.Location = new System.Drawing.Point(310, 19);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(125, 21);
            this.UserName_txt.TabIndex = 6;
            // 
            // FullName_txt
            // 
            this.FullName_txt.Location = new System.Drawing.Point(87, 54);
            this.FullName_txt.Name = "FullName_txt";
            this.FullName_txt.Size = new System.Drawing.Size(132, 21);
            this.FullName_txt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "ProjectName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "FullName:";
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(96, 15);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(146, 21);
            this.Search_txt.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "Search User:";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Location = new System.Drawing.Point(261, 14);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(129, 23);
            this.Refresh_btn.TabIndex = 29;
            this.Refresh_btn.Text = "Refresh/Search";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Refresh_btn);
            this.groupBox1.Controls.Add(this.Search_txt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(351, 448);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 48);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 633);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.User_DataGridView);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User_DataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView User_DataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProjectName_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FullName_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveProject_btn;
        private System.Windows.Forms.Button DelUser_btn;
        private System.Windows.Forms.Button UpdateUser_btn;
        private System.Windows.Forms.Button AddUser_btn;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.ComboBox ProjectGroup_cbx;
        private System.Windows.Forms.ComboBox UserGroup_cbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}