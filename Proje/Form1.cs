using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private bool isPrime(int x)
        {
            if (x < 3)
                return false;
            for (int i = x - 1; i > 1; i--)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        private int findPrime(int x = 1)
        {
            int myPrime = 2;
            while (!isPrime(myPrime) || myPrime > 100)
            {
                Random rnd = new Random();
                myPrime = rnd.Next(100);
                if (myPrime == x)
                    myPrime = 2;
            }
            return myPrime;
        }


        private int findQ_n(int first, int sec)
        {
            return (first - 1) * (sec - 1);
        }

        private int findN(int first, int sec)
        {
            return (first) * (sec);
        }

        private bool Coprime(int first, int sec)
        {
            int mlen = 0;
            if (first < sec)
                mlen = first;
            else
                mlen = sec;

            for (int i = 2; i < mlen; i++)
            {
                if (first % i == 0 && sec % i == 0)
                    return false;
            }
            return true;
        }

        private int findEncKey(int Q_n)
        {
            int mKey = 2;
            while (true)
            {
                Random rnd = new Random();
                mKey = (rnd.Next(Q_n -2) ) + 2;
                if (Coprime(mKey, Q_n))
                    break;
            }
            return mKey;
        }

        private int findD(int EncKey, int Q_n)
        {
            for (int d = 1; true; d++)
            {
                if ((d * EncKey) % Q_n == 1)
                    return d;
            }
        }

        private int c_dmodn(int c, int d, int n)      // work out c^d mod n
        {
            int value = 1;
            while (d > 0)
            {
                value *= c;
                value %= n;
                d--;
            }
            return value;
        }

        private int crypteWord(int m, int mKey, int myN)
        {
            return c_dmodn(m, mKey, myN);
        }

        private int EncrypteWord(int c, int myD, int myN)
        {
            return c_dmodn(c, myD, myN);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pureText.Text == "" )
            {
                MessageBox.Show("Please enter the Text");
            }
            else if(Asal1txt.Text==""  || Asal2txt.Text=="")
            {
                MessageBox.Show("Please enter Prime numbers");
            }
            else
            {
                int first = Convert.ToInt32(Asal1txt.Text);
                int sec = Convert.ToInt32(Asal2txt.Text);
                int Q_n = findQ_n(first, sec);
                int myN = findN(first, sec);
                int mKey = findEncKey(Q_n);
                int myD = findD(mKey, Q_n);
                int[] crypted = new int[150];
                int[] encrypted = new int[150];
                int mlen = 0, x, sifre, cozum;
                string mWord = pureText.Text;

                encryptedtxt.Text = "";
                cryptedtxt.Text = "";

                elbl.Visible = true;
                dlbl.Visible = true;
                elbl.Text = "e: " + mKey.ToString();
                dlbl.Text = "d: " + myD.ToString();

                for (int i = 0; i < mWord.Length; i++)
                {
                    x = (int)mWord[i];
                    sifre = crypteWord(x, mKey, myN);
                    cozum = EncrypteWord(sifre, myD, myN);
                    crypted[i] = sifre;
                    encrypted[i] = cozum;
                    mlen = i + 1;
                }
                for (int i = 0; i < mlen; i++)
                {
                    cryptedtxt.AppendText(((char)crypted[i]).ToString());
                }
                for (int i = 0; i < mlen; i++)
                {
                    encryptedtxt.AppendText(((char)encrypted[i]).ToString());
                }
            }


        }
        private void KeyCheck(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Asal1txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyCheck(sender, e);
        }

        private void Asal2txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyCheck(sender, e);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            int a, b;
            a = findPrime();
            b = findPrime(a);
            Asal1txt.Text = Convert.ToString(a);
            Asal2txt.Text = Convert.ToString(b);
        }
    }
}
