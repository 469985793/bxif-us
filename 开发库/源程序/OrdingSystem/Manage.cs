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
            //��Ҫ�ٴ�ȷ��
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
//ɾ����¼
        private void DeleteRecords_Click(object sender, EventArgs e)
        {
            //���ٴ�ȷ��
        }
//�������ݿ�
        private void Backup_Click(object sender, EventArgs e)
        {

        }
//�鿴��Ʒ
        private void ViewDishes_Click(object sender, EventArgs e)
        {

        }
//�༭��Ʒ
        private void DishEdit_Click(object sender, EventArgs e)
        {
            DishEdit dishedit = new DishEdit();
            dishedit.ShowDialog();
        }
//������Ʒ
        private void NewDishes_Click(object sender, EventArgs e)
        {
            DishEdit dishedit = new DishEdit();
            dishedit.ShowDialog();
        }
//ɾ����Ʒ
        private void RemoveDishes_Click(object sender, EventArgs e)
        {

        }
    }
}