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
    public partial class cadprof : Form
    {
        bool valorcbox;
        public cadprof()
        {
            InitializeComponent();
        }
        Controle controle = new Controle();
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncadprof_Click(object sender, EventArgs e)
        {

            if (cboxcoord.Checked==true)
            {
                valorcbox = true;
            }
            else
            {
                valorcbox = false;
            }
            bool ok = controle.cadastrar(txbmatriculap.Text, txbnomep.Text, txbdisciplinap.Text, Convert.ToInt32(txbcargahp.Text), valorcbox); //não sei transformar txtbox em int, só pegar string
            string mensagem =  "Ocorreu algum erro";
            if (ok)
            {
                mensagem = "Cadastrado com sucesso.";
                limparCampos();
            }

            MessageBox.Show(mensagem);
        }

        private void cadprof_Load(object sender, EventArgs e)
        {

        }

        private void limparCampos()
        {
            txbcargahp.Text = "";
            txbdisciplinap.Text = "";
            txbmatriculap.Text = "";
            txbnomep.Text = "";
            cboxcoord.Checked = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            caddispo caddisp = new caddispo();
            caddisp.ShowDialog();
        }
    }
}
