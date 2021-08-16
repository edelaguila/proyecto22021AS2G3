using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using sistema_reparto.Clases;

namespace sistema_reparto
{
    public partial class frmSubUbicacion : Form
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
        Color colorHoverSubUbicacion = Color.FromArgb(80, 115, 119);
        Color colorNormalSubUbicacion = Color.FromArgb(59, 102, 107);


        public frmSubUbicacion()
        {
            InitializeComponent();

            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            /*Ocultando campos de mi form SubUbicacion*/
            pnlBordeSubUbicacion.Visible = false;
            lblRegistrarSubUbicacion.Visible = false;
            pnlBordeRegistrarSubUbicacion.Visible = false;
            lblModificarSubUbicacion.Visible = false;
            pnlBordeModificarSubUbicacion.Visible = false;
            lblDarBajaSubUbicacion.Visible = false;
            pnlBordeDarBajaSubUbicacion.Visible = false;
            pnlCampoIdSU.Visible = false;
            lbnIdSubUbicacion.Visible = false;
            txtIdSubUbicacion.Visible = false;
            pnlCampoNombreSU.Visible = false;
            lblNombreSubUbicacion.Visible = false;
            txtNombreSubUbicacion.Visible = false;
            pnlCampoSU.Visible = false;
            lblEstatusSubUbicacion.Visible = false;
            txtEstatusSubUbicacion.Visible = false;
            txtBuscarSubUbicacion.Visible = false;
            pnlBotonBuscarSU.Visible = false;
            dgvSubUbicacion.Visible = false;
            pnlActivarSU.Visible = false;
            pnlDarBajaSU.Visible = false;
            pnlLlenarCamposSUDB.Visible = false;
            pnlLLenarCamposSU.Visible = false;
            pnlModificarSU.Visible = false;
            pnlBotonGuardarSU.Visible = false;

            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;

        }

        private void btnCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal objCliente = new frmPrincipal();

            objCliente.Visible = true;
            Visible = false;
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal objCliente = new frmPrincipal();

