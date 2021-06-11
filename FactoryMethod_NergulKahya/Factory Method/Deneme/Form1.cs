using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDeger_Click(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Creater creater = new Creater();
            PDil java = creater.FactoryMethod(PDiller.Java);
            PDil python = creater.FactoryMethod(PDiller.Python);
            PDil dart = creater.FactoryMethod(PDiller.Dart);
            if (comboBox1.SelectedIndex==0)
            {
                lblDeger.Text=java.Yadir();

            } 
            else if(comboBox1.SelectedIndex==1)
            {
                lblDeger.Text = python.Yadir();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                lblDeger.Text = dart.Yadir();
            }

        }
    }
}
