using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Encryption
{
    public partial class EncryptionForm : Form
    {
        public EncryptionForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("凯撒加密");
            comboBox1.Items.Add("位移加密");
            comboBox1.Items.Add("栅栏加密");
            comboBox1.Items.Add("倒序加密");
        }
        public char a;
        public int b;
        public int c;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        a = Convert.ToChar(textBox1.Text);
                        break;
                    case 1:
                        b = Convert.ToInt32 (textBox1.Text);
                        break;
                    case 2:
                        c = Convert.ToInt32(textBox1.Text);
                        if (c <= 0) throw new Exception("请输入一个正整数");
                        break;
                    case 3:
                        break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t\t请输入合适的密钥\r\n\r\n错误信息：\r\n"+ex.ToString());
                textBox1.SelectAll();
                textBox1.Focus();
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void EncryptionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox1.Enabled = true;
                    textBox1.Text = "请输入1个字符";
                    textBox1.SelectAll();
                    textBox1.Focus();
                    break;
                case 1:
                    textBox1.Enabled = true;
                    textBox1.Text = "请输入1个整数";
                    textBox1.SelectAll();
                    textBox1.Focus();
                    break;
                case 2:
                    textBox1.Enabled = true;
                    textBox1.Text = "请输入1个正整数";
                    textBox1.SelectAll();
                    textBox1.Focus();
                    break;
                case 3:
                    textBox1.Enabled = false;
                    textBox1.Text = "";
                    break;
            }
        }
    }
}
