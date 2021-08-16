using MySql.Data.MySqlClient;
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


            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;
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

            if(txtIdUbicacion.Text=="" || txtNombreUbicacion.Text == "")
            {
                MessageBox.Show("No se pueden ingresar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String estatusUbicacion = "A";
                Ubicacion ubicacion = funObtenerTxt(estatusUbicacion);
                ubicacion.funInsertar();
                /* Final de ejecucion de funcion insertar un cliente */

                funCargarTabla(null);
                funVaciarCampos();
            }
            
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

        private void btnTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void lblTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void lblTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void picTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void picTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void lblTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void picTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pnlSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion objSubUbicacion = new frmSubUbicacion();

            objSubUbicacion.Visible = true;
            Visible = false;
        }

        private void lblSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion objSubUbicacion = new frmSubUbicacion();

            objSubUbicacion.Visible = true;
            Visible = false;
        }

        private void picSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion objSubUbicacion = new frmSubUbicacion();

            objSubUbicacion.Visible = true;
            Visible = false;
        }

        private void pnlSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverUbicacion;
        }

        private void pnlSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalUbicacion;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverUbicacion;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalUbicacion;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverUbicacion;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalUbicacion;
        }

        private void btnRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta ruta = new frmRuta();
            ruta.Visible = true;

            Visible = false;

        }

        private void label10_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta ruta = new frmRuta();
            ruta.Visible = true;

            Visible = false;

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta ruta = new frmRuta();
            ruta.Visible = true;

            Visible = false;

        }

        private void lblTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoMovimiento tipoM = new frmTipoMovimiento();
            tipoM.Visible = true;

            Visible = false;
        }

        private void btnTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoMovimiento tipoM = new frmTipoMovimiento();
            tipoM.Visible = true;

            Visible = false;
        }

        private void picTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoMovimiento tipoM = new frmTipoMovimiento();
            tipoM.Visible = true;

            Visible = false;
        }

        private void btnRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverUbicacion;
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverUbicacion;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverUbicacion;
        }

        private void btnTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void lblTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void picTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalUbicacion;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalUbicacion;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalUbicacion;
        }

        private void btnTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void lblTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void picTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btnTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte obj = new frmTipoTransporte();

            obj.Visible = true;

            Visible = false;

        }

        private void btnTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverUbicacion;
        }

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalUbicacion;
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverUbicacion;
        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalUbicacion;
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverUbicacion;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalUbicacion;
        }

        private void picIconoTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion obj = new frmUbicacion();

            obj.Visible = true;

            Visible = false;
        }

        private void lblTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion obj = new frmUbicacion();

            obj.Visible = true;

            Visible = false;
        }

        private void btnUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.Visible = true;

            Visible = false;
        }

        private void lblUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.Visible = true;

            Visible = false;
        }

        private void picIconoUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.Visible = true;

            Visible = false;
        }

        private void btnPaqueteEncabezado_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteEncabezado obj = new frmPaqueteEncabezado();
            obj.Visible = true;

            Visible = false;
        }

        private void lblPaqueteEncabezado_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteEncabezado obj = new frmPaqueteEncabezado();
            obj.Visible = true;

            Visible = false;
        }

        private void picIconoPaqueteE_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteEncabezado obj = new frmPaqueteEncabezado();
            obj.Visible = true;

            Visible = false;
        }

        private void btnPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverUbicacion;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverUbicacion;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverUbicacion;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalUbicacion;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalUbicacion;
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalUbicacion;
        }

        private void pnlEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void btnBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmBodega bodega = new frmBodega();
            bodega.Visible = true;

            Visible = false;
        }

        private void lblBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmBodega bodega = new frmBodega();
            bodega.Visible = true;

            Visible = false;
        }

        private void picBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmBodega bodega = new frmBodega();
            bodega.Visible = true;

            Visible = false;
        }

        private void btnBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverUbicacion;
        }

        private void lblBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverUbicacion;
        }

        private void picBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverUbicacion;
        }

        private void picBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalUbicacion;
        }

        private void btnBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalUbicacion;
        }

        private void lblBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalUbicacion;
        }

        private void label14_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlEnvio_MouseClick(object sender, MouseEventArgs e)
        {
            frmEnvio obj = new frmEnvio();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlEnvio_MouseHover(object sender, EventArgs e)
        {

        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalUbicacion;
        }

        private void lblEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverUbicacion;
        }

        private void lblEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalUbicacion;
        }

        private void picEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverUbicacion;
        }

        private void picEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalUbicacion;
        }

        private void lblEnvio_MouseClick(object sender, MouseEventArgs e)
        {
            frmEnvio obj = new frmEnvio();

            obj.Visible = true;

            Visible = false;
        }

        private void picEnvio_MouseClick(object sender, MouseEventArgs e)
        {
            frmEnvio obj = new frmEnvio();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlTrans_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pnlTrans_MouseClick(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
            obj.Visible = true;
            Visible = false;
        }

        private void pnlMovBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmMovimientoBodega movBo = new frmMovimientoBodega();
            movBo.Visible = true;

            Visible = false;
        }

        private void lblMovimientoBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmMovimientoBodega movBo = new frmMovimientoBodega();
            movBo.Visible = true;

            Visible = false;
        }

        private void picMovBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmMovimientoBodega movBo = new frmMovimientoBodega();
            movBo.Visible = true;

            Visible = false;
        }

        private void pnlMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverUbicacion;
        }

        private void lblMovimientoBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverUbicacion;
        }

        private void picMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverUbicacion;
        }

        private void pnlMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalUbicacion;
        }

        private void lblMovimientoBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalUbicacion;
        }

        private void picMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalUbicacion;
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverUbicacion;
        }

        private void lblUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverUbicacion;
        }

        private void picIconoUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverUbicacion;
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalUbicacion;
        }

        private void lblUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalUbicacion;
        }

        private void picIconoUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalUbicacion;
        }

        private void btnCalificacionP_MouseClick(object sender, MouseEventArgs e)
        {
            frmCalificacionPiloto obj = new frmCalificacionPiloto();
            obj.Visible = true;

            Visible = false;
        }

        private void lblCalificacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmCalificacionPiloto obj = new frmCalificacionPiloto();
            obj.Visible = true;

            Visible = false;
        }

        private void picCalificacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmCalificacionPiloto obj = new frmCalificacionPiloto();
            obj.Visible = true;

            Visible = false;
        }

        private void btnCalificacionP_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverUbicacion;
        }

        private void lblCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverUbicacion;
        }

        private void picCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverUbicacion;
        }

        private void btnCalificacionP_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalUbicacion;
        }

        private void lblCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalUbicacion;
        }

        private void picCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalUbicacion;
        }

        private void btnPiloto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPiloto obj = new frmPiloto();

            obj.Visible = true;

            Visible = false;
        }

        private void lblPiloto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPiloto obj = new frmPiloto();

            obj.Visible = true;

            Visible = false;
        }

        private void picIconoPiloto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPiloto obj = new frmPiloto();

            obj.Visible = true;

            Visible = false;
        }

        private void btnBitaTrans_MouseClick(object sender, MouseEventArgs e)
        {
            frmBitacoraTransporte obj = new frmBitacoraTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void lblBitaTrans_MouseClick(object sender, MouseEventArgs e)
        {
            frmBitacoraTransporte obj = new frmBitacoraTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void picIconoBitaTrans_MouseClick(object sender, MouseEventArgs e)
        {
            frmBitacoraTransporte obj = new frmBitacoraTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void btnPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverUbicacion;
        }

        private void lblPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverUbicacion;
        }

        private void picIconoPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverUbicacion;
        }

        private void btnPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalUbicacion;
        }

        private void lblPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalUbicacion;
        }

        private void picIconoPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalUbicacion;
        }

        private void btnBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverUbicacion;
        }

        private void lblBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverUbicacion;
        }

        private void picIconoBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverUbicacion;
        }

        private void btnBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalUbicacion;
        }

        private void lblBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalUbicacion;
        }

        private void picIconoBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalUbicacion;
        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pnlPD_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteDetalle obj = new frmPaqueteDetalle();
            obj.Visible = true;
            Visible = false;
        }

        private void pnlPD_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverUbicacion;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalUbicacion;
        }

        private void pnlTrans_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
            obj.Visible = true;
            Visible = false;

        }

        private void pnlTrans_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverUbicacion;
        }

        private void pnlTrans_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalUbicacion;
        }

        private void btnInventario_MouseClick(object sender, MouseEventArgs e)
        {
            frmInventario obj = new frmInventario();
            obj.Visible = true;
            Visible = false;
        }

        private void btnInventario_MouseHover(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorHoverUbicacion;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorNormalUbicacion;
        }
    }
}
