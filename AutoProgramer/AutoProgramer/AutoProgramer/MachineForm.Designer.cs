namespace AutoProgramer
{
    partial class MachineForm
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
            this.Machine_DataGridView = new System.Windows.Forms.DataGridView();
            this.MachineName_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DelMachine_btn = new System.Windows.Forms.Button();
            this.AddMachine_btn = new System.Windows.Forms.Button();
            this.Comment_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Machine_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Machine_DataGridView
            // 
            this.Machine_DataGridView.AllowUserToAddRows = false;
            this.Machine_DataGridView.AllowUserToDeleteRows = false;
            this.Machine_DataGridView.AllowUserToResizeColumns = false;
            this.Machine_DataGridView.AllowUserToResizeRows = false;
            this.Machine_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Machine_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Machine_DataGridView.Location = new System.Drawing.Point(1, 2);
            this.Machine_DataGridView.MultiSelect = false;
            this.Machine_DataGridView.Name = "Machine_DataGridView";
            this.Machine_DataGridView.ReadOnly = true;
            this.Machine_DataGridView.RowTemplate.Height = 23;
            this.Machine_DataGridView.Size = new System.Drawing.Size(453, 379);
            this.Machine_DataGridView.TabIndex = 2;
            this.Machine_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Machine_DataGridView_CellClick);
            // 
            // MachineName_txt
            // 
            this.MachineName_txt.Location = new System.Drawing.Point(112, 397);
            this.MachineName_txt.Name = "MachineName_txt";
            this.MachineName_txt.Size = new System.Drawing.Size(317, 21);
            this.MachineName_txt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Machine Name:";
            // 
            // DelMachine_btn
            // 
            this.DelMachine_btn.Location = new System.Drawing.Point(299, 460);
            this.DelMachine_btn.Name = "DelMachine_btn";
            this.DelMachine_btn.Size = new System.Drawing.Size(129, 23);
            this.DelMachine_btn.TabIndex = 25;
            this.DelMachine_btn.Text = "Delete Machine";
            this.DelMachine_btn.UseVisualStyleBackColor = true;
            this.DelMachine_btn.Click += new System.EventHandler(this.DelMachine_btn_Click);
            // 
            // AddMachine_btn
            // 
            this.AddMachine_btn.Location = new System.Drawing.Point(148, 460);
            this.AddMachine_btn.Name = "AddMachine_btn";
            this.AddMachine_btn.Size = new System.Drawing.Size(129, 23);
            this.AddMachine_btn.TabIndex = 24;
            this.AddMachine_btn.Text = "Add Machine";
            this.AddMachine_btn.UseVisualStyleBackColor = true;
            this.AddMachine_btn.Click += new System.EventHandler(this.AddMachine_btn_Click);
            // 
            // Comment_txt
            // 
            this.Comment_txt.Location = new System.Drawing.Point(112, 427);
            this.Comment_txt.Name = "Comment_txt";
            this.Comment_txt.Size = new System.Drawing.Size(317, 21);
            this.Comment_txt.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "Comment:";
            // 
            // MachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 494);
            this.Controls.Add(this.Comment_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DelMachine_btn);
            this.Controls.Add(this.AddMachine_btn);
            this.Controls.Add(this.MachineName_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Machine_DataGridView);
            this.Name = "MachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MachineForm";
            this.Load += new System.EventHandler(this.MachineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Machine_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Machine_DataGridView;
        private System.Windows.Forms.TextBox MachineName_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DelMachine_btn;
        private System.Windows.Forms.Button AddMachine_btn;
        private System.Windows.Forms.TextBox Comment_txt;
        private System.Windows.Forms.Label label2;
    }
}