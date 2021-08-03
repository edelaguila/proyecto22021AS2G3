﻿using MySql.Data.MySqlClient;
using sistema_reparto.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_reparto
{
    public partial class frmUbicacion : Form
    {


        /* Codigo para redondear mi panel */
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        /* Codigo para mover mi panel */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        /* Varibles para cambiar color de mi Boton */
        Color colorHoverUbicacion = Color.FromArgb(80, 115, 119);
        Color colorNormalUbicacion = Color.FromArgb(59, 102, 107);

        public frmUbicacion()
        {
            InitializeComponent();

            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            /*Inicio, ocultar contenidos del form ubicacion*/
            pnlBordeUbicacion.Visible = false;
            lblRegistrarUbicacion.Visible = false;
            lblModificarUbicacion.Visible = false;
            lblDarBajaU.Visible = false;
            pnlBordeRegistrarU.Visible = false;
            pnlBordeModificarU.Visible = false;
            pnlBordeDarBajaU.Visible = false;

            pnlCampoIDU.Visible = false;
            pnlCampoNombreU.Visible = false;
            pnlEstatusU.Visible = false;
            pnlDarBajaU.Visible = false;
            pnlActivarU.Visible = false;
            pnlBotonBuscarU.Visible = false;
            txtBuscarUbicacion.Visible = false;
            dgvUbicacion.Visible = false;
            pnlLlenarCamposUDB.Visible = false;
            pnlLLenarCamposU.Visible = false;
            pnlBotonGuardarU.Visible = false;
            pnlModificarU.Visible = false;
            /*Fin, ocultar contenidos del form ubicacion*/
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverUbicacion;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalUbicacion;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverUbicacion;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverUbicacion;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverUbicacion;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverUbicacion;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverUbicacion;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverUbicacion;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverUbicacion;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverUbicacion;
        }

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverUbicacion;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverUbicacion;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalUbicacion;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalUbicacion;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalUbicacion;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalUbicacion;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalUbicacion;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalUbicacion;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverUbicacion;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalUbicacion;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalUbicacion;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalUbicacion;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalUbicacion;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalUbicacion;
        }

        private void btnCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();
            obj.Visible = true;

            Visible = false;
        }

        private void lblCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();
            obj.Visible = true;

            Visible = false;
        }

        private void picIconoCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();
            obj.Visible = true;

            Visible = false;
        }

        private void btnPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos obj = new frmPuestos();
            obj.Visible = true;

            Visible = false;
        }

        private void lblPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos obj = new frmPuestos();
            obj.Visible = true;

            Visible = false;
        }

        private void picPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos obj = new frmPuestos();
            obj.Visible = true;

            Visible = false;
        }

        private void btnDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento obj = new frmDepartamento();
            obj.Visible = true;

            Visible = false;
        }

        private void lblDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento obj = new frmDepartamento();
            obj.Visible = true;

            Visible = false;
        }

        private void picDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento obj = new frmDepartamento();
            obj.Visible = true;

            Visible = false;
        }

        private void frmUbicacion_Load(object sender, EventArgs e)
        {

        }

        private void frmUbicacion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTituloCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblAbcCliente_Click(object sender, EventArgs e)
        {

        }

        private void pnlBordeCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRegistrarUbicacion_MouseClick(object sender, MouseEventArgs e)
        {

            /*Inicio cargando datos en tabla Ubicacion*/
            Ubicacion ubicacion = new Ubicacion();
            funCargarTabla(null);

            pnlBordeRegistrarU.Visible = true;
            pnlBordeModificarU.Visible = false;
            pnlBordeDarBajaU.Visible = false;

            /*Inicio esconder y mostrar contenidos del form ubicacion*/
            pnlCampoIDU.Visible = true;
            pnlCampoNombreU.Visible = true;
            pnlEstatusU.Visible = false;
            pnlDarBajaU.Visible = false;
            pnlActivarU.Visible = false;
            pnlBotonBuscarU.Visible = true;
            txtBuscarUbicacion.Visible = true;
            dgvUbicacion.Visible = true;
            pnlLlenarCamposUDB.Visible = false;
            pnlLLenarCamposU.Visible = true;
            pnlBotonGuardarU.Visible = true;
            pnlModificarU.Visible = false;
            /*Fin esconder y mostrar contenidos del form ubicacion*/

            /*Inicio deshabilitando y habilitando contenidos del form ubicacion*/
            pnlCampoIDU.Enabled = true;
            pnlCampoNombreU.Enabled = true;
            pnlEstatusU.Enabled = true;
            
            pnlBotonBuscarU.Enabled = true;
            txtBuscarUbicacion.Enabled = true;
            dgvUbicacion.Enabled = true;
            pnlLLenarCamposU.Enabled = true;
            /*Inicio deshabilitando y habilitando contenidos del form ubicacion*/
            
            funVaciarCampos();
        }

        private void lblAbcUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            /*Inicio colocando como visibles los labels y bordes*/
            pnlBordeUbicacion.Visible = true;
            lblRegistrarUbicacion.Visible = true;
            lblModificarUbicacion.Visible = true;
            lblDarBajaU.Visible = true;

            /*Fin colocando como visibles los labels y bordes*/
        }

        private void lblModificarUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();
            funCargarTabla(null);

            pnlBordeRegistrarU.Visible = false;
            pnlBordeModificarU.Visible = true;
            pnlBordeDarBajaU.Visible = false;
            

            /*Inicio esconder y mostrar contenidos del form ubicacion*/
            pnlCampoIDU.Visible = true;
            pnlCampoNombreU.Visible = true;
            pnlEstatusU.Visible = false;
            pnlDarBajaU.Visible = false;
            pnlActivarU.Visible = false;
            pnlBotonBuscarU.Visible = true;
            txtBuscarUbicacion.Visible = true;
            dgvUbicacion.Visible = true;
            pnlLlenarCamposUDB.Visible = false;
            pnlLLenarCamposU.Visible = true;
            pnlBotonGuardarU.Visible = false;
            pnlModificarU.Visible = true;

            
            /*Fin esconder y mostrar contenidos del form ubicacion*/

            /*Inicio deshabilitando y habilitando contenidos del form ubicacion*/
            pnlCampoIDU.Enabled = false;
            pnlCampoNombreU.Enabled = true;
            pnlEstatusU.Enabled = true;

            pnlBotonBuscarU.Enabled = true;
            txtBuscarUbicacion.Enabled = true;
            dgvUbicacion.Enabled = true;
            pnlLLenarCamposU.Enabled = true;
            /*Inicio deshabilitando y habilitando contenidos del form ubicacion*/
        }

        private void lblDarBajaU_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();
            funCargarTabla(null);

            pnlBordeRegistrarU.Visible = false;
            pnlBordeModificarU.Visible = false;
            pnlBordeDarBajaU.Visible = true;

            /*Inicio esconder y mostrar contenidos del form ubicacion*/
            pnlCampoIDU.Visible = true;
            pnlCampoNombreU.Visible = true;
            pnlEstatusU.Visible = true;
            pnlDarBajaU.Visible = false;
            pnlActivarU.Visible = false;
            pnlBotonBuscarU.Visible = true;
            txtBuscarUbicacion.Visible = true;
            dgvUbicacion.Visible = true;
            pnlLlenarCamposUDB.Visible = true;
            pnlLLenarCamposU.Visible = true;
            pnlBotonGuardarU.Visible = false;
            pnlModificarU.Visible = false;
            pnlLLenarCamposU.Visible = false;
            /*Fin esconder y mostrar contenidos del form ubicacion*/

            /*Inicio deshabilitando y habilitando contenidos del form ubicacion*/
            pnlCampoIDU.Enabled = false;
            pnlCampoNombreU.Enabled = false;
            pnlEstatusU.Enabled = false;

            pnlBotonBuscarU.Enabled = true;
            txtBuscarUbicacion.Enabled = true;
            dgvUbicacion.Enabled = true;
            pnlLLenarCamposU.Enabled = true;
            /*Inicio deshabilitando y habilitando contenidos del form ubicacion*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        

        private void pnlBotonGuardarU_MouseClick(object sender, MouseEventArgs e)
        {
            /* Funcion insertar una Ubicacion */
            String estatusUbicacion = "A";
            Ubicacion ubicacion = funObtenerTxt(estatusUbicacion);
            ubicacion.funInsertar();
            /* Final de ejecucion de funcion insertar un cliente */

            funCargarTabla(null);
            funVaciarCampos();
        }

        /*Inicio de funcion para vaciar los campos de ubicacion*/
        public void funVaciarCampos()
        {
            txtIdUbicacion.Text = "";
            txtNombreUbicacion.Text = "";
            txtEstatusUbicacion.Text = "";
            txtBuscarUbicacion.Text = "";
        }
        /*Fin de funcion para vaciar los campos de ubicacion*/


        /* Inicio de funcion para evitar el uso de recursivo de tantas variables */
        public Ubicacion funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC Ubicacion */
            String pCodigoU = txtIdUbicacion.Text;
            String pNombreU = txtNombreUbicacion.Text;
            /*Final obteniedo variables a usar con mi ABC Ubicacion */

            /* Inicio creamos un objeto de tipo Ubicacion para poder utilizar el metodo de insertar ubicacion */
            Ubicacion ubicacion = new Ubicacion(pCodigoU, pNombreU, estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar ubicacion */

            return ubicacion;
        }
        /* Final de funcion para evitar el uso recursivo de tantas variables */

        private void funCargarTabla(string dato)
        {
            List<Ubicacion> lista = new List<Ubicacion>();
            Ubicacion ubicacion = new Ubicacion();

            dgvUbicacion.DataSource = ubicacion.consulta(dato);
        }

        private void pnlBotonBuscarU_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarUbicacion = txtBuscarUbicacion.Text;
            funCargarTabla(buscarUbicacion);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlDarBajaU.Visible = false;
            pnlActivarU.Visible = false;
            /* Final Vaciando los campos */
        }
        
        /*Inicio llenando campos de la busqueda de la tabla a los txt*/
        private void pnlLLenarCamposU_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdUbicacion.Text = dgvUbicacion.CurrentRow.Cells[0].Value.ToString();
            txtNombreUbicacion.Text = dgvUbicacion.CurrentRow.Cells[1].Value.ToString();
            txtEstatusUbicacion.Text = dgvUbicacion.CurrentRow.Cells[2].Value.ToString();
        }
        /*Fin llenando campos de la busqueda de la tabla a los txt*/

        private void pnlModificarU_MouseClick(object sender, MouseEventArgs e)
        {
            String estatusUbicacion = "A";
            String idUbicacion = txtIdUbicacion.Text;
            Ubicacion ubicacion = funObtenerTxt(estatusUbicacion);

            ubicacion.funModificar(idUbicacion);
            funCargarTabla(null);
            ubicacion.funBuscarSetearTxt(txtIdUbicacion, txtNombreUbicacion, txtEstatusUbicacion, idUbicacion);

        }

        private void lblDarBajaU_Click(object sender, EventArgs e)
        {

        }

        private void pnlLlenarCamposUDB_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdUbicacion.Text = dgvUbicacion.CurrentRow.Cells[0].Value.ToString();
            txtNombreUbicacion.Text = dgvUbicacion.CurrentRow.Cells[1].Value.ToString();
            txtEstatusUbicacion.Text = dgvUbicacion.CurrentRow.Cells[2].Value.ToString();

            Ubicacion ubicacion = new Ubicacion();
            String pidUbicacion = txtIdUbicacion.Text;
            String pestatusUbicacion = ubicacion.funBuscarEstatus(pidUbicacion);

            if (pestatusUbicacion == "A")
            {
                pnlActivarU.Visible = false;
                pnlDarBajaU.Visible = true;
            }
            else if (pestatusUbicacion == "I")
            {
                pnlActivarU.Visible = true;
                pnlDarBajaU.Visible = false;
            }
        }

        public void funDarBajaCliente()
        {
            String pSqlModificar = "UPDATE ubicacion SET estatusUbicacion='I' WHERE idUbicacion='" + txtIdUbicacion + "'";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarUbicacion = new MySqlCommand(pSqlModificar, conexionBD);
                modificarUbicacion.ExecuteNonQuery();
                MessageBox.Show("Estatus modificado Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void pnlActivarU_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdUbicacion = txtIdUbicacion.Text;
            Ubicacion ubicacion = funObtenerTxt(estatus);

            ubicacion.funActivarUbicacion();
            funCargarTabla(null);

            pnlDarBajaU.Visible = true;
            pnlActivarU.Visible = false;

            ubicacion.funBuscarSetearTxt(txtIdUbicacion, txtNombreUbicacion, txtEstatusUbicacion, pIdUbicacion);

        }



        private void pnlDarBajaU_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdUbicacion = txtIdUbicacion.Text;
            Ubicacion ubicacion = funObtenerTxt(estatus);

            ubicacion.funDarBajaUbicacion();
            funCargarTabla(null);

            pnlActivarU.Visible = true;
            pnlDarBajaU.Visible = false;

            ubicacion.funBuscarSetearTxt(txtIdUbicacion, txtNombreUbicacion, txtEstatusUbicacion, pIdUbicacion);
        }
    }
}