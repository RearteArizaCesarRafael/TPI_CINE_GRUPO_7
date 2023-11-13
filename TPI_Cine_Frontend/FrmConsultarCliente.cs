using TPI_Cine_Frontend.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_Cine_Frontend
{
    public partial class FrmConsultarCliente : Form
    {
        public FrmConsultarCliente()
        {
            InitializeComponent();

        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            TemasColores.ViewClientConsult(this, Color.WhiteSmoke, FormBorderStyle.Fixed3D);
        }
    }
}
