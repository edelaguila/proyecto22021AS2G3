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
    public partial class frmTipoMovimiento : Form
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

        /* Varibles para cambiar color de mi Boton */
        Color colorHoverTM = Color.FromArgb(80, 115, 119);
        Color colorNormalTM = Color.FromArgb(59, 102, 107);

        /* Codigo para mover mi panel */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmTipoMovimiento()
        {
            InitializeComponent();

            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            /*Partes Iniciales del Form*/
            lblTituloTipoMovimiento.Visible = true;
            lblAbcTipoMovimiento.Visible = true;
            pnlBordeTipoMovimiento.Visible = false;

            lblRegistrarCliente.Visible = false;
            pnlBordeRegistrar.Visible = false;
            lblModificarCliente.Visible = false;
            pnlBordeModificar.Visible = false;
            lblDarBaja.Visible = false;
            pnlBordeDarBaja.Visible = false;
            /*Partes Iniciales del Form*/

            /*Inicio, ocultar contenidos del form ubicacion*/
            pnlCampoIdMovimiento.Visible = false;
            pnlNombreTipoMov.Visible = false;
            pnlEstatusTM.Visible = false;
            txtBuscarTM.Visible = false;
            pnlBotonBuscarTM.Visible = false;
            dgvTipoMovimiento.Visible = false;
            pnlBotonGuardarU.Visible = false;
            pnlModificarTM.Visible = false;
            pnlActivarTM.Visible = false;
            pnlDarBajaTM.Visible = false;
            pnlLlenarCamposTMDB.Visible = false;
            pnlLLenarCamposTM.Visible = false;
            /*Inicio, ocultar contenidos del form ubicacion*/

            /*Habilitando contenido*/

            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;

        }

        private void frmTipoMovimiento_Load(object sender, EventArgs e)
        {

        }

        private void frmTipoMovimiento_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverTM;
        }

        private void lblCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal tmov = new frmPrincipal();
            tmov.Visible = true;

            Visible = false;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverTM;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverTM;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalTM;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalTM;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalTM;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverTM;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverTM;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverTM;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalTM;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalTM;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalTM;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverTM;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverTM;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverTM;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalTM;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalTM;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalTM;
        }

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverTM;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverTM;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverTM;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalTM;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalTM;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalTM;
        }

        private void btnTipoEmpleado_MouseHover(object sender, EventArgs e)
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

        private void lblTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void picTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal tmov = new frmPrincipal();
            tmov.Visible = true;

            Visible = false;
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void picIconoCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal tmov = new frmPrincipal();
            tmov.Visible = true;

            Visible = false;
        }

        private void btnPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos tmov = new frmPuestos();
            tmov.Visible = true;

            Visible = false;
        }

        private void lblPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos tmov = new frmPuestos();
            tmov.Visible = true;

            Visible = false;
        }

        private void picPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos tmov = new frmPuestos();
            tmov.Visible = true;

            Visible = false;
        }

        private void btnDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento tmov = new frmDepartamento();
            tmov.Visible = true;

            Visible = false;
        }

        private void lblDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento tmov = new frmDepartamento();
            tmov.Visible = true;

            Visible = false;
        }

        private void picDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento tmov = new frmDepartamento();
            tmov.Visible = true;

            Visible = false;
        }

        private void btnUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion tmov = new frmUbicacion();
            tmov.Visible = true;

            Visible = false;
        }

        private void lblUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion tmov = new frmUbicacion();
            tmov.Visible = true;

            Visible = false;
        }

        private void picIconoUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion tmov = new frmUbicacion();
            tmov.Visible = true;

            Visible = false;
        }

        private void btnTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void lblTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void picTipoEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void picTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void lblTituloCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblAbcTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeTipoMovimiento.Visible = true;

            lblRegistrarCliente.Visible = true;
            lblModificarCliente.Visible = true;
            lblDarBaja.Visible = true;
        }

        private void lblRegistrarCliente_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = true;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = false;
            funCargarTabla(null);
            funVaciarCampos();


            /*Inicio, ocultar contenidos del form ubicacion*/
            pnlCampoIdMovimiento.Visible = true;
            pnlNombreTipoMov.Visible = true;
            pnlEstatusTM.Visible = false;
            txtBuscarTM.Visible = true;
            pnlBotonBuscarTM.Visible = true;
            dgvTipoMovimiento.Visible = true;
            pnlBotonGuardarU.Visible = true;
            pnlModificarTM.Visible = false;
            pnlActivarTM.Visible = false;
            pnlDarBajaTM.Visible = false;
            pnlLlenarCamposTMDB.Visible = false;
            pnlLLenarCamposTM.Visible = true;
            /*Fin, ocultar contenidos del form ubicacion*/

            /*Inicio, Habilitando campos*/
            pnlCampoIdMovimiento.Enabled = true;
            pnlNombreTipoMov.Enabled = true;
            pnlEstatusTM.Enabled = false;
            txtBuscarTM.Enabled = true;
            pnlBotonBuscarTM.Enabled = true;
            dgvTipoMovimiento.Enabled = true;
            /*Fin, Habilitando campos*/
        }

        private void lblModificarCliente_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = true;
            pnlBordeDarBaja.Visible = false;

            funCargarTabla(null);
            funVaciarCampos();

            /*Inicio, ocultar contenidos del form ubicacion*/
            pnlCampoIdMovimiento.Visible = true;
            pnlNombreTipoMov.Visible = true;
            pnlEstatusTM.Visible = false;
            txtBuscarTM.Visible = true;
            pnlBotonBuscarTM.Visible = true;
            dgvTipoMovimiento.Visible = true;
            pnlBotonGuardarU.Visible = false;
            pnlModificarTM.Visible = true;
            pnlActivarTM.Visible = false;
            pnlDarBajaTM.Visible = false;
            pnlLlenarCamposTMDB.Visible = false;
            pnlLLenarCamposTM.Visible = true;
            /*Fin, ocultar contenidos del form ubicacion*/

            /*Inicio, Habilitando campos*/
            pnlCampoIdMovimiento.Enabled = false;
            pnlNombreTipoMov.Enabled = true;
            pnlEstatusTM.Enabled = false;
            txtBuscarTM.Enabled = true;
            pnlBotonBuscarTM.Enabled = true;
            dgvTipoMovimiento.Enabled = true;
            /*Fin, Habilitando campos*/
        }

        private void lblDarBaja_MouseClick(object sender, MouseEventArgs e)
        {
            funCargarTabla(null);
            funVaciarCampos();

            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = true;

            /*Inicio, ocultar contenidos del form ubicacion*/
            pnlCampoIdMovimiento.Visible = true;
            pnlNombreTipoMov.Visible = true;
            pnlEstatusTM.Visible = true;
            txtBuscarTM.Visible = true;
            pnlBotonBuscarTM.Visible = true;
            dgvTipoMovimiento.Visible = true;
            pnlBotonGuardarU.Visible = false;
            pnlModificarTM.Visible = false;
            pnlActivarTM.Visible = false;
            pnlDarBajaTM.Visible = false;
            pnlLlenarCamposTMDB.Visible = true;
            pnlLLenarCamposTM.Visible = false;
            /*Fin, ocultar contenidos del form ubicacion*/

            /*Inicio, Habilitando campos*/
            pnlCampoIdMovimiento.Enabled = false;
            pnlNombreTipoMov.Enabled = false;
            pnlEstatusTM.Enabled = false;
            txtBuscarTM.Enabled = true;
            pnlBotonBuscarTM.Enabled = true;
            dgvTipoMovimiento.Enabled = true;
            /*Fin, Habilitando campos*/
        }

        private void pnlBotonGuardarU_MouseClick(object sender, MouseEventArgs e)
        {
            /* Funcion insertar una TipoMovimiento */
            
            if (txtIdTipoMovimiento.Text =="" || txtTipoMovimiento.Text == "")
            {
                MessageBox.Show("No se pueden dejar campos vacios ","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String estatusTipoMovimiento = "A";
                TipoMovimiento tipoM = funObtenerTxt(estatusTipoMovimiento);
                tipoM.funcInsertar();
                /* Final funcion insertar una TipoMovimiento */
                funCargarTabla(null);
                funVaciarCampos();
            }
            
        }

        private void funVaciarCampos()
        {
            txtIdTipoMovimiento.Text = "";
            txtTipoMovimiento.Text = "";
            txtEstatusTM.Text = "";
            txtBuscarTM.Text = "";
        } 

        private void funCargarTabla(string dato)
        {
            //List<TipoMovimiento> lista = new List<TipoMovimiento>();
            TipoMovimiento tipoM = new TipoMovimiento();

            dgvTipoMovimiento.DataSource = tipoM.consulta(dato);
        }

        /* Inicio de funcion para evitar el uso de recursivo de tantas variables */
        public TipoMovimiento funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC Ubicacion */
            String pCodigoTM = txtIdTipoMovimiento.Text;
            String pNombreTM = txtTipoMovimiento.Text;
            /*Final obteniedo variables a usar con mi ABC Ubicacion */

            /* Inicio creamos un objeto de tipo Ubicacion para poder utilizar el metodo de insertar ubicacion */
            TipoMovimiento ubicacion = new TipoMovimiento(pCodigoTM, pNombreTM, estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar ubicacion */

            return ubicacion;
        }

        private void pnlLLenarCamposTM_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdTipoMovimiento.Text = dgvTipoMovimiento.CurrentRow.Cells[0].Value.ToString();
            txtTipoMovimiento.Text = dgvTipoMovimiento.CurrentRow.Cells[1].Value.ToString();
            txtEstatusTM.Text = dgvTipoMovimiento.CurrentRow.Cells[2].Value.ToString();
        }

        private void pnlModificarTM_MouseClick(object sender, MouseEventArgs e)
        {
            //String estatusUbicacion = "A";
            //String idUbicacion = txtIdUbicacion.Text;
            //Ubicacion ubicacion = funObtenerTxt(estatusUbicacion);

            //ubicacion.funModificar(idUbicacion);
            //funCargarTabla(null);
            //ubicacion.funBuscarSetearTxt(txtIdUbicacion, txtNombreUbicacion, txtEstatusUbicacion, idUbicacion);

            String estatusTipoMovimiento = "A";
            String idTipoMovimiento = txtIdTipoMovimiento.Text;
            TipoMovimiento tipoM = funObtenerTxt(estatusTipoMovimiento);
            tipoM.funModificar(idTipoMovimiento);

            funCargarTabla(null);
            funVaciarCampos();

        }

        private void pnlBotonBuscarTM_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarTM = txtBuscarTM.Text;
            funCargarTabla(buscarTM);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();

            pnlDarBajaTM.Visible = false;
            pnlActivarTM.Visible = false;
            /* Final Vaciando los campos */
        }

        private void pnlLlenarCamposTMDB_MouseClick(object sender, MouseEventArgs e)
        {

            txtIdTipoMovimiento.Text = dgvTipoMovimiento.CurrentRow.Cells[0].Value.ToString();
            txtTipoMovimiento.Text = dgvTipoMovimiento.CurrentRow.Cells[1].Value.ToString();
            txtEstatusTM.Text = dgvTipoMovimiento.CurrentRow.Cells[2].Value.ToString();

            TipoMovimiento tipoM = new TipoMovimiento();
            String pidTipoMovimiento = txtIdTipoMovimiento.Text;
            String pestatusTipoMovimiento = tipoM.funBuscarEstatus(pidTipoMovimiento);

            if (pestatusTipoMovimiento == "A")
            {
                pnlActivarTM.Visible = false;
                pnlDarBajaTM.Visible = true;
            }
            else if (pestatusTipoMovimiento == "I")
            {
                pnlDarBajaTM.Visible = false;
                pnlActivarTM.Visible = true;
            }
        }

        private void pnlActivarTM_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdTipoMov = txtIdTipoMovimiento.Text;
            TipoMovimiento tipoM = funObtenerTxt(estatus);

            tipoM.funActivarTipoMov();
            funCargarTabla(null);

            pnlDarBajaTM.Visible = true;
            pnlActivarTM.Visible = false;

            tipoM.funBuscarSetearTxt(txtIdTipoMovimiento, txtTipoMovimiento, txtEstatusTM, pIdTipoMov);
        }

        private void pnlDarBajaTM_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdTipoMov = txtIdTipoMovimiento.Text;
            TipoMovimiento tipoMov = funObtenerTxt(estatus);

            tipoMov.funBajaTipoMov();
            funCargarTabla(null);

            pnlActivarTM.Visible = true;
            pnlDarBajaTM.Visible = false;

            tipoMov.funBuscarSetearTxt(txtIdTipoMovimiento, txtTipoMovimiento, txtEstatusTM, pIdTipoMov);
        }

        private void picTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorHoverTM;
        }

        private void picTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorNormalTM;
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta tipoM = new frmRuta();
            tipoM.Visible = true;

            Visible = false;
        }

        private void btnRuta(object sender, MouseEventArgs e)
        {
            frmRuta tipoM = new frmRuta();
            tipoM.Visible = true;

            Visible = false;
        }

        private void label15_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta ruta = new frmRuta();
            ruta.Visible = true;

            Visible = false;
        }

        private void btnRuta__MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta ruta = new frmRuta();
            ruta.Visible = true;

            Visible = false;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta ruta = new frmRuta();
            ruta.Visible = true;

            Visible = false;
        }

        private void btnTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btnRuta__MouseHover(object sender, EventArgs e)
        {
            btnRuta_.BackColor = colorHoverTM;
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            btnRuta_.BackColor = colorHoverTM;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            btnRuta_.BackColor = colorHoverTM;
        }

        private void btnRuta__MouseLeave(object sender, EventArgs e)
        {
            btnRuta_.BackColor = colorNormalTM;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            btnRuta_.BackColor = colorNormalTM;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            btnRuta_.BackColor = colorNormalTM;
        }

        private void btnTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorHoverTM;
        }

        private void lblTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorHoverTM;
        }

        private void picTipoMovimiento_MouseHover_1(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorHoverTM;
        }

        private void btnTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorNormalTM;
        }

        private void lblTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorNormalTM;
        }

        private void picTipoMovimiento_MouseLeave_1(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorNormalTM;
        }

        private void pnlSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion sub = new frmSubUbicacion();
            sub.Visible = true;

            Visible = false;
        }

        private void lblSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion sub = new frmSubUbicacion();
            sub.Visible = true;

            Visible = false;
        }

        private void picSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion sub = new frmSubUbicacion();
            sub.Visible = true;

            Visible = false;
        }

        private void pnlSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverTM;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverTM;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverTM;
        }

        private void btnSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalTM;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalTM;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalTM;
        }

        private void btnTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte objTipoT = new frmTipoTransporte();

            objTipoT.Visible = true;
            Visible = false;
        }

        private void frmTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverTM;

        }

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalTM;
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverTM;
        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalTM;
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverTM;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalTM;
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

        private void btnPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverTM;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverTM;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverTM;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalTM;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalTM;
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalTM;
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
            btnBodega.BackColor = colorHoverTM;
        }

        private void lblBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverTM;
        }

        private void picBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverTM;
        }

        private void pnlEmpleado_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverTM;
        }

        private void label15_MouseHover_1(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverTM;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverTM;
        }

        private void btnBodega_MouseLeave(object sender, EventArgs e)
        {

            btnBodega.BackColor = colorNormalTM;
        }

        private void lblBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalTM;
        }

        private void picBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalTM;
        }

        private void pnlEmpleado_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalTM;
        }

        private void label15_MouseLeave_1(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalTM;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalTM;
        }

        private void label15_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverTM;
        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalTM;
        }

        private void lblEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverTM;
        }

        private void lblEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalTM;
        }

        private void picEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverTM;
        }

        private void picEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalTM;
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

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

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
            pnlPD.BackColor = colorHoverTM;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalTM;
        }

        private void btnInventario_MouseClick(object sender, MouseEventArgs e)
        {
            frmInventario obj = new frmInventario();
            obj.Visible = true;
            Visible = false;
        }

        private void btnInventario_MouseHover(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorHoverTM;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorNormalTM;
        }

        private void pnlTrans_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
            obj.Visible = true;
            Visible = false;
        }

        private void pnlTrans_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverTM;
        }

        private void pnlTrans_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalTM;
        }
    }
    
}
