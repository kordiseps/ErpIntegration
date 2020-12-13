using ErpIntegration.Base.ModuleObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpIntegration.Tester
{
    public partial class FormLogoGoPlusCariEkle : Form
    {
        public FormLogoGoPlusCariEkle()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var erpService = new LogoGoPlus.ErpService();
            CustomerModuleObject cari = new CustomerModuleObject
            {
                Code = textBox_code.Text,
                TaxNumber = textBox_taxNumber.Text,
                Title = textBox_title.Text,
                
            };
            bool added = erpService.CustomerModule.Add(cari);
            if (added)
            {
                MessageBox.Show("Cari eklendi");
            }
            else
            {
                string error = erpService.CustomerModule.GetLastError();
                MessageBox.Show("Cari eklenemedi : " + error);
            }
        }
    }
}
