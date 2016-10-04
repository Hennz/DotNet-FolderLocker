namespace 文件夹加锁工具精美版
{
    partial class UnLockFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnLockFolder));
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnLock = new System.Windows.Forms.Button();
            this.txtUnLock = new System.Windows.Forms.TextBox();
            this.picUnLock = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUnLock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入解锁密码：";
            // 
            // btnUnLock
            // 
            this.btnUnLock.Location = new System.Drawing.Point(291, 29);
            this.btnUnLock.Name = "btnUnLock";
            this.btnUnLock.Size = new System.Drawing.Size(75, 21);
            this.btnUnLock.TabIndex = 2;
            this.btnUnLock.Text = "解锁";
            this.btnUnLock.UseVisualStyleBackColor = true;
            this.btnUnLock.Click += new System.EventHandler(this.btnUnLock_Click);
            // 
            // txtUnLock
            // 
            this.txtUnLock.Location = new System.Drawing.Point(15, 28);
            this.txtUnLock.Name = "txtUnLock";
            this.txtUnLock.PasswordChar = '*';
            this.txtUnLock.Size = new System.Drawing.Size(270, 21);
            this.txtUnLock.TabIndex = 7;
            this.txtUnLock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnLock_KeyDown);
            // 
            // picUnLock
            // 
            this.picUnLock.Image = ((System.Drawing.Image)(resources.GetObject("picUnLock.Image")));
            this.picUnLock.Location = new System.Drawing.Point(129, 3);
            this.picUnLock.Name = "picUnLock";
            this.picUnLock.Size = new System.Drawing.Size(92, 86);
            this.picUnLock.TabIndex = 8;
            this.picUnLock.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(228, 33);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "忘记密码";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(291, 60);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 10;
            this.btnDone.Text = "退出";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "★您可以使用初始密码解锁";
            // 
            // UnLockFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 118);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.picUnLock);
            this.Controls.Add(this.txtUnLock);
            this.Controls.Add(this.btnUnLock);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnLockFolder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件夹解锁";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picUnLock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnLock;
        private System.Windows.Forms.TextBox txtUnLock;
        private System.Windows.Forms.PictureBox picUnLock;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label2;
    }
}