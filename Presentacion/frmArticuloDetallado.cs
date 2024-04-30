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
using System.Globalization;

namespace Presentacion
{
    public partial class frmArticuloDetallado : Form
    {
        private Articulo articulo = null;
        public frmArticuloDetallado()
        {
            InitializeComponent();
        }
        public frmArticuloDetallado(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            
        }
        private void frmArticuloDetallado_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio marca = new MarcaNegocio();
                CategoriaNegocio categoria = new CategoriaNegocio();

                cboMarca.DataSource = marca.listar();
                cboCategoria.DataSource = categoria.listar();

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
                    cargarImagen(articulo.ImagenUrl);
                    txtMarca.Text = articulo.Marca.Descripcion;
                    txtCategoria.Text = articulo.Categoria.Descripcion;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
