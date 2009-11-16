namespace OrdingSystem
{
    partial class Manage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.NewDishes = new System.Windows.Forms.Button();
            this.RemoveDishes = new System.Windows.Forms.Button();
            this.ViewDishes = new System.Windows.Forms.Button();
            this.DishEdit = new System.Windows.Forms.Button();
            this.DeleteRecords = new System.Windows.Forms.Button();
            this.Backup = new System.Windows.Forms.Button();
            this.ViewReport = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button10);
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.NewDishes);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveDishes);
            this.splitContainer1.Panel1.Controls.Add(this.ViewDishes);
            this.splitContainer1.Panel1.Controls.Add(this.DishEdit);
            this.splitContainer1.Panel1.Controls.Add(this.DeleteRecords);
            this.splitContainer1.Panel1.Controls.Add(this.Backup);
            this.splitContainer1.Panel1.Controls.Add(this.ViewReport);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button9);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(383, 316);
            this.splitContainer1.SplitterDistance = 127;
            this.splitContainer1.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(13, 290);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 8;
            this.button10.Text = "退出";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(13, 157);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "职工信息管理";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // NewDishes
            // 
            this.NewDishes.Location = new System.Drawing.Point(13, 80);
            this.NewDishes.Name = "NewDishes";
            this.NewDishes.Size = new System.Drawing.Size(75, 23);
            this.NewDishes.TabIndex = 6;
            this.NewDishes.Text = "新增菜品";
            this.NewDishes.UseVisualStyleBackColor = true;
            this.NewDishes.Click += new System.EventHandler(this.NewDishes_Click);
            // 
            // RemoveDishes
            // 
            this.RemoveDishes.Location = new System.Drawing.Point(12, 110);
            this.RemoveDishes.Name = "RemoveDishes";
            this.RemoveDishes.Size = new System.Drawing.Size(75, 23);
            this.RemoveDishes.TabIndex = 5;
            this.RemoveDishes.Text = "删除菜品";
            this.RemoveDishes.UseVisualStyleBackColor = true;
            this.RemoveDishes.Click += new System.EventHandler(this.RemoveDishes_Click);
            // 
            // ViewDishes
            // 
            this.ViewDishes.Location = new System.Drawing.Point(12, 12);
            this.ViewDishes.Name = "ViewDishes";
            this.ViewDishes.Size = new System.Drawing.Size(75, 23);
            this.ViewDishes.TabIndex = 4;
            this.ViewDishes.Text = "查看菜品";
            this.ViewDishes.UseVisualStyleBackColor = true;
            this.ViewDishes.Click += new System.EventHandler(this.ViewDishes_Click);
            // 
            // DishEdit
            // 
            this.DishEdit.Location = new System.Drawing.Point(12, 50);
            this.DishEdit.Name = "DishEdit";
            this.DishEdit.Size = new System.Drawing.Size(75, 23);
            this.DishEdit.TabIndex = 3;
            this.DishEdit.Text = "编辑菜品";
            this.DishEdit.UseVisualStyleBackColor = true;
            this.DishEdit.Click += new System.EventHandler(this.DishEdit_Click);
            // 
            // DeleteRecords
            // 
            this.DeleteRecords.Location = new System.Drawing.Point(13, 258);
            this.DeleteRecords.Name = "DeleteRecords";
            this.DeleteRecords.Size = new System.Drawing.Size(95, 25);
            this.DeleteRecords.TabIndex = 2;
            this.DeleteRecords.Text = "删除历史记录";
            this.DeleteRecords.UseVisualStyleBackColor = true;
            this.DeleteRecords.Click += new System.EventHandler(this.DeleteRecords_Click);
            // 
            // Backup
            // 
            this.Backup.Location = new System.Drawing.Point(13, 229);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(75, 23);
            this.Backup.TabIndex = 1;
            this.Backup.Text = "备份";
            this.Backup.UseVisualStyleBackColor = true;
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // ViewReport
            // 
            this.ViewReport.Location = new System.Drawing.Point(13, 200);
            this.ViewReport.Name = "ViewReport";
            this.ViewReport.Size = new System.Drawing.Size(75, 23);
            this.ViewReport.TabIndex = 0;
            this.ViewReport.Text = "查看报表";
            this.ViewReport.UseVisualStyleBackColor = true;
            this.ViewReport.Click += new System.EventHandler(this.ViewReport_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(136, 286);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 2;
            this.button9.Text = "查询菜品";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(7, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 280);
            this.listBox1.TabIndex = 0;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 316);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Manage";
            this.Text = "经理系统";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button DeleteRecords;
        private System.Windows.Forms.Button Backup;
        private System.Windows.Forms.Button ViewReport;
        private System.Windows.Forms.Button DishEdit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button NewDishes;
        private System.Windows.Forms.Button RemoveDishes;
        private System.Windows.Forms.Button ViewDishes;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button10;
    }
}