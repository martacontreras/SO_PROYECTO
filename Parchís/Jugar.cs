using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parchís
{
    public partial class Jugar : Form
    {
        public Jugar()
        {
            InitializeComponent();
        }

        private void jugar__Click(object sender, EventArgs e)
        {
            Iniciarsesión IC = new Iniciarsesión();
            IC.ShowDialog();
        }
    }
}
