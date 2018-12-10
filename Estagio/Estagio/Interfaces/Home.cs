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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lblcadprof_Click(object sender, EventArgs e)
        {
            cadprof cadp = new cadprof();
            cadp.ShowDialog();
        }

        private void lblgradehorprofs_Click(object sender, EventArgs e)
        {
            GradeProvas gradp = new GradeProvas();
            gradp.ShowDialog();
        }

        private void lblcalendsemanal_Click(object sender, EventArgs e)
        {
            gradesemanal gradsem = new gradesemanal();
            gradsem.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
