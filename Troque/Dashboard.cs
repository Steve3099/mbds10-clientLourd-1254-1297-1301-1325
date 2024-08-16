using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troque
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            AjoutProduit ajoutProduit = new AjoutProduit();
            ajoutProduit.ShowDialog();
        }
    }
}
