namespace 文件夹加锁工具精美版
{
    partial class LockFolderPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockFolderPwd));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLock = new System.Windows.Forms.TextBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.picLock = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "加锁密码：";
            // 
            // txtLock
            // 
            this.txtLock.Location = new System.Drawing.Point(13, 29);
            this.txtLock.Name = "txtLock";
            this.txtLock.Size = new System.Drawing.Size(262, 21);
            this.txtLock.TabIndex = 1;
            this.txtLock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLock_KeyDown);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(291, 29);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 21);
            this.btnLock.TabIndex = 2;
            this.btnLock.Text = "加锁";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // picLock
            // 
            this.picLock.Image = ((System.Drawing.Image)(resources.GetObject("picLock.Image")));
            this.picLock.Location = new System.Drawing.Point(136, -1);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(92, 86);
            this.picLock.TabIndex = 3;
            this.picLock.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(291, 61);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LockFolderPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 93);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picLock);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.txtLock);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LockFolderPwd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件夹加锁";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLock;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.PictureBox picLock;
        private System.Windows.Forms.Button btnClose;
    }
}