using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsRead
{
    public partial class WhatsReader : Form
    {
        public WhatsReader()
        {
            InitializeComponent();
                
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //escriu línia a línia el text de l'array
        private void Escriutext()
        {
            foreach (string linia in Program.textarxiu)
            {
                tbsortida.Text += linia + "\r\n";

            }

        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Program.Llegeix();
            Escriutext();

        }
    }
}
