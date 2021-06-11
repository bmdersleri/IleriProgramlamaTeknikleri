using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ileri_programlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Creater creater = new Creater();
            PDil java = creater.FactoryMethod(PDiller.Java);
            PDil python = creater.FactoryMethod(PDiller.Python);
            PDil dart = creater.FactoryMethod(PDiller.Dart);
            if (cmbDiller.SelectedIndex==0)
            {
                label1.Text = java.Yazdir();
            }
            else if (cmbDiller.SelectedIndex==1)
            {
                label1.Text = python.Yazdir();
            }
            else if (cmbDiller.SelectedIndex==2)
            {
                label1.Text = dart.Yazdir();
            }
         
        }
    }
}
