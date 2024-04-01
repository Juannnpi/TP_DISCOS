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
    public partial class frmDiscos : Form
    {
        private List<Disco> listaDiscos;
        public frmDiscos()
        {
            InitializeComponent();
        }

        private void frmDiscos_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Título");
            cboCampo.Items.Add("Año de lanzamiento");
            cboCampo.Items.Add("Estilo");
        }
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {            
            if (dgvDiscos.CurrentRow != null)
            {
                Disco seleccion = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccion.UrlImagenTapa);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco alta = new frmAltaDisco();
            alta.ShowDialog();
            cargar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null)
            {
                Disco seleccionado;
                seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                frmAltaDisco modificar = new frmAltaDisco(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
        }
        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;
            string Filtro = txtFiltro.Text;
            if (Filtro.Length > 2)
                listaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(Filtro.ToUpper()) || x.Estilo.Descripcion.ToUpper().Contains(Filtro.ToUpper()));
            else
                listaFiltrada = listaDiscos;
            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultarColumnasyFormato();
        }
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Año de lanzamiento")
            {
                cboCriterio.DataSource = null;
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Menor a");
            }
            else if (opcion == "Estilo")
            {
                try
                {
                    EstiloNegocio estilos = new EstiloNegocio();
                    cboCriterio.DataSource = null;
                    cboCriterio.Items.Clear();
                    cboCriterio.DataSource = estilos.listar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                cboCriterio.DataSource = null;
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Contiene");
                cboCriterio.Items.Add("Termina con");
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                if (cboCampo.Text != "" && cboCriterio.Text != "")
                {
                    string campo = cboCampo.SelectedItem.ToString();
                    string criterio = cboCriterio.SelectedItem.ToString();
                    string filtro = txtFiltroAv.Text;
                    dgvDiscos.DataSource = negocio.filtrar(campo, criterio, filtro);
                }
                else
                    dgvDiscos.DataSource = listaDiscos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnasyFormato()
        {
            dgvDiscos.Columns["Id"].Visible = false;
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["FechaLanzamiento"].DefaultCellStyle.Format = "yyyy";
        }
        private void cargar()
        {
            DiscosNegocio negocio = new DiscosNegocio();
            listaDiscos = negocio.listar();
            dgvDiscos.DataSource = listaDiscos;
            ocultarColumnasyFormato();
            cargarImagen("https://www.elephantstock.com/cdn/shop/collections/vinyl-records-wall-art.jpg");
            //dgvDiscos.Columns["FechaLanzamiento"].HeaderText = "Año de lanzamiento";
            //dgvDiscos.Columns["CantidadCanciones"].HeaderText = "Cantidad de canciones";
            //dgvDiscos.Columns["Titulo"].HeaderText = "Título";
            //dgvDiscos.Columns["Edicion"].HeaderText = "Edición";
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxTapa.Load(imagen);
            }
            catch (Exception)
            {
                pbxTapa.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }
        private void eliminar(bool logico = false)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            Disco seleccionado;
            try
            {
                DialogResult seleccion = MessageBox.Show("¿Está seguro de eliminar el disco?", "Eliminar disco", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (seleccion == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
