﻿namespace AutoProgramer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Test_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Test_btn
            // 
            this.Test_btn.Location = new System.Drawing.Point(553, 203);
            this.Test_btn.Name = "Test_btn";
            this.Test_btn.Size = new System.Drawing.Size(75, 23);
            this.Test_btn.TabIndex = 0;
            this.Test_btn.Text = "Test";
            this.Test_btn.UseVisualStyleBackColor = true;
            this.Test_btn.Click += new System.EventHandler(this.Test_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Test_btn);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Test_btn;
        private System.Windows.Forms.Button button1;
    }
}

