using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSayiTahmini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int tahminSayi = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            if (textBox2.Text == textBox1.Text)
            {
                button3.Visible = false;
                label2.Text = "Tahmin->Doğru\nTahmin Sayısı= "+tahminSayi;
            }
            else { 
                label2.Text = "Tahmin->Yanlış";
                tahminSayi++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            label2.Text = "Tahmin->";
            textBox2.Text = "";
            tahminSayi = 1;
            Random rnd = new Random();
            int randomSayi;
            randomSayi = rnd.Next(1, 10);
            textBox1.Text = randomSayi.ToString();
            label4.Text = "Sayı oluşturuldu.";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rastgele Sayı butonuna tıkladıktan sonra aşağıda textbox kısmından tahmininizi yapın ve Sorgula botnuna tıklayın! Doğru cevabı bulduğunuzda kaç kere tahmin yaptığınızı görebilirsiniz!");
        }
    }
}
