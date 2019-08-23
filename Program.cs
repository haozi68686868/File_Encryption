using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Encryption
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                try
                {
                    string path = args[1];
                    Byte[] data;
                    Form1.Getdata(path, out data);
                    Byte[] output;
                    KaisaEnCryption kaisaEn = new KaisaEnCryption(Form1.getkey(Form1.GetNetworkAdpaterID()));
                    switch (Convert.ToInt32(args[0]))
                    {
                        case 1:
                            kaisaEn.encrypt(data, out output);
                            Form1.SaveData(path, output);
                            MessageBox.Show("快速加密成功!");
                            break;
                        case 2:
                            kaisaEn.decrypt(data, out output);
                            Form1.SaveData(path, output);
                            MessageBox.Show("快速解密成功!");
                            break;
                        default:
                            output = data;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
