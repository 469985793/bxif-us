﻿namespace OrdingSystem
{
    partial class Kichen
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
            this.button3 = new System.Windows.Forms.Button();
            this.MenuConfirmation = new System.Windows.Forms.Button();
            this.ViewMenu = new System.Windows.Forms.Button();
            this.OrderList = new System.Windows.Forms.ListBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.MenuConfirmation);
            this.splitContainer1.Panel1.Controls.Add(this.ViewMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.OrderList);
            this.splitContainer1.Size = new System.Drawing.Size(292, 273);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MenuConfirmation
            // 
            this.MenuConfirmation.Location = new System.Drawing.Point(8, 104);
            this.MenuConfirmation.Name = "MenuConfirmation";
            this.MenuConfirmation.Size = new System.Drawing.Size(75, 23);
            this.MenuConfirmation.TabIndex = 1;
            this.MenuConfirmation.Text = "处理订单";
            this.MenuConfirmation.UseVisualStyleBackColor = true;
            this.MenuConfirmation.Click += new System.EventHandler(this.MenuConfirmation_Click);
            // 
            // ViewMenu
            // 
            this.ViewMenu.Location = new System.Drawing.Point(8, 34);
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(75, 23);
            this.ViewMenu.TabIndex = 0;
            this.ViewMenu.Text = "查看订单";
            this.ViewMenu.UseVisualStyleBackColor = true;
            this.ViewMenu.Click += new System.EventHandler(this.ViewMenu_Click);
            // 
            // OrderList
            // 
            this.OrderList.FormattingEnabled = true;
            this.OrderList.ItemHeight = 12;
            this.OrderList.Location = new System.Drawing.Point(4, 4);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(184, 268);
            this.OrderList.TabIndex = 0;
            // 
            // Kichen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Kichen";
            this.Text = "Kichen";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button MenuConfirmation;
        private System.Windows.Forms.Button ViewMenu;
        private System.Windows.Forms.ListBox OrderList;
        private System.Windows.Forms.Button button3;
    }
}