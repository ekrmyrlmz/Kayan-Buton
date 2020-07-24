//* Ekrem YORULMAZ 
//  ekrm.yorulmaz@gmail.com


using System;
using System.Drawing;
using System.Windows.Forms;


namespace Mouse_Uzerine_Gelince_Kayan_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public int i = 1;

        private void Txbisimgir_TextChanged(object sender, EventArgs e)
        {
            Lblisimcikti.Text = Txbisimgir.Text + " Sıkıysa beni yakala";
        }

        private void Btnyakala_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            Btnyakala.Left = Convert.ToInt32(rnd.Next(Size.Width - Btnyakala.Size.Width));
            Btnyakala.Top = Convert.ToInt32(rnd.Next(Size.Height - Btnyakala.Size.Height));
        }

        private void Btnyakala_Click(object sender, EventArgs e)
        {
            LblAnlikpuan.Text = "Tebrikler Toplam Puanınız " + Convert.ToString(i);

            if (i <= 20)
            {
                i++;
            }
            else if (i > 20)
            {
                Lblisimcikti.Text = "Oyun Bitti.";
            }
        }


    }
}
