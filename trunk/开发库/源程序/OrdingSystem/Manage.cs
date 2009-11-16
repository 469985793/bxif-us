using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdingSystem
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //需要再次确认
            EmployeeInformation EI = new EmployeeInformation();
            EI.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void ViewReport_Click(object sender, EventArgs e)
        {

        }
//删除记录
        private void DeleteRecords_Click(object sender, EventArgs e)
        {
            //需再次确认
        }
//备份数据库
        private void Backup_Click(object sender, EventArgs e)
        {

        }
//查看菜品
        private void ViewDishes_Click(object sender, EventArgs e)
        {

        }
//编辑菜品
        private void DishEdit_Click(object sender, EventArgs e)
        {
            DishEdit dishedit = new DishEdit();
            dishedit.ShowDialog();
        }
//新增菜品
        private void NewDishes_Click(object sender, EventArgs e)
        {
            DishEdit dishedit = new DishEdit();
            dishedit.ShowDialog();
        }
//删除菜品
        private void RemoveDishes_Click(object sender, EventArgs e)
        {

        }
    }
}