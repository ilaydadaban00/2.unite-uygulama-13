using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_uygulama_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int sinif = Convert.ToInt32(comboBox1.Text);
            if(sinif > 0 && sinif <  5)
            {
                MessageBox.Show("ilkokul kademesi");
            }else if(sinif > 4 && sinif <9)
            {
                MessageBox.Show("ortaokul kademesi");
            }
            else
            {
                MessageBox.Show("lise kademesi");
            }
            
        }
    }
}
