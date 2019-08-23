//#define HOME
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;
using Microsoft.Win32;


namespace File_Encryption
{
    public partial class Form1 : Form
    {
        public void DeleteRegedit()
        {
            RegistryKey reg;
            reg = Registry.ClassesRoot;
            reg.DeleteSubKeyTree(@"*\shell\File_Encryption",false);
            reg.DeleteSubKeyTree(@"*\shell\File_Decryption",false);
            reg.Close();
        }
        public void CreateRegedit()
        {
            RegistryKey reg;
            reg = Registry.ClassesRoot;
            reg = reg.CreateSubKey(@"*\shell\File_Encryption");
            //创建新项myApp
            reg.SetValue("", "使用 " + name + " 快速加密");
            //设置项值
            reg = Registry.ClassesRoot;
            reg=reg.CreateSubKey(@"*\shell\File_Encryption\command");
            //创建新项command
            reg.SetValue("", Application.ExecutablePath + " 1 \"%1\"");
            //设置command的值
            reg.Close();
            reg = Registry.ClassesRoot;
            reg = reg.CreateSubKey(@"*\shell\File_Decryption");
            //创建新项myApp
            reg.SetValue("", "使用 "+name+" 快速解密");
            //设置项值
            reg = Registry.ClassesRoot;
            reg = reg.CreateSubKey(@"*\shell\File_Decryption\command");
            //创建新项command
            reg.SetValue("", Application.ExecutablePath + " 2 \"%1\"");
            //设置command的值
            reg.Close();
        }
        public static string GetNetworkAdpaterID()
        {
            try
            {
                string mac = "";
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        mac += mo["MacAddress"].ToString() + " ";
                        break;
                    }
                moc = null;
                mc = null;
                return mac.Trim();
            }
            catch (Exception e)
            {
                return "uMnIk";
            }
        }
        public static int getkey(string s)
        {
            //int key=0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    key += s[i];
            //}
            //key %= 256;
            return (s.GetHashCode()+5)%256;
        }
        public Form1()
        {

            InitializeComponent();
            path = "";
            status = true;
            QuickDo =false;
            name = "教皇文件加密器";
            Text = name;
#if HOME
            Text += "（家庭内部版）";
#endif
        }
        public string name;
        private bool status;//true为加密 false为解密
        private string path;
        EncryptionList encryptionlist = new EncryptionList();
        private bool QuickDo;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "文件(*.*)|*.*";
            string path;
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                path = openDlg.FileName;
                if (File.Exists(path))
                {
                    FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
                    using (BinaryReader binReader = new BinaryReader(file, new ASCIIEncoding()))
                    {
                        int count = (int)file.Length;
                        Byte[] data = binReader.ReadBytes(count);
                        binReader.Close();
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            encryptionlist.InsertEncryption(new SpecialEnCryption(20190616));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "文件(*.*)|*.*";
            string path;
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                path = openDlg.FileName;
                if (File.Exists(path))
                {
                    TextB_OpenPath.Text = path;
                    TextBdestinationPath.Text = "";
                    UpdateDestinationPathName();
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderD = new FolderBrowserDialog();
            if (folderD.ShowDialog() == DialogResult.OK)
            {
                string s = folderD.SelectedPath;
                string s1 = TextB_OpenPath.Text;
                if (s1.Length != 0)
                {
                    int a = s1.LastIndexOf('\\');
                    s1 = s1.Substring(a);
                    a = s1.LastIndexOf('.');
                    if (RadioBencryption.Checked)
                        s1 = s1.Insert(a, "(加密后)");
                    else
                        s1 = s1.Insert(a, "(已解密)");
                    TextBdestinationPath.Text = s1;
                    s += s1;
                }
                TextBdestinationPath.Text = s;
                UpdateDestinationPathName();
            }
        }

        private void ToolStripMenuItemNewEn_Click(object sender, EventArgs e)
        {
            EncryptionForm form = new EncryptionForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                switch (form.comboBox1.SelectedIndex)
                {
                    case 0:
                        encryptionlist.InsertEncryption(new KaisaEnCryption(Convert.ToInt32(form.a)));
                        break;
                    case 1:
                        encryptionlist.InsertEncryption(new WeiyiEnCryption(form.b));
                        break;
                    case 2:
                        encryptionlist.InsertEncryption(new FenceEnCryption(form.c));
                        break;
                    case 3:
                        encryptionlist.InsertEncryption(new ReverseEnCryption());
                        break;
                }

            }
        }


        private void listBox1_Leave(object sender, EventArgs e)
        {
            listBox1.Focus();
        }

        private void ToolStripMenuDel_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                encryptionlist.RemoveEncryption(listBox1.SelectedIndex);
            }
        }

        private void ToolStripMenuItemIns_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            int index = listBox1.SelectedIndex;
            EncryptionForm form = new EncryptionForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                switch (form.comboBox1.SelectedIndex)
                {
                    case 0:
                        encryptionlist.InsertEncryption(index, new KaisaEnCryption(Convert.ToInt32(form.a)));
                        break;
                    case 1:
                        encryptionlist.InsertEncryption(index, new WeiyiEnCryption(form.b));
                        break;
                    case 2:
                        encryptionlist.InsertEncryption(index, new FenceEnCryption(form.c));
                        break;
                    case 3:
                        encryptionlist.InsertEncryption(index, new ReverseEnCryption());
                        break;
                }
            }
            listBox1.SelectedIndex = index;
        }

        private void ToolStripMenuItemUp_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index > 0)
            {
                encryptionlist.swap(index, index - 1);
                listBox1.SelectedIndex -= 1;
            }
        }

        private void ToolStripMenuItemDown_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
            if (index == listBox1.Items.Count - 1) return;
            encryptionlist.swap(index, index + 1);
            listBox1.SelectedIndex += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = encryptionlist.EnList;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Type";
            RegistryKey reg;
            reg = Registry.ClassesRoot;
            reg=reg.OpenSubKey(@"*\shell\File_Encryption");
                if (reg== null)
                {
                    ToolStripMenuItemEnableQuick.Text = "启用快速加密功能（推荐）";
                    QuickDo = false;
                }
                else
                {
                    ToolStripMenuItemEnableQuick.Text = "关闭快速加密功能";
                    QuickDo = true;
                }
        }

        private void RadioBencryption_CheckedChanged(object sender, EventArgs e)
        {
            status = RadioBencryption.Checked;
            if (status)
            {
                BtnDo.Text = "加密";
            }
            else
            {
                BtnDo.Text = "解密";
            }
            UpdateDestinationPathName();
        }
        private void UpdateDestinationPathName()
        {
            if (ToolStripMenuItemOverride.Checked) return;
            string path;
            string fileName;
            string s = TextBdestinationPath.Text;
            string s1 = TextB_OpenPath.Text;
            if (s1.Length != 0)
            {
                int a = s1.LastIndexOf('\\');
                int b = s.LastIndexOf('\\');
                if (b == -1)
                {
                    path = s1.Substring(0, a);
                }
                else
                {
                    path = s.Substring(0, b);
                }
                fileName = s1.Substring(a);
                a = fileName.LastIndexOf('.');
                if (a == -1)
                {
                    a = fileName.Length;
                }
                if (RadioBencryption.Checked)
                    fileName = fileName.Insert(a, "(加密后)");
                else
                {
                    if (a >= 5 && fileName.Substring(a - 5, 5).Equals("(加密后)"))
                    {
                        fileName = fileName.Remove(a - 5, 5).Insert(a - 5, "(已解密)");
                    }
                    else
                    {
                        fileName = fileName.Insert(a, "(已解密)");
                    }
                }
                TextBdestinationPath.Text = path + fileName;
            }
            else
            {
                TextBdestinationPath.Text = "";
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "教皇密钥文件(*.enc)|*.enc";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                encryptionlist.openEncryption(openDlg.FileName);
                listBox1.DataSource = encryptionlist.EnList;
                path = openDlg.FileName;
                int specialIndex = SpecialServiceContained();
                if (specialIndex != -1)
                {
                    if (encryptionlist.EnList[specialIndex].key1 == getDateInt())
                    {
                        MessageBox.Show("严小涵生日快乐！");
                        RadioBdecryption.Checked = true;
                    }
                    else
                    {
                        encryptionlist.EnList.RemoveAt(specialIndex);
                        MessageBox.Show("It is a boring " + DateTime.Today.DayOfWeek.ToString() + " today");
                    }
                }
            }
        }

        private void saveEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                SaveFileDialog sDlg = new SaveFileDialog();
                sDlg.Filter = "教皇密钥文件(*.enc)|*.enc";
                if (sDlg.ShowDialog() == DialogResult.OK)
                {
                    encryptionlist.saveEncryption(sDlg.FileName);
                    path = sDlg.FileName;
                }
            }
            else
            {
                encryptionlist.saveEncryption(path);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sDlg = new SaveFileDialog();
            sDlg.Filter = "教皇密钥文件(*.enc)|*.enc";
            if (sDlg.ShowDialog() == DialogResult.OK)
            {
                encryptionlist.saveEncryption(sDlg.FileName);
                path = sDlg.FileName;
            }
        }
        public static void Getdata(string path, out Byte[] data)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (BinaryReader binReader = new BinaryReader(file, new ASCIIEncoding()))
            {
                int count = (int)file.Length;
                data = binReader.ReadBytes(count);
                binReader.Close();
            }
        }
        public static bool SaveData(string path, Byte[] data)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(data);
                writer.Close();
            }
            return true;
        }
        private void BtnDo_Click(object sender, EventArgs e)
        {
            if (!(File.Exists(TextB_OpenPath.Text) && TextBdestinationPath.Text.Length != 0))
            {
                MessageBox.Show("请输入正确的文件名和目标地址");
                return;
            }
            if (encryptionlist.EnList.Count == 0&&!ToolStripMenuItemLocalEn .Checked )
            {
                MessageBox.Show("请读入或添加密钥");
                return;
            }
                if (!ToolStripMenuItemOverride.Checked&&File.Exists(TextBdestinationPath.Text) && MessageBox.Show("目标文件已存在\r\n是否覆盖?", "文件加密器", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            Byte[] data;
            Byte[] output;
            Byte[] temp;
            Getdata(TextB_OpenPath.Text, out data);
            KaisaEnCryption kaisaEn = new KaisaEnCryption(getkey(GetNetworkAdpaterID()));
            WeiyiEnCryption weiyi = new WeiyiEnCryption(1);
            if (SpecialServiceContained() != -1)
            {
                if (status)
                {
                    MessageBox.Show("I feel sorry. 这是一把只能解密的Key");
                    return;
                }
                InputBox inputDialog = new InputBox();
                inputDialog.Text = "";
                Int32 hash = 0;
                foreach (byte element in data) {
                    hash = (hash * 31) + element;
                }//哈希算法
                //MessageBox.Show(Convert.ToString(hash));
                Random rand = new Random();
                int errorNum = 401+ rand.Next(9);
                switch (hash)
                {
                    case -2105041395:
                        inputDialog.text.Text = "提示：2个字，当然啦也许并不需要这个提示hhh";

                        while (inputDialog.ShowDialog() != DialogResult.OK)
                        {
                        }
                        if (inputDialog.Input.Text.Equals("画沙"))
                        {
                            MessageBox.Show("看来记性不错嘛~");
                            while (MessageBox.Show("不过我还有一个请求，看完以后保证不要打我哟", "Last Request", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                            {
                            }
                            MessageBox.Show("好啦好啦给你看~");
                            break;
                        }
                        else
                        {
                            MessageBox.Show(Convert.ToString(errorNum) + " not found");
                            return;
                        }
                    case 1946476662:
                    case 2051085142:
                        inputDialog.text.Text = "有答案了嘛？";
                        while (inputDialog.ShowDialog() != DialogResult.OK) ;
                        if (inputDialog.Input.Text.Equals("2011"))
                        {
                            MessageBox.Show("WooooooW~~\n\r恭喜获得一张钓鲑鱼通行证");
                            break;
                        }
                        else
                        {
                            MessageBox.Show(Convert.ToString(errorNum) + " not found");
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("hhhhh这就是个普通文件嘛 emmm罢工咯~~");
                        return;
                }
            }
            if (status)
            {
#if HOME
                weiyi.encrypt(data, out temp);
                data = temp;
#endif
                if (ToolStripMenuItemLocalEn.Checked)
                {
                    kaisaEn.encrypt(data, out temp);
                    data = temp;
                }
                encryptionlist.encrypt(data, out output);
            }
            else
            {
                encryptionlist.decrypt(data, out output);
                if (ToolStripMenuItemLocalEn.Checked)
                {
                    kaisaEn.decrypt(output, out temp);
                    output = temp;
                }
#if HOME
                weiyi.decrypt(output, out temp);
                output = temp;
#endif
            }
            SaveData(TextBdestinationPath.Text, output);
            if(status)
            {
                if (MessageBox.Show("加密成功!\r\n是否保存该密钥", "文件加密器", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    SaveFileDialog sDlg = new SaveFileDialog();
                    sDlg.Filter = "觉皇密钥文件(*.enc)|*.enc";
                    string s = TextB_OpenPath.Text;
                    int a = s.LastIndexOf('.');
                    s = s.Substring(0, a);
                    a = s.LastIndexOf('\\');
                    s = s.Substring(a + 1);
                    sDlg.FileName = s;
                    if (sDlg.ShowDialog() == DialogResult.OK)
                    {
                        encryptionlist.saveEncryption(sDlg.FileName);
                    }
                } 
            }
            else
            {
                MessageBox.Show("解密成功");
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //第一版日期 2015.1.20
            MessageBox.Show("教皇文件加密器2.2.2  \n\n© 2015-2019 \n教皇黑科技工作室 \nBlack-Tech Studio of Sleeping Pope", "关于");
        }

        private void ToolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            encryptionlist.ClearEncryption();
        }

        private void newEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("请问是否保存原来的密钥", "文件加密器", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    SaveFileDialog sDlg = new SaveFileDialog();
                    sDlg.Filter = "教皇密钥文件(*.enc)|*.enc";
                    if (sDlg.ShowDialog() == DialogResult.OK)
                    {
                        encryptionlist.saveEncryption(sDlg.FileName);
                    }
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    return;
            }
            encryptionlist.init();
            path = "";
        }

        private void ToolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0) return;
            EncryptionForm form = new EncryptionForm();
            form.comboBox1.SelectedIndex = encryptionlist.EnList[listBox1.SelectedIndex].index;
            form.textBox1 .Text  = encryptionlist.EnList[listBox1.SelectedIndex].getkeyString ();
            if (form.ShowDialog() == DialogResult.OK)
            {
                switch (form.comboBox1.SelectedIndex)
                {
                    case 0:
                        encryptionlist.ReplaceEncryption(index, new KaisaEnCryption(Convert.ToInt32(form.a)));
                        break;
                    case 1:
                        encryptionlist.ReplaceEncryption(index, new WeiyiEnCryption(form.b));
                        break;
                    case 2:
                        encryptionlist.ReplaceEncryption(index, new FenceEnCryption(form.c));
                        break;
                    case 3:
                        encryptionlist.ReplaceEncryption(index, new ReverseEnCryption());
                        break;
                }
            }
        }

        private void ToolStripMenuItemOverride_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemOverride.Checked = !ToolStripMenuItemOverride.Checked;
            TextBdestinationPath.ReadOnly  = ToolStripMenuItemOverride.Checked;
            BtnFolderBrowse .Enabled = !ToolStripMenuItemOverride.Checked;
            if (ToolStripMenuItemOverride.Checked)
                TextBdestinationPath.Text = TextB_OpenPath.Text;
        }

        private void TextB_OpenPath_TextChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemOverride.Checked)
                TextBdestinationPath.Text = TextB_OpenPath.Text;
        }

        private void TextBdestinationPath_TextChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemOverride.Checked)
                TextBdestinationPath.Text = TextB_OpenPath.Text;
        }

        private void ToolStripMenuItemLocalEn_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemLocalEn.Checked = !ToolStripMenuItemLocalEn.Checked;
        }

        private void ToolStripMenuItemEnableQuick_Click(object sender, EventArgs e)
        {
            if (!QuickDo)
            {
                try
                {
                    CreateRegedit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("建议使用管理员权限运行本程序再试一次\r\n\r\n"+ex.ToString());
                    return;
                }
                MessageBox.Show("开启快速加密/解密功能 已成功！\r\n现可在右键菜单直接使用该功能");
                ToolStripMenuItemEnableQuick.Text = "关闭快速加密功能";
                QuickDo = true;
            }
            else
            {
                try
                {
                    DeleteRegedit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("建议使用管理员权限运行本程序再试一次\r\n\r\n" + ex.ToString());
                    return;
                }
                MessageBox.Show("已关闭快速加密/解密功能");
                ToolStripMenuItemEnableQuick.Text = "启用快速加密功能（推荐）";
                QuickDo = false;
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show (@"本程序可加密任何文件，无视拓展名加密（即可加密txt、exe、dll甚至无拓展名的文件）

本程序提供2种功能：

1.快速加密（适合普通文件加密）

使用方法：
	
	打开程序后，点""功能""—""启用快速加密功能""，即开启该功能

	选中任意文件，单击右键，点击""使用文件加密器 快速加密/解密""（不需要打开程序）

注意事项：
	1.本加密程序路径改变后，需重新启用该功能才能正常使用
	2.快速加密后，只能在本机解密(如在另一台计算机上使用本程序解密将无法成功）

2.使用密钥加密（适合高大上文件、传输文件加密）

使用方法：

	1.首先创建（或读取）一个密钥文件
	2.读取要加密/解密的文件
	3.选择加密/解密后的文件位置（默认与原文件位置相同）或选择""覆盖原文件""
	4.点击加密/解密

注意事项：
	1.若同时勾选""使用本机码加密""，则只能在本机解密（即使文件和密钥被盗走也不会泄密）
	2.请妥善保管（或记住）密钥文件
    3.密钥由多个密钥行组成，目前提供4种基础的密钥行", "帮助");

        }
        private int SpecialServiceContained()
        {
            for (int i = 0; i < encryptionlist.EnList.Count; i++)
            {
                if (encryptionlist.EnList[i].index == 4)
                {
                    return i;
                }
            }
            return -1;
        }
        private int getDateInt()
        {
            DateTime today = DateTime.Today;
            return today.Year * 10000 + today.Month * 100 + today.Day;
        }
    }
}