            objCliente.Visible = true;
            Visible = false;
        }

        private void picIconoCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal objCliente = new frmPrincipal();

            objCliente.Visible = true;
            Visible = false;
        }

        private void btnPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos objPuesto = new frmPuestos();

            objPuesto.Visible = true;
            Visible = false;
        }

        private void lblPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos objPuesto = new frmPuestos();

            objPuesto.Visible = true;
            Visible = false;
        }

        private void picPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos objPuesto = new frmPuestos();

            objPuesto.Visible = true;
            Visible = false;
        }

        private void btnDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento objDepartamento = new frmDepartamento();

            objDepartamento.Visible = true;
            Visible = false;
        }

        private void lblDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento objDepartamento = new frmDepartamento();

            objDepartamento.Visible = true;
            Visible = false;
        }

        private void picDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento objDepartamento = new frmDepartamento();

            objDepartamento.Visible = true;
            Visible = false;
        }

        private void btnUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion objUbicacion = new frmUbicacion();

            objUbicacion.Visible = true;
            Visible = false;
        }

        private void lblUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion objUbicacion = new frmUbicacion();

            objUbicacion.Visible = true;
            Visible = false;
        }

        private void picIconoUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion objUbicacion = new frmUbicacion();

            objUbicacion.Visible = true;
            Visible = false;
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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion objSubUbicacion = new frmSubUbicacion();

            objSubUbicacion.Visible = true;
            Visible = false;
        }

        private void frmSubUbicacion_Load(object sender, EventArgs e)
        {

        }

        private void frmSubUbicacion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblAbcSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeSubUbicacion.Visible = true;
            lblRegistrarSubUbicacion.Visible = true;
            lblModificarSubUbicacion.Visible = true;
            lblDarBajaSubUbicacion.Visible = true;
        }

        private void lblRegistrarSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio cargando datos en tabla SubUbicacion */
            SubUbicacion subUbicacion = new SubUbicacion();
            funCargarTabla(null);

            /*Activando objetos a utilizar al momento de registrar*/
            pnlBordeRegistrarSubUbicacion.Visible = true;
            pnlCampoIdSU.Visible = true;
            lbnIdSubUbicacion.Visible = true;
            txtIdSubUbicacion.Visible = true;
            pnlCampoNombreSU.Visible = true;
            lblNombreSubUbicacion.Visible = true;
            txtNombreSubUbicacion.Visible = true;
            txtBuscarSubUbicacion.Visible = true;
            pnlBotonBuscarSU.Visible = true;
            dgvSubUbicacion.Visible = true;
            pnlLLenarCamposSU.Visible = true;
            pnlBotonGuardarSU.Visible = true;

            /*Bloqueando objetos que no utilizaremos*/
            pnlModificarSU.Visible = false;
            pnlActivarSU.Visible = false;
            pnlDarBajaSU.Visible = false;
            pnlLlenarCamposSUDB.Visible = false;
            pnlBordeModificarSubUbicacion.Visible = false;

            /*Inicio desabilitando y habilitando contenidos de mi form*/
            pnlCampoIdSU.Enabled = true;
            pnlCampoNombreSU.Enabled = true;
            txtBuscarSubUbicacion.Enabled = true;
            pnlBotonBuscarSU.Enabled = true;
            dgvSubUbicacion.Enabled = true;
            pnlLLenarCamposSU.Enabled = true;

            funVaciarCampos();

            pnlCampoSU.Enabled = true;

        }

    

    /* Inicio funcion para cargar mi tabla de SubUbicacion */
        private void funCargarTabla(string dato)
        {
            List<SubUbicacion> lista = new List<SubUbicacion>();
            SubUbicacion subUbicacion = new SubUbicacion();

            dgvSubUbicacion.DataSource = subUbicacion.consulta(dato);
        }
        /* Final funcion para cargar mi tabla de SubUbicacion */

        private void lblModificarSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            funCargarTabla(null);
            funVaciarCampos();

            pnlBordeModificarSubUbicacion.Visible = true;
            pnlCampoIdSU.Visible = true;
            lbnIdSubUbicacion.Visible = true;
            txtIdSubUbicacion.Visible = true;
            pnlCampoNombreSU.Visible = true;
            lblNombreSubUbicacion.Visible = true;
            txtNombreSubUbicacion.Visible = true;
            txtBuscarSubUbicacion.Visible = true;
            pnlBotonBuscarSU.Visible = true;
            dgvSubUbicacion.Visible = true;
            pnlLLenarCamposSU.Visible = true;
            pnlModificarSU.Visible = true;


            pnlBotonGuardarSU.Visible = false;
            pnlActivarSU.Visible = false;
            pnlDarBajaSU.Visible = false;
            pnlLlenarCamposSUDB.Visible = false;
            pnlBordeDarBajaSubUbicacion.Visible = false;
            pnlBordeRegistrarSubUbicacion.Visible = false;

            /*Inicio desabilitando y habilitando contenidos de mi form*/
            pnlCampoIdSU.Enabled = false;
            pnlCampoNombreSU.Enabled = true;
            txtBuscarSubUbicacion.Enabled = true;
            pnlBotonBuscarSU.Enabled = true;
            dgvSubUbicacion.Enabled = true;
            pnlLLenarCamposSU.Enabled = true;

            pnlCampoSU.Visible = false;
        }

        private void lblDarBajaSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            funCargarTabla(null);
            funVaciarCampos();

            lblEstatusSubUbicacion.Visible = true;
            txtEstatusSubUbicacion.Visible = true;
            pnlCampoSU.Visible = true;
            pnlBordeDarBajaSubUbicacion.Visible = true;
            pnlBotonBuscarSU.Visible = true;
            txtBuscarSubUbicacion.Visible = true;
            dgvSubUbicacion.Visible = true;
            pnlCampoNombreSU.Visible = true;
            lblNombreSubUbicacion.Visible = true;
            txtNombreSubUbicacion.Visible = true;
            pnlCampoIdSU.Visible = true;
            lbnIdSubUbicacion.Visible = true;
            txtIdSubUbicacion.Visible = true;
            pnlLlenarCamposSUDB.Visible = true;


            pnlBordeModificarSubUbicacion.Visible = false;
            pnlBordeRegistrarSubUbicacion.Visible = false;
            pnlModificarSU.Visible = false;
            pnlBotonGuardarSU.Visible = false;
            pnlLLenarCamposSU.Visible = false;

            pnlCampoSU.Enabled = false;
            pnlCampoIdSU.Enabled = false;
            pnlCampoNombreSU.Enabled = false;
        }

        /* Inicio de funcion para vaciar mis campos de Puesto */
        public void funVaciarCampos()
        {
            txtIdSubUbicacion.Text = "";
            txtNombreSubUbicacion.Text = "";
            txtEstatusSubUbicacion.Text = "";
            txtBuscarSubUbicacion.Text = "";
        }

        private void dgvSubUbicacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlBotonGuardarSU_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio de ejecucion de funcion insertar un SubUbicacion */

            if (txtIdSubUbicacion.Text == "" || txtNombreSubUbicacion.Text == "")
            {
                MessageBox.Show("No se pueden ingresar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String EstatusSubUbicacion = "A";
                SubUbicacion subUbicacion = funObtenerTxt(EstatusSubUbicacion);
                subUbicacion.funInsertar();
                /* Final de ejecucion de funcion insertar un SubUbicacion */

                funCargarTabla(null);
                funVaciarCampos();
            }
        }

        public SubUbicacion funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC SubUbicacion */
            String pCodigoSU = txtIdSubUbicacion.Text;
            String pNombreSU = txtNombreSubUbicacion.Text;
            /*Final obteniedo variables a usar con mi ABC SubUbicacion */

            /* Inicio creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */
            SubUbicacion subUbicacion = new SubUbicacion(pCodigoSU, pNombreSU, estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */

            return subUbicacion;
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverSubUbicacion;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalSubUbicacion;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverSubUbicacion;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalSubUbicacion;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverSubUbicacion;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalSubUbicacion;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverSubUbicacion;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalSubUbicacion;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverSubUbicacion;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalSubUbicacion;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverSubUbicacion;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalSubUbicacion;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverSubUbicacion;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalSubUbicacion;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverSubUbicacion;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalSubUbicacion;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverSubUbicacion;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalSubUbicacion;
        }

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverSubUbicacion;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalSubUbicacion;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverSubUbicacion;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalSubUbicacion;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverSubUbicacion;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalSubUbicacion;
        }

        private void btnTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void lblTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void lblTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void picTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
           
        }

        

        private void pnlSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalSubUbicacion;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverSubUbicacion;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalSubUbicacion;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverSubUbicacion;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalSubUbicacion;
        }

        private void pnlModificarSU_MouseClick(object sender, MouseEventArgs e)
        {
            String estatusSU = "A";
            String idSU = txtIdSubUbicacion.Text;
            SubUbicacion SU = funObtenerTxt(estatusSU);

            SU.funModificar(idSU);
            funCargarTabla(null);
            SU.funBuscarSetearTxt(txtIdSubUbicacion, txtNombreSubUbicacion, txtEstatusSubUbicacion, idSU);
        }

        private void pnlLLenarCamposSU_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdSubUbicacion.Text = dgvSubUbicacion.CurrentRow.Cells[0].Value.ToString();
            txtNombreSubUbicacion.Text = dgvSubUbicacion.CurrentRow.Cells[1].Value.ToString();
            txtEstatusSubUbicacion.Text = dgvSubUbicacion.CurrentRow.Cells[2].Value.ToString();
        }

        private void pnlLlenarCamposSUDB_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdSubUbicacion.Text = dgvSubUbicacion.CurrentRow.Cells[0].Value.ToString();
            txtNombreSubUbicacion.Text = dgvSubUbicacion.CurrentRow.Cells[1].Value.ToString();
            txtEstatusSubUbicacion.Text = dgvSubUbicacion.CurrentRow.Cells[2].Value.ToString();

            SubUbicacion SU = new SubUbicacion();
            String pidSU = txtIdSubUbicacion.Text;
            String pestatusSU = SU.funBuscarEstatus(pidSU);

            if (pestatusSU == "A")
            {
                pnlActivarSU.Visible = false;
                pnlDarBajaSU.Visible = true;
            }
            else if (pestatusSU == "I")
            {
                pnlDarBajaSU.Visible = false;
                pnlActivarSU.Visible = true;
            }
        }

        private void pnlActivarSU_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdSU = txtIdSubUbicacion.Text;
            SubUbicacion subUbicacion = funObtenerTxt(estatus);

            subUbicacion.funActivarSubUbicacion();
            funCargarTabla(null);

            pnlDarBajaSU.Visible = true;
            pnlActivarSU.Visible = false;

            subUbicacion.funBuscarSetearTxt(txtIdSubUbicacion, txtNombreSubUbicacion, txtEstatusSubUbicacion, pIdSU);
            /*funVaciarCampos();*/
        }

        private void pnlDarBajaSU_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdSU = txtIdSubUbicacion.Text;
            SubUbicacion SU = funObtenerTxt(estatus);

            SU.funDarBajaSubUbicacion();
            funCargarTabla(null);

            pnlActivarSU.Visible = true;
            pnlDarBajaSU.Visible = false;

            SU.funBuscarSetearTxt(txtIdSubUbicacion, txtNombreSubUbicacion, txtEstatusSubUbicacion, pIdSU);
            /*funVaciarCampos();*/
        }

        private void pnlBotonBuscarSU_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarSU = txtBuscarSubUbicacion.Text;
            funCargarTabla(buscarSU);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlDarBajaSU.Visible = false;

            pnlActivarSU.Visible = false;
            /* Final Vaciando los campos */
        }

        private void btnRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta ruta = new frmRuta();
            ruta.Visible = true;

            Visible = false;
        }

        private void label9_MouseClick(object sender, MouseEventArgs e)
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

        private void btnTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoMovimiento tipoM = new frmTipoMovimiento();
            tipoM.Visible = true;

            Visible = false;

        }

        private void lblTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
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
            btnRuta.BackColor = colorHoverSubUbicacion;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            
            btnRuta.BackColor = colorNormalSubUbicacion;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverSubUbicacion;
        }

        private void btnRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalSubUbicacion;
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalSubUbicacion;
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverSubUbicacion;
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

        private void btnTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void lblTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void picTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnTipoTransporte_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte objTipoT = new frmTipoTransporte();

            objTipoT.Visible = true;
            Visible = false;
        }

        private void btnTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverSubUbicacion;
        }

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalSubUbicacion;
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverSubUbicacion;
        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalSubUbicacion;
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverSubUbicacion;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalSubUbicacion;
        }

        private void lblTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte obj = new frmTipoTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void picIconoTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte obj = new frmTipoTransporte();

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

        private void frmSubUbicacion_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverSubUbicacion;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverSubUbicacion;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverSubUbicacion;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalSubUbicacion;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalSubUbicacion;
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalSubUbicacion;
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

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

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
            btnBodega.BackColor = colorHoverSubUbicacion;
        }

        private void lblBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverSubUbicacion;
        }

        private void picBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverSubUbicacion;
        }

        private void btnBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalSubUbicacion;
        }

        private void lblBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalSubUbicacion;
        }

        private void picBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalSubUbicacion;
        }

        private void label14_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverSubUbicacion;
        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalSubUbicacion;
        }

        private void lblEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverSubUbicacion;
        }

        private void lblEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalSubUbicacion;
        }

        private void picEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverSubUbicacion;
        }

        private void picEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalSubUbicacion;
        }

        private void pnlEnvio_MouseClick(object sender, MouseEventArgs e)
        {
            frmEnvio obj = new frmEnvio();

            obj.Visible = true;

            Visible = false;
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
            pnlMovBodega.BackColor = colorHoverSubUbicacion;
        }

        private void lblMovimientoBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverSubUbicacion;
        }

        private void picMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverSubUbicacion;
        }

        private void pnlMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalSubUbicacion;
        }

        private void lblMovimientoBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalSubUbicacion;
        }

        private void picMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalSubUbicacion;
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverSubUbicacion;
        }

        private void lblUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverSubUbicacion;
        }

        private void picIconoUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverSubUbicacion;
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalSubUbicacion;
        }

        private void lblUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalSubUbicacion;
        }

        private void picIconoUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalSubUbicacion;
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
            btnCalificacionP.BackColor = colorHoverSubUbicacion;
        }

        private void lblCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverSubUbicacion;
        }

        private void picCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverSubUbicacion;
        }

        private void btnCalificacionP_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalSubUbicacion;
        }

        private void lblCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalSubUbicacion;
        }

        private void picCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalSubUbicacion;
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
            btnPiloto.BackColor = colorHoverSubUbicacion;
        }

        private void lblPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverSubUbicacion;
        }

        private void picIconoPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverSubUbicacion;
        }

        private void btnPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalSubUbicacion;
        }

        private void lblPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalSubUbicacion;
        }

        private void picIconoPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalSubUbicacion;
        }

        private void btnBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverSubUbicacion;
        }

        private void lblBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverSubUbicacion;
        }

        private void picIconoBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverSubUbicacion;
        }

        private void btnBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalSubUbicacion;
        }

        private void lblBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalSubUbicacion;
        }

        private void picIconoBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalSubUbicacion;
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

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPD_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverSubUbicacion;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalSubUbicacion;
        }

        private void pnlTrans_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
            obj.Visible = true;
            Visible = false;
        }

        private void btnInventario_MouseClick(object sender, MouseEventArgs e)
        {
            frmInventario obj = new frmInventario();
            obj.Visible = true;
            Visible = false;
        }

        private void btnInventario_MouseHover(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorHoverSubUbicacion;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorNormalSubUbicacion;
        }
        /* Final de funcion para evitar el uso de recursivo de tantas variables */
    }
}
