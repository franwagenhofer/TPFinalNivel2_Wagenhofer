using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmVerArticulo : Form
    {
        private Articulo articulo = null;

        public frmVerArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmVerArticulo_Load(object sender, EventArgs e) 
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cMarca.DataSource = marcaNegocio.listar();
                cMarca.ValueMember = "Id";
                cMarca.DisplayMember = "Descripcion";

                cCategoria.DataSource = categoriaNegocio.listar();
                cCategoria.ValueMember = "Id";
                cCategoria.DisplayMember = "Descripcion";


                if (articulo != null)
                {
                    tCodigo.Text = articulo.Codigo;
                    tNombre.Text = articulo.Nombre;
                    tDescripcion.Text = articulo.Descripcion;
                    tPrecio.Text = articulo.Precio.ToString();

                    tImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    cMarca.SelectedValue = articulo.Marca.Id;
                    cCategoria.SelectedValue = articulo.Categoria.Id;

                }
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
                pImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pImagen.Load("https://www.pulsecarshalton.co.uk/wp-content/uploads/2016/08/jk-placeholder-image.jpg");
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
