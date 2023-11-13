using TPI_Cine_Frontend.HTTP;
using TPI_Cine_Frontend.Presentacion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_Cine_Frontend
{
    public partial class FrmAltaFuncion : Form
    {
        List<Sala> listaSala = new List<Sala> ();
        public FrmAltaFuncion()
        {
            InitializeComponent();

        }

        private void FrmAltaFuncion_Load(object sender, EventArgs e)
        {
            TemasColores.ViewClientConsult(this, Color.WhiteSmoke, FormBorderStyle.Fixed3D);
            LoadFilmsAsync();
            LoadRoomsAsync();
        }

        private async void LoadRoomsAsync()
        {
            string url = "";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Sala>>(result);
            List<Sala> listaSala = lst;
            cboPelicula.DataSource = listaSala;
            cboPelicula.DisplayMember = "id_sala";
            cboPelicula.ValueMember = "id_sala";

            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void LoadFilmsAsync()
        {
            string url = "";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Pelicula>>(result);
            cboPelicula.DataSource = lst;
            cboPelicula.DisplayMember = "id_pelicula";
            cboPelicula.ValueMember = "nombre";
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        

            private void txtTipoSala_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtTipoSala.Text = listaSala[cboPelicula.SelectedIndex].t;
            txtTipoSala.Text = (Sala)listaSala[cboPelicula.SelectedIndex].tipoSala.toString();
        }
    }
}
