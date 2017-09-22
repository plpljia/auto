namespace AutoProgramer
{
    partial class LoginForm
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
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserManager_btn = new System.Windows.Forms.Button();
            this.ProjectManager_btn = new System.Windows.Forms.Button();
            this.MachineManager_btn = new System.Windows.Forms.Button();
            this.LocalSetting = new System.Windows.Forms.Button();
            this.SelectProgramer = new System.Windows.Forms.Button();
            this.LogView_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName_txt
            // 
            this.UserName_txt.Location = new System.Drawing.Point(112, 98);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(142, 21);
            this.UserName_txt.TabIndex = 0;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(112, 143);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(142, 21);
            this.Password_txt.TabIndex = 1;
            this.Password_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password：";
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(37, 193);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(217, 29);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AutoProgramer.Properties.Resources.UEI_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UserManager_btn
            // 
            this.UserManager_btn.Location = new System.Drawing.Point(294, 139);
            this.UserManager_btn.Name = "UserManager_btn";
            this.UserManager_btn.Size = new System.Drawing.Size(120, 26);
            this.UserManager_btn.TabIndex = 6;
            this.UserManager_btn.Text = "User Manager";
            this.UserManager_btn.UseVisualStyleBackColor = true;
            this.UserManager_btn.Visible = false;
            this.UserManager_btn.Click += new System.EventHandler(this.UserManager_btn_Click);
            // 
            // ProjectManager_btn
            // 
            this.ProjectManager_btn.Location = new System.Drawing.Point(294, 60);
            this.ProjectManager_btn.Name = "ProjectManager_btn";
            this.ProjectManager_btn.Size = new System.Drawing.Size(120, 26);
            this.ProjectManager_btn.TabIndex = 7;
            this.ProjectManager_btn.Text = "Project Manager";
            this.ProjectManager_btn.UseVisualStyleBackColor = true;
            this.ProjectManager_btn.Visible = false;
            this.ProjectManager_btn.Click += new System.EventHandler(this.ProjectManager_btn_Click);
            // 
            // MachineManager_btn
            // 
            this.MachineManager_btn.Location = new System.Drawing.Point(294, 98);
            this.MachineManager_btn.Name = "MachineManager_btn";
            this.MachineManager_btn.Size = new System.Drawing.Size(120, 26);
            this.MachineManager_btn.TabIndex = 8;
            this.MachineManager_btn.Text = "Machine Manager";
            this.MachineManager_btn.UseVisualStyleBackColor = true;
            this.MachineManager_btn.Visible = false;
            this.MachineManager_btn.Click += new System.EventHandler(this.MachineManager_btn_Click);
            // 
            // LocalSetting
            // 
            this.LocalSetting.Location = new System.Drawing.Point(294, 213);
            this.LocalSetting.Name = "LocalSetting";
            this.LocalSetting.Size = new System.Drawing.Size(120, 26);
            this.LocalSetting.TabIndex = 9;
            this.LocalSetting.Text = "Local Setting";
            this.LocalSetting.UseVisualStyleBackColor = true;
            this.LocalSetting.Visible = false;
            // 
            // SelectProgramer
            // 
            this.SelectProgramer.Location = new System.Drawing.Point(294, 250);
            this.SelectProgramer.Name = "SelectProgramer";
            this.SelectProgramer.Size = new System.Drawing.Size(120, 26);
            this.SelectProgramer.TabIndex = 10;
            this.SelectProgramer.Text = "Select Programer";
            this.SelectProgramer.UseVisualStyleBackColor = true;
            this.SelectProgramer.Visible = false;
            // 
            // LogView_btn
            // 
            this.LogView_btn.Location = new System.Drawing.Point(294, 176);
            this.LogView_btn.Name = "LogView_btn";
            this.LogView_btn.Size = new System.Drawing.Size(120, 26);
            this.LogView_btn.TabIndex = 11;
            this.LogView_btn.Text = "Log View";
            this.LogView_btn.UseVisualStyleBackColor = true;
            this.LogView_btn.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 295);
            this.Controls.Add(this.LogView_btn);
            this.Controls.Add(this.SelectProgramer);
            this.Controls.Add(this.LocalSetting);
            this.Controls.Add(this.MachineManager_btn);
            this.Controls.Add(this.ProjectManager_btn);
            this.Controls.Add(this.UserManager_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.UserName_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UserManager_btn;
        private System.Windows.Forms.Button ProjectManager_btn;
        private System.Windows.Forms.Button MachineManager_btn;
        private System.Windows.Forms.Button LocalSetting;
        private System.Windows.Forms.Button SelectProgramer;
        private System.Windows.Forms.Button LogView_btn;
    }
}