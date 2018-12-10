using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagio
{
    public partial class caddispo : Form
    {
        public caddispo()
        {
            InitializeComponent();
            cboxInicio.SelectedIndex = 0;
            cboxFim.SelectedIndex = 0;
            cboxSemana.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
