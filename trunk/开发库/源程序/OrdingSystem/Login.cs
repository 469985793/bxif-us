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
            DialogResult MsgBoxResult;//���öԻ���ķ���ֵ
            MsgBoxResult = MessageBox.Show("��������ʺŻ��������",//�Ի������ʾ���� 
            "��ʾ��Ϣ",//�Ի���ı��� 
            MessageBoxButtons.OK,//����Ի���İ�ť�����ﶨ����YSE��NO������ť 
            MessageBoxIcon.Exclamation,//����Ի����ڵ�ͼ��ʽ����������һ����ɫ�������ڼ�һ����̾�� 
            MessageBoxDefaultButton.Button2);//����Ի���İ�ťʽ��
            if (MsgBoxResult == DialogResult.OK)//����Ի���ķ���ֵ��YES����"Y"��ť��
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


