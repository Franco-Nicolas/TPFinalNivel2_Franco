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

namespace Presentacion
{
    public partial class frmCatalogo : Form
    {
        private List<Articulo> listaArticulo;
        public frmCatalogo()
        {
            InitializeComponent();
        }
        //Eventos
        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            cargar();

            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoría");
        }
        private void dgvCatalogo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCatalogo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {
                if (dgvCatalogo.CurrentRow != null)
                {
                    seleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                    frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                    modificar.ShowDialog();
                    cargar();
                }
                else
                {
                    MessageBox.Show("Selecciona un artículo a modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                if (dgvCatalogo.CurrentRow != null)
                {
                    DialogResult seleccion = MessageBox.Show("El artículo se eliminará permanentemente. ¿Está seguro de querer eliminarlo?", "Eliminando artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (seleccion == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);
                        cargar();
                    }
                }
                else
                    MessageBox.Show("Seleccione un artículo a eliminar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaBusqueda;
            string filtro = txtBusqueda.Text;

            if (filtro.Length >= 2)
            {
                listaBusqueda = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaBusqueda = listaArticulo;
            }

            dgvCatalogo.DataSource = null;
            dgvCatalogo.DataSource = listaBusqueda;
            ocultarColumnas();
        }
        private void dgvCatalogo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo seleccionado;
            try
            {
                if (dgvCatalogo.CurrentRow != null)
                {
                    seleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                    frmArticuloDetallado detalle = new frmArticuloDetallado(seleccionado);
                    detalle.ShowDialog();
                    cargar();
                }
                else
                {
                    MessageBox.Show("Seleccione un artículo a modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarFiltroAvanzado())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvCatalogo.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Metodos
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvCatalogo.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://www.came-educativa.com.ar/upsoazej/2022/03/placeholder-2.png");
            }
        }
        private void ocultarColumnas()
        {
            dgvCatalogo.Columns["ImagenUrl"].Visible = false;
            dgvCatalogo.Columns["Id"].Visible = false;
            dgvCatalogo.Columns["Precio"].Visible = false;
        }
        private bool validarFiltroAvanzado()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el campo a filtrar por favor.");
                return true;
            }

            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el criterio a filtrar por favor.");
                return true;
            }

            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(soloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Ingrese solamente números al trabajar con este campo por favor.");
                    return true;
                }
            }

            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
    }
}
