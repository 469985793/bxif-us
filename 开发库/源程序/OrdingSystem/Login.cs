using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdingSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        void LoginError()
        {
            DialogResult MsgBoxResult;//设置对话框的返回值
            MsgBoxResult = MessageBox.Show("您输入的帐号或密码错误！",//对话框的显示内容 
            "提示信息",//对话框的标题 
            MessageBoxButtons.OK,//定义对话框的按钮，这里定义了YSE和NO两个按钮 
            MessageBoxIcon.Exclamation,//定义对话框内的图表式样，这里是一个黄色三角型内加一个感叹号 
            MessageBoxDefaultButton.Button2);//定义对话框的按钮式样
            if (MsgBoxResult == DialogResult.OK)//如果对话框的返回值是YES（按"Y"按钮）
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String UN = textBox1.Text;
            String PW = textBox2.Text;
            if (UN == "qiantai")
            {
                if (PW == "123")
                {
                    Front front = new Front();
                    front.ShowDialog();
                }

                else {}
            }
            else if (UN == "jingli")
            {
                if (PW == "123")
                {
                    Manage manage = new Manage();
                    manage.ShowDialog();
                }
                else { }
            }
            else if (UN == "chufang")
            {
                if (PW == "123")
                {
                    Kichen kichen = new Kichen();
                    kichen.ShowDialog();
                }
                else { }

            }
            else {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}


