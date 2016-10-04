namespace 文件夹加锁工具精美版
{
    partial class SetMainPwd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetMainPwd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtCheckPw = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.linkLabelWhy = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "再次输入";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(73, 21);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(265, 21);
            this.txtPasswd.TabIndex = 2;
            // 
            // txtCheckPw
            // 
            this.txtCheckPw.Location = new System.Drawing.Point(73, 59);
            this.txtCheckPw.Name = "txtCheckPw";
            this.txtCheckPw.PasswordChar = '*';
            this.txtCheckPw.Size = new System.Drawing.Size(265, 21);
            this.txtCheckPw.TabIndex = 3;
            this.txtCheckPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckPw_KeyDown);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(263, 86);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "完成";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // linkLabelWhy
            // 
            this.linkLabelWhy.AutoSize = true;
            this.linkLabelWhy.Location = new System.Drawing.Point(132, 92);
            this.linkLabelWhy.Name = "linkLabelWhy";
            this.linkLabelWhy.Size = new System.Drawing.Size(125, 12);
            this.linkLabelWhy.TabIndex = 5;
            this.linkLabelWhy.TabStop = true;
            this.linkLabelWhy.Text = "为什么要使用初始密码";
            this.linkLabelWhy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWhy_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "当你忘记为文件夹单独设置的密码时，可使用初始密码解锁！");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "使用初始密码一方面可以帮你您解锁忘记密码的文件夹，另一方面\r\n可以快速加锁您的文件夹而不需要输入单独的密码";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // SetMainPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 168);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelWhy);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtCheckPw);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetMainPwd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置初始密码";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetMainPwd_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtCheckPw;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.LinkLabel linkLabelWhy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}