namespace OrdingSystem
{
    partial class OrdingSystem
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
            this.Ording = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ording
            // 
            this.Ording.Location = new System.Drawing.Point(47, 36);
            this.Ording.Name = "Ording";
            this.Ording.Size = new System.Drawing.Size(75, 23);
            this.Ording.TabIndex = 0;
            this.Ording.Text = "点餐";
            this.Ording.UseVisualStyleBackColor = true;
            this.Ording.Click += new System.EventHandler(this.Ording_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(47, 104);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 1;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // OrdingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Ording);
            this.Name = "OrdingSystem";
            this.Text = "美味点餐系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ording;
        private System.Windows.Forms.Button Login;
    }
}

