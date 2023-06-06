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
    public partial class frmCatalogo : Form
    {
        private List<Articulo> listaArticulo;

        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            cargar();
            cbCampo.Items.Add("Precio");
            cbCampo.Items.Add("Nombre");
            //cbCampo.Items.Add("Codigo");
            //cbCampo.Items.Add("Marca");
            //cbCampo.Items.Add("Categoria");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                cargarImagen(listaArticulo[0].ImagenUrl);
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Nombre"].Visible = true;
            dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = true;
            dgvArticulos.Columns["Categoria"].Visible = true;
            dgvArticulos.Columns["Precio"].Visible = true;
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

        private void btAgregar_Click(object sender, EventArgs e)
        {
            frmArticulo alta = new frmArticulo();
            alta.ShowDialog();
            cargar();
        } 


        private void btModificar_Click_1(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            
            frmArticulo modificar = new frmArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
      
        
        private void botonDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmVerArticulo detalle = new frmVerArticulo(seleccionado);
            detalle.ShowDialog();
            cargar();
        }



        private void btEliminarFisico_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad queres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = tbFiltroRapido.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Precio.ToString().Contains(filtro.Normalize()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Mayor a");
                cbCriterio.Items.Add("Menor a");
                cbCriterio.Items.Add("Igual a");
            }
            else
            {              
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Comienza con");
                cbCriterio.Items.Add("Termina con");
                cbCriterio.Items.Add("Contiene");
            }
        }

        private bool validarFiltro()
        {
            if(cbCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if(cbCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cbCampo.SelectedItem.ToString() == "Precio")
            {
                if(string.IsNullOrEmpty(tbFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro con algun precio.");
                    return true;
                }

                if (!(soloNumeros(tbFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Por favor, solo numeros para filtrar por precio.");
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

        private void botonBuscar_Click(object sender, EventArgs e) 
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cbCampo.SelectedItem.ToString(); 
                string criterio = cbCriterio.SelectedItem.ToString(); 
                string filtro = tbFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       





    }
}
