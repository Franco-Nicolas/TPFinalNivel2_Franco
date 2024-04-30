using System;
using System.Windows.Forms;
using negocio;
using dominio;
using System.IO;
using System.Configuration;
using System.Globalization;

namespace Presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }
        //Eventos
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marca.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoria.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                cboCategoria.SelectedIndex = -1;
                cboMarca.SelectedIndex = -1;

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarArticulo())
                    return;

                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                if (archivo != null && !(txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                }
                Close();
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
        //Metodos
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
        private bool validarArticulo()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text) || cboMarca.SelectedIndex < 0 || cboCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("¡Quedan campos sin completar!", "Atención");
                return true;
            }
            if (!(soloNumeros(txtPrecio.Text)))
            {
                MessageBox.Show("Ingrese solamente números al agregar un precio por favor.");
                return true;
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
