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
//用户进入点餐界面
        private void Ording_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
//餐厅工作人员登陆进入系统
        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}