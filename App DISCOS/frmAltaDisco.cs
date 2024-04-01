using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace App_DISCOS
{
    public partial class frmAltaDisco : Form
    {
        private Disco disco = null;
        public frmAltaDisco()
        {
            InitializeComponent();
            //dtpAño.CustomFormat = "yyyy";
        }
        public frmAltaDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar disco";

        }

                
        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            TipoEdicionNegocio edicionNegocio = new TipoEdicionNegocio();
            try
            {
                cboEstilo.DataSource = estiloNegocio.listar();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";
                cboEstilo.SelectedIndex = -1;
                cboEdicion.DataSource = edicionNegocio.listar();
                cboEdicion.ValueMember = "Id";
                cboEdicion.DisplayMember = "Descripcion";
                cboEdicion.SelectedIndex = -1;                
                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    txtCanciones.Text = disco.CantidadCanciones.ToString();
                    txtUrlTapa.Text = disco.UrlImagenTapa;
                    dtpAño.Value = disco.FechaLanzamiento;
                    cargarImagen(disco.UrlImagenTapa);
                    cboEstilo.SelectedValue = disco.Estilo.Id;
                    cboEdicion.SelectedValue = disco.Edicion.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                if (disco == null)
                    disco = new Disco();                
                disco.Titulo = txtTitulo.Text;                
                if (txtCanciones.Text != "")
                    disco.CantidadCanciones = int.Parse(txtCanciones.Text);
                disco.FechaLanzamiento = dtpAño.Value;
                disco.UrlImagenTapa = txtUrlTapa.Text;
                disco.Estilo = (Estilo)cboEstilo.SelectedItem;
                disco.Edicion = (Edicion)cboEdicion.SelectedItem;
                if (txtTitulo.Text == "" || cboEstilo.SelectedIndex == -1 || cboEdicion.SelectedIndex == -1 || dtpAño.Checked == false)                
                    MessageBox.Show("Falta cargar datos");                
                else
                {
                    if (disco.Id == 0)
                    {
                        negocio.agregar(disco);
                        MessageBox.Show("Agregado exitosamente");
                    }
                    else
                    {
                        negocio.modificar(disco);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlTapa_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlTapa.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAgregarTapa.Load(imagen);
            }
            catch (Exception)
            {
                pbxAgregarTapa.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }            
        }
    }
}
