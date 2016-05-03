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
    public partial class DodavanjeProdukt : Form
    {
        public Product Product { get; set; }
        public DodavanjeProdukt()
        {
            InitializeComponent();
        }
        private void tbImeProduktDodavanje_Validating(object sender, CancelEventArgs e)
        {
            if (tbImeProduktDodavanje.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbImeProduktDodavanje, "Внесете име!");
            }
            else
            {
                errorProvider1.SetError(tbImeProduktDodavanje, null);
            }
        }
        private void tbKategorijaProduktDodavanje_Validating(object sender, CancelEventArgs e)
        {
            if (tbKategorijaProduktDodavanje.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbKategorijaProduktDodavanje, "Внесете категорија!");
            }
            else
            {
                errorProvider1.SetError(tbKategorijaProduktDodavanje, null);
            }
        }
        private void tbCenaProduktDodavanje_Validating(object sender, CancelEventArgs e)
        {
            if (tbCenaProduktDodavanje.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCenaProduktDodavanje, "Внесете цена!");
            }
            else
            {
                errorProvider1.SetError(tbCenaProduktDodavanje, null);
            }
        }


        private void btnDodadiProdukt_Click(object sender, EventArgs e)
        {
            double cena;
            double.TryParse(tbCenaProduktDodavanje.Text, out cena);
            Product = new Product(tbImeProduktDodavanje.Text, tbKategorijaProduktDodavanje.Text, cena);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOtkaziProdukt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
