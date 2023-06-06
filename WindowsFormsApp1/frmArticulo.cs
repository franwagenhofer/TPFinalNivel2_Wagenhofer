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
using System.Configuration;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frmArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        public frmArticulo()
        {
            InitializeComponent();
        }

        public frmArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cbMarca.DataSource = marcaNegocio.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";
                               
                cbCategoria.DataSource = categoriaNegocio.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";


                if (articulo != null)
                {
                    tbCodigo.Text = articulo.Codigo;
                    tbNombre.Text = articulo.Nombre;
                    tbDescripcion.Text = articulo.Descripcion;
                    tbPrecio.Text = articulo.Precio.ToString();
                    
                    tbImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    cbCategoria.SelectedValue = articulo.Categoria.Id;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }      
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {           
            ArticuloNegocio negocio = new ArticuloNegocio();
          
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = tbCodigo.Text;
                articulo.Nombre = tbNombre.Text;
                articulo.Descripcion = tbDescripcion.Text;
                articulo.Precio = decimal.Parse(tbPrecio.Text);

                articulo.ImagenUrl = tbImagen.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;               

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

                if (archivo != null && !(tbImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbImagen.Load("https://www.pulsecarshalton.co.uk/wp-content/uploads/2016/08/jk-placeholder-image.jpg");
            }
        }

        private void botonImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                tbImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
