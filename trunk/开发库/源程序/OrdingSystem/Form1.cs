using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdingSystem
{
    public partial class OrdingSystem : Form
    {
        public OrdingSystem()
        {
            InitializeComponent();
        }
//�û������ͽ���
        private void Ording_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
//����������Ա��½����ϵͳ
        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}