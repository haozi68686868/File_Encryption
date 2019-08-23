using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

namespace File_Encryption
{
    class EncryptionList
    {
        public BindingList<Encryption> EnList = new BindingList<Encryption>();
        public void InsertEncryption(int index, Encryption en)
        {
            EnList.Insert(index, en);
        }
        public void init()
        {
            EnList.Clear();
        }
        public void swap(int index1, int index2)
        {
            Encryption temp;
            temp = EnList[index1];
            EnList[index1] = EnList[index2];
            EnList[index2] = temp;
        }
        public void InsertEncryption(Encryption en)
        {
            EnList.Add(en);
        }
        public void RemoveEncryption(int index)
        {
            EnList.RemoveAt(index);
        }
        public void ReplaceEncryption(int index, Encryption en)
        {
            EnList[index] = en;
        }
        public void ClearEncryption()
        {
            EnList.Clear();
        }
        public void encrypt(byte[] input, out byte[] output)
        {
            output = input;
            foreach (Encryption en in EnList)
            {
                en.encrypt(input, out output);
                input = output;
            }
        }
        public void decrypt(byte[] input, out byte[] output)
        {
            int count = EnList.Count;
            output = input;
            for (int i = 0; i < count; i++)
            {
                EnList[count - i - 1].decrypt(input, out output);
                input = output;
            }
        }
        public bool openEncryption(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    BindingList<Encryption> tempList = new BindingList<Encryption>();
                    using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                    {
                        int temp, temp1;
                        while (true)
                        {
                            temp = reader.ReadInt32();
                            if (temp == -1) break;
                            temp1 = reader.ReadInt32();
                            switch (temp)
                            {
                                case 0:
                                    tempList.Add(new KaisaEnCryption(temp1));
                                    break;
                                case 1:
                                    tempList.Add(new WeiyiEnCryption(temp1));
                                    break;
                                case 2:
                                    tempList.Add(new FenceEnCryption(temp1));
                                    break;
                                case 3:
                                    tempList.Add(new ReverseEnCryption());
                                    break;
                                case 4:
                                    tempList.Add(new SpecialEnCryption(temp1));
                                    break;
                            }
                        }
                    }
                    EnList = tempList;
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return false;
        }
        public bool saveEncryption(string fileName)
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
                {
                    foreach (Encryption en in EnList)
                    {
                        writer.Write(en.index);
                        writer.Write(en.key1);
                    }
                    writer.Write(-1);
                    writer.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
    }
    abstract class Encryption
    {
        public string name;
        public abstract void encrypt(byte[] input,out byte[] output);
        public abstract void decrypt(byte[] input,out byte[] output);
        public string getString()
        {
            return name + ":\t" + getkeyString();
        }
        public abstract string getkeyString();
        public string Name
        {
            get
            {
                return getString();
            }
        }
        public int Type
        {
            get
            {
                return index;
            }
        }
        public int index;
        public int key1;
        public int key2;
        public int key3;
    }
    class KaisaEnCryption : Encryption//凯撒加密
    {
        public KaisaEnCryption(int key)
        {
            name = "凯撒加密";
            key1 = key;
            index = 0;
        }
        public override string getkeyString()
        {
            return Convert.ToChar(key1)+"";
        }
        public override void encrypt(byte[] input, out byte[] output)
        {
            int length=input .Length;
            output = new byte[length];
            for (int i = 0; i < length; i++)
            {
                output[i] = (byte)(((int)input[i]+key1 )%256);
            }
        }
        public override void decrypt(byte[] input, out byte[] output)
        {
            int length = input.Length;
            output = new byte[length];
            for (int i = 0; i < length; i++)
            {
                output[i] = (byte)(((int)input[i] - key1) % 256);
            }
        }
    }
    class WeiyiEnCryption : Encryption//位移加密
    {
        public WeiyiEnCryption(int key)
        {
            name = "位移加密";
            key1 = key;
            index = 1;
        }
        public override string getkeyString()
        {
            return Convert.ToString(key1);
        }
        public override void encrypt(byte[] input, out byte[] output)
        {
            int length = input.Length;
            output = new byte[length];
            for (int i = 0; i < length; i++)
            {
                output[i] = input[((i + key1) % length + length) % length];
            }
        }
        public override void decrypt(byte[] input, out byte[] output)
        {
            int length = input.Length;
            output = new byte[length];
            for (int i = 0; i < length; i++)
            {

                output[i] = input[((i - key1) % length+length )%length ];
            }
        }
    }
    class FenceEnCryption : Encryption//栅栏加密
    {
        public FenceEnCryption(int key)
        {
            name = "栅栏加密";
            key1 = key;
            index = 2;
        }
        public override string getkeyString()
        {
            return Convert.ToString(key1);
        }
        public FenceEnCryption()
        {
            name = "栅栏加密";
            key1 = 2;
            index = 2;
        }
        public override void encrypt(byte[] input, out byte[] output)
        {
            int length = input.Length;
            output = new byte[length];
            int times=length/key1;
            int i, j;
            for (i = 0; i < times;i++ )
            {
                for (j = 0; j < key1; j++)
                {
                    output[j * times + i] = input[key1 * i + j];
                }
            }
            for (i = key1 * times; i < length; i++)
            {
                output[i] = input[i];
            }
        }
        public override void decrypt(byte[] input, out byte[] output)
        {
            int length = input.Length;
            output = new byte[length];
            int times = length / key1;
            int i, j;
            for (i = 0; i < times; i++)
            {
                for (j = 0; j < key1; j++)
                {
                    output[key1 * i + j] = input[j * times + i];
                }
            }
            for (i = key1 * times; i < length; i++)
            {
                output[i] = input[i];
            }
        }
    }
    class ReverseEnCryption : Encryption//倒序加密
    {
        public ReverseEnCryption()
        {
            name = "倒序加密";
            index = 3;
            key1 = 0;
        }
        public override string getkeyString()
        {
            return "";
        }
        public override void encrypt(byte[] input, out byte[] output)
        {
            int length = input.Length;
            output = new byte[length];
            for (int i = 0; i < length; i++)
            {
                output[i] = input[length - i - 1];
            }
        }
        public override void decrypt(byte[] input, out byte[] output)
        {
            int length = input.Length;
            output = new byte[length];
            for (int i = 0; i < length; i++)
            {
                output[i] = input[length - i - 1];
            }
        }
    }

    class SpecialEnCryption : Encryption//倒序加密
    {
        public SpecialEnCryption(int key)
        {
            name = "Happy Birthday";
            index = 4;
            key1 = key;
        }
        public override string getkeyString()
        {
            return "";
        }
        public override void encrypt(byte[] input, out byte[] output)
        {
            new WeiyiEnCryption(key1 % 127).encrypt(input, out output);
        }
        public override void decrypt(byte[] input, out byte[] output)
        {
            new WeiyiEnCryption(key1 % 127).decrypt(input, out output);
        }
    }
}
