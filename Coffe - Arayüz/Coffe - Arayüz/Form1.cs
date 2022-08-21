using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Coffe___Arayüz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cay = 0;
        int fiyat = 0;
        int turkkahvesi = 0;
        int fiyat1 = 0;
        int sutlukahve = 0;
        int fiyat2 = 0;
        int bitkicayi = 0;
        int fiyat3 = 0;


        int icellatte = 0;
        int fiyat4 = 0;
        int whitechocolate = 0;
        int fiyat5 = 0;
        int icemocha = 0;
        int fiyat6 = 0;
        int frappucino = 0;
        int fiyat7 = 0;


        SqlCommand baglanti = new SqlCommand(@"Data Source=SULU-BILGISAYAR;Initial Catalog=db.KahveDükkanı;Integrated Security=True");
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            cay++;
            fiyat = fiyat + 7;
            textBox1.Text = cay.ToString();
            textBox2.Text = fiyat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            turkkahvesi++;
            fiyat1 = fiyat1 + 15;
            textBox4.Text = turkkahvesi.ToString();
            textBox3.Text = fiyat1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sutlukahve++;
            fiyat2 = fiyat2 + 17;
            textBox6.Text = sutlukahve.ToString();
            textBox5.Text = fiyat2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           bitkicayi++;
            fiyat3 = fiyat3 + 12;
            textBox8.Text = bitkicayi.ToString();
            textBox7.Text = fiyat3.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cay--;
            fiyat = fiyat - 7;
            textBox1.Text = cay.ToString();
            textBox2.Text = fiyat.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            turkkahvesi--;
            fiyat1 = fiyat1 - 15;
            textBox4.Text = turkkahvesi.ToString();
            textBox3.Text = fiyat1.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sutlukahve--;
            fiyat2 = fiyat2 - 17;
            textBox6.Text = sutlukahve.ToString();
            textBox5.Text = fiyat2.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bitkicayi--;
            fiyat3 = fiyat3 - 12;
            textBox8.Text = bitkicayi.ToString();
            textBox7.Text = fiyat3.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            icellatte++;
            fiyat4 = fiyat4 + 22;
            textBox9.Text = icellatte.ToString();
            textBox10.Text = fiyat4.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            whitechocolate++;
            fiyat5 = fiyat5 + 21;
            textBox11.Text = whitechocolate.ToString();
            textBox12.Text = fiyat5.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            icemocha++;
            fiyat6 = fiyat6 + 19;
            textBox13.Text = icemocha.ToString();
            textBox14.Text = fiyat6.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frappucino++;
            fiyat7 = fiyat7 + 20;
            textBox15.Text = frappucino.ToString();
            textBox16.Text = fiyat7.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            icellatte--;
            fiyat4 = fiyat4 - 22;
            textBox9.Text = icellatte.ToString();
            textBox10.Text = fiyat4.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            whitechocolate--;
            fiyat5 = fiyat5 - 21;
            textBox11.Text = whitechocolate.ToString();
            textBox12.Text = fiyat5.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            icemocha--;
            fiyat6 = fiyat6 - 19;
            textBox13.Text = icemocha.ToString();
            textBox14.Text = fiyat6.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frappucino--;
            fiyat7 = fiyat7 - 20;
            textBox15.Text = frappucino.ToString();
            textBox16.Text = fiyat7.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplamsatis, toplamfiyat;
            toplamsatis = cay + turkkahvesi + bitkicayi + sutlukahve + icellatte + icemocha + frappucino + whitechocolate;
            label16.Text = toplamsatis.ToString();

            toplamfiyat = fiyat + fiyat1 + fiyat1 + fiyat2 + fiyat3 + fiyat4 + fiyat5 + fiyat6 + fiyat7;
            label17.Text = toplamfiyat.ToString();
            if (radioButton2.Checked == true)
            {
                
                label17.Text = Convert.ToString(toplamfiyat + 3);
            }
            if (radioButton3.Checked == true)
            {
                
                label17.Text = Convert.ToString(toplamfiyat + 7);
            }
            if (radioButton4.Checked == true)
            {
                
                label17.Text = Convert.ToString(toplamfiyat + 3);
            }

            if (radioButton4.Checked == true)
            {
                
                label17.Text = Convert.ToString(toplamfiyat + 3);
            }
            if (radioButton5.Checked == true)
            {
                
                label17.Text = Convert.ToString(toplamfiyat + 3);
            }

            if (radioButton6.Checked == true)
            {
                
                label17.Text = Convert.ToString(toplamfiyat + 3);
            }
            if (radioButton9.Checked == true)
            {
                MessageBox.Show("Ücretsiz Seçim");
                label17.Text = Convert.ToString(toplamfiyat + 0);
            }
            label17.Text = toplamfiyat.ToString();
            if (radioButton8.Checked == true)
            {
                
                label17.Text = Convert.ToString(toplamfiyat + 3);
            }
            if (radioButton1.Checked == true)
            {

                label17.Text = Convert.ToString(toplamfiyat + 1);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int toplamsatis, toplamfiyat;
            toplamsatis = cay + turkkahvesi + bitkicayi + sutlukahve + icellatte + icemocha + frappucino + whitechocolate;
            label16.Text = toplamsatis.ToString();

            toplamfiyat = fiyat + fiyat1 + fiyat1 + fiyat2 + fiyat3 + fiyat4 + fiyat5 + fiyat6 + fiyat7;
            label17.Text = toplamfiyat.ToString();
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("1TL Ekstra Ödeme");
                label17.Text = Convert.ToString(toplamfiyat + 1);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int toplamsatis, toplamfiyat;
            toplamsatis = cay + turkkahvesi + bitkicayi + sutlukahve + icellatte + icemocha + frappucino + whitechocolate;
            label16.Text = toplamsatis.ToString();

            toplamfiyat = fiyat + fiyat1 + fiyat1 + fiyat2 + fiyat3 + fiyat4 + fiyat5 + fiyat6 + fiyat7;
            label17.Text = toplamfiyat.ToString();
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("3TL Ekstra Ödeme");
                label17.Text = Convert.ToString(toplamfiyat + 3);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int toplamsatis, toplamfiyat;
            toplamsatis = cay + turkkahvesi + bitkicayi + sutlukahve + icellatte + icemocha + frappucino + whitechocolate;
            label16.Text = toplamsatis.ToString();

            toplamfiyat = fiyat + fiyat1 + fiyat1 + fiyat2 + fiyat3 + fiyat4 + fiyat5 + fiyat6 + fiyat7;
            label17.Text = toplamfiyat.ToString();
            if (radioButton3.Checked == true)
            {
                MessageBox.Show("7TL Ekstra Ödeme");
                label17.Text = Convert.ToString(toplamfiyat + 7);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int toplamsatis, toplamfiyat;
            toplamsatis = cay + turkkahvesi + bitkicayi + sutlukahve + icellatte + icemocha + frappucino + whitechocolate;
            label16.Text = toplamsatis.ToString();

            toplamfiyat = fiyat + fiyat1 + fiyat1 + fiyat2 + fiyat3 + fiyat4 + fiyat5 + fiyat6 + fiyat7;
            label17.Text = toplamfiyat.ToString();
            if (radioButton4.Checked == true)
            {
                MessageBox.Show("3 TL Ekstra Ödeme");
                label17.Text = Convert.ToString(toplamfiyat + 3);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            int toplamsatis, toplamfiyat;
            toplamsatis = cay + turkkahvesi + bitkicayi + sutlukahve + icellatte + icemocha + frappucino + whitechocolate;
            label16.Text = toplamsatis.ToString();

            toplamfiyat = fiyat + fiyat1 + fiyat1 + fiyat2 + fiyat3 + fiyat4 + fiyat5 + fiyat6 + fiyat7;
            label17.Text = toplamfiyat.ToString();
            if (radioButton5.Checked == true)
            {
                MessageBox.Show("3 TL Ekstra Ödeme");
                label17.Text = Convert.ToString(toplamfiyat + 3);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            int toplamsatis, toplamfiyat;
            toplamsatis = cay + turkkahvesi + bitkicayi + sutlukahve + icellatte + icemocha + frappucino + whitechocolate;
            label16.Text = toplamsatis.ToString();

            toplamfiyat = fiyat + fiyat1 + fiyat1 + fiyat2 + fiyat3 + fiyat4 + fiyat5 + fiyat6 + fiyat7;
            label17.Text = toplamfiyat.ToString();
            if (radioButton6.Checked == true)
            {
                MessageBox.Show("3 TL Ekstra Ödeme");
                label17.Text = Convert.ToString(toplamfiyat + 3);
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            int toplamsatis, toplamfiyat;
            toplamsatis = cay + turkkahvesi + bitkicayi + sutlukahve + icellatte + icemocha + frappucino + whitechocolate;
            label16.Text = toplamsatis.ToString();

            toplamfiyat = fiyat + fiyat1 + fiyat1 + fiyat2 + fiyat3 + fiyat4 + fiyat5 + fiyat6 + fiyat7;
            label17.Text = toplamfiyat.ToString();
            if (radioButton9.Checked == true)
            {
                MessageBox.Show("Ücretsiz Seçim");
                label17.Text = Convert.ToString(toplamfiyat + 0);
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            int toplamsatis, toplamfiyat;
            toplamsatis = cay + turkkahvesi + bitkicayi + sutlukahve + icellatte + icemocha + frappucino + whitechocolate;
            label16.Text = toplamsatis.ToString();

            toplamfiyat = fiyat + fiyat1 + fiyat1 + fiyat2 + fiyat3 + fiyat4 + fiyat5 + fiyat6 + fiyat7;
            label17.Text = toplamfiyat.ToString();
            if (radioButton8.Checked == true)
            {
                MessageBox.Show("2 TL Ekstra Ödeme");
                label17.Text = Convert.ToString(toplamfiyat + 3);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
            textBox10.Text = " ";
            textBox11.Text = " ";
            textBox12.Text = " ";
            textBox13.Text = " ";
            textBox14.Text = " ";
            textBox15.Text = " ";
            textBox16.Text = " ";
            label16.Text = " ";
            label17.Text = " ";

            radioButton7.Checked = true;


        }
    }
}
