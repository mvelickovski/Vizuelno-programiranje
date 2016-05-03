using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Product p1 = new Product("Месо", "Исхрана", 300);
            Product p2 = new Product("Млеко", "Исхрана", 50);
            Product p3 = new Product("Вино", "Пијалоци", 150);
            Product p4 = new Product("Пиво", "Пијалоци", 100);
            Product p5 = new Product("Шампон", "Хигиена", 150);
            Product p6 = new Product("Паста за заби", "Хигиена", 100);
            lbListaProdukti.Items.Add(p1);
            lbListaProdukti.Items.Add(p2);
            lbListaProdukti.Items.Add(p3);
            lbListaProdukti.Items.Add(p4);
            lbListaProdukti.Items.Add(p5);
            lbListaProdukti.Items.Add(p6);
        }

        public void presmetajVkupno()
        {
            double vkupnoSuma = 0;
            Product produkt;
            for(int i = 0; i < lbKosnicka.Items.Count; i++)
            {
                produkt = (Product)lbKosnicka.Items[i];
                vkupnoSuma += produkt.cena;
            }
            tbVkupnoSuma.Text = String.Format("{0:0.00}", vkupnoSuma);
        }
        private void btnDodadiNovProdukt_Click(object sender, EventArgs e)
        {
            DodavanjeProdukt f1 = new DodavanjeProdukt();
            if(f1.ShowDialog() == DialogResult.OK)
            {
                lbListaProdukti.Items.Add(f1.Product);
            }
        }

        private void listaProduktiChange(object sender, EventArgs e)
        {
            if (lbListaProdukti.SelectedIndex == -1)
                return;
            else
            {
                Product produkt = (Product)lbListaProdukti.SelectedItem;
                tbImeProdukt.Text = produkt.ime;
                tbKategorijaProdukt.Text = produkt.kategorija;
                tbCenaProdukt.Text = String.Format("{0:0.00}", produkt.cena);
            }
            
        }

        private void btnDodadiVoKosnicka_Click(object sender, EventArgs e)
        {
            if (lbListaProdukti.SelectedIndex == -1)
                MessageBox.Show("Изберете го продуктот што сакате да го внесете во кошничката.","Грешка!");
            else
            {
                Product produkt = (Product)lbListaProdukti.SelectedItem;
                lbKosnicka.Items.Add(produkt);
                presmetajVkupno();
            }
            
        }

        private void btnIzbrisiOdKosnicka_Click(object sender, EventArgs e)
        {
            if (lbKosnicka.SelectedIndex == -1)
                MessageBox.Show("Изберете го продуктот што сакате да го тргнете од кошничката.","Грешка!");
            else 
                lbKosnicka.Items.RemoveAt(lbKosnicka.SelectedIndex);
            presmetajVkupno();
        }

        private void btnIzbrisiProdukt_Click(object sender, EventArgs e)
        {
            if (lbListaProdukti.SelectedIndex == -1)
                MessageBox.Show("Изберете го продуктот што сакате да го избришете.", "Грешка!");
            else
            {
                lbListaProdukti.Items.RemoveAt(lbListaProdukti.SelectedIndex);
                tbImeProdukt.Text = "";
                tbKategorijaProdukt.Text = "";
                tbCenaProdukt.Text = "";
            }
                
        }

        private void btnIsprazniListaProdukti_Click(object sender, EventArgs e)
        {
            DialogResult res =
                MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со продукти",
                "Испразни ја листата?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                lbListaProdukti.Items.Clear();
            tbImeProdukt.Text = "";
            tbKategorijaProdukt.Text = "";
            tbCenaProdukt.Text = "";
        }

        private void btnIsprazniKosnicka_Click(object sender, EventArgs e)
        {
            DialogResult res =
                MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошничката?",
                "Испразни ја кошничката?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                lbKosnicka.Items.Clear();
            presmetajVkupno();
        }
    }
}
