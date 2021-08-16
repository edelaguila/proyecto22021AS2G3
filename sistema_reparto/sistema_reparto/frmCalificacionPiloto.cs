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
    public partial class frmCalificacionPiloto : Form
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
        Color colorHoverCalificacion = Color.FromArgb(80, 115, 119);
        Color colorNormalCalificacion = Color.FromArgb(59, 102, 107);


        public frmCalificacionPiloto()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //Llamando combobox
            CalificacionPiloto calificacion = new CalificacionPiloto();
            calificacion.cargarCombobox(cbxPiloto, "piloto", "idPiloto", "nombrePiloto");
            calificacion.cargarCombobox(cbxPaqueteEnc, "paqueteEncabezado", "idPaqueteEncabezado", "idPaqueteEncabezado");
            calificacion.cargarCombobox(cbxCliente, "cliente", "idCliente", "nombreCliente");
            calificacion.cargarCombobox(cbxIdEmpleado, "empleado", "idEmpleado", "nombreEmpleado");

            /*Componentes Iniciales*/
            lblTituloCalificacion.Visible = true;
            lblAbcCalificacion.Visible = true;
            pnlBordeCalificacion.Visible = false;

            lblRegistrarCalificacion.Visible = false;
            lblModificarCalificacion.Visible = false;
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;
            

            /*Habilitando componentes*/
            pnlIdIDC.Visible = false;
            pnlIdPiloto.Visible = false;
            pnlIdPaqueteEnc.Visible = false;
            pnlIdCliente.Visible = false;
            pnlIdEmpleado.Visible = false;
            pnlFecha.Visible = false;
            pnlLlegadaTardia.Visible = false;
            pnlLlegadaTiempo.Visible = false;
            pnlPercances.Visible = false;
            pnlRetrazos.Visible = false;
            pnlObservaciones.Visible = false;
            txtBuscarCalificacion.Visible = false;

            pnlBotonCalificacion.Visible = false;
            dgvCalificacion.Visible = false;
            
            pnlLLenarCamposC.Visible = false;
       
            pnlModificarC.Visible = false;
            pnlBotonGuardarC.Visible = false;
            /*Fin habilitando componentes*/

            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;

        }

        private void frmCalificacionPiloto_Load(object sender, EventArgs e)
        {

        }

        private void frmCalificacionPiloto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblAbcCalificacion_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void lblAbcCalificacion_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeCalificacion.Visible = true;

            lblRegistrarCalificacion.Visible = true;
            lblModificarCalificacion.Visible = true;
            
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;
            

        }

        private void lblRegistrarCalificacion_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = true;
            pnlBordeModificar.Visible = false;

            funCargarTabla(null);
            funVaciarCampos();

            /*Habilitando componentes*/
            pnlIdIDC.Visible = true;
            pnlIdPiloto.Visible = true;
            pnlIdPaqueteEnc.Visible = true;
            pnlIdCliente.Visible = true;
            pnlIdEmpleado.Visible = true;
            pnlFecha.Visible = true;
            pnlLlegadaTardia.Visible = true;
            pnlLlegadaTiempo.Visible = true;
            pnlPercances.Visible = true;
            pnlRetrazos.Visible = true;
            pnlObservaciones.Visible = true;
            txtBuscarCalificacion.Visible = true;

            pnlBotonCalificacion.Visible = true;
            dgvCalificacion.Visible = true;
            
            pnlLLenarCamposC.Visible = true;
            
            pnlModificarC.Visible = false;
            pnlBotonGuardarC.Visible = true;
            /*Fin habilitando componentes*/

            /*Habilitando componentes*/
            pnlIdIDC.Enabled = true ;
            pnlIdPiloto.Enabled = true;
            pnlIdPaqueteEnc.Enabled = true;
            pnlIdCliente.Enabled = true;
            pnlIdEmpleado.Enabled = true;
            pnlFecha.Enabled = true;
            pnlLlegadaTardia.Enabled = true;
            pnlLlegadaTiempo.Enabled = true;
            pnlPercances.Enabled = true;
            pnlRetrazos.Enabled = true;
            pnlObservaciones.Enabled = true;
            txtBuscarCalificacion.Enabled = true;

            /*Fin habilitando componentes*/
        }

        private void lblModificarCalificacion_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = true;

            funCargarTabla(null);
            funVaciarCampos();

            /*Habilitando componentes*/
            pnlIdIDC.Visible = true;
            pnlIdPiloto.Visible = true;
            pnlIdPaqueteEnc.Visible = true;
            pnlIdCliente.Visible = true;
            pnlIdEmpleado.Visible = true;
            pnlFecha.Visible = true;
            pnlLlegadaTardia.Visible = true;
            pnlLlegadaTiempo.Visible = true;
            pnlPercances.Visible = true;
            pnlRetrazos.Visible = true;
            pnlObservaciones.Visible = true;
            txtBuscarCalificacion.Visible = true;

            pnlBotonCalificacion.Visible = true;
            dgvCalificacion.Visible = true;
            
            pnlLLenarCamposC.Visible = true;

            pnlModificarC.Visible = true;
            pnlBotonGuardarC.Visible = false;
            /*Fin habilitando componentes*/

            /*Habilitando componentes*/
            pnlIdIDC.Enabled = false;
            pnlIdPiloto.Enabled = true;
            pnlIdPaqueteEnc.Enabled = true;
            pnlIdCliente.Enabled = true;
            pnlIdEmpleado.Enabled = true;
            pnlFecha.Enabled = true;
            pnlLlegadaTardia.Enabled = true;
            pnlLlegadaTiempo.Enabled = true;
            pnlPercances.Enabled = true;
            pnlRetrazos.Enabled = true;
            pnlObservaciones.Enabled = true;
            txtBuscarCalificacion.Enabled = true;
            /*Fin habilitando componentes*/
        }

        private void lblEliminar_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;
            
        }

        private void label18_Click(object sender, EventArgs e)
        {

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

        private void picDepartamento_DoubleClick(object sender, EventArgs e)
        {

        }

        private void picDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento obj = new frmDepartamento();
            obj.Visible = true;

            Visible = false;
        }

        private void btnUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion obj = new frmUbicacion();
            obj.Visible = true;

            Visible = false;
        }

        private void lblUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion obj = new frmUbicacion();
            obj.Visible = true;

            Visible = false;
        }

        private void picIconoUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion obj = new frmUbicacion();
            obj.Visible = true;

            Visible = false;
        }

        private void btnRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta obj = new frmRuta();
            obj.Visible = true;

            Visible = false;
        }

        private void lblRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta obj = new frmRuta();
            obj.Visible = true;

            Visible = false;
        }

        private void picRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta obj = new frmRuta();
            obj.Visible = true;

            Visible = false;
        }

        private void btnSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion obj = new frmSubUbicacion();
            obj.Visible = true;

            Visible = false;
        }

        private void lblSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion obj = new frmSubUbicacion();
            obj.Visible = true;

            Visible = false;
        }

        private void picSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion obj = new frmSubUbicacion();
            obj.Visible = true;

            Visible = false;
        }

        private void btnTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoMovimiento obj = new frmTipoMovimiento();
            obj.Visible = true;

            Visible = false;
        }

        private void lblTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoMovimiento obj = new frmTipoMovimiento();
            obj.Visible = true;

            Visible = false;
        }

        private void picTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoMovimiento obj = new frmTipoMovimiento();
            obj.Visible = true;

            Visible = false;
        }

        private void btnTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte obj = new frmTipoTransporte();
            obj.Visible = true;

            Visible = false;
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
            frmUsuarios obj = new frmUsuarios();
            obj.Visible = true;

            Visible = false;
        }

        private void lblUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios obj = new frmUsuarios();
            obj.Visible = true;

            Visible = false;
        }

        private void picIconoUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios obj = new frmUsuarios();
            obj.Visible = true;

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

        private void pnlEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();
            obj.Visible = true;

            Visible = false;
        }

        private void label15_MouseClick(object sender, MouseEventArgs e)
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

        private void btnBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmBodega obj = new frmBodega();
            obj.Visible = true;

            Visible = false;
        }

        private void lblBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmBodega obj = new frmBodega();
            obj.Visible = true;

            Visible = false;
        }

        private void picBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmBodega obj = new frmBodega();
            obj.Visible = true;

            Visible = false;
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

        private void pnlPD_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteDetalle obj = new frmPaqueteDetalle();
            obj.Visible = true;

            Visible = false;
        }

        private void lblPaqDet_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteDetalle obj = new frmPaqueteDetalle();
            obj.Visible = true;

            Visible = false;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteDetalle obj = new frmPaqueteDetalle();
            obj.Visible = true;

            Visible = false;
        }

        private void pnlTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
            obj.Visible = true;

            Visible = false;
        }

        private void lblTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
            obj.Visible = true;

            Visible = false;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
            obj.Visible = true;

            Visible = false;
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverCalificacion;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverCalificacion;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverCalificacion;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalCalificacion;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalCalificacion;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverCalificacion;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverCalificacion;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverCalificacion;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalCalificacion;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalCalificacion;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalCalificacion;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverCalificacion;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverCalificacion;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverCalificacion;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalCalificacion;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalCalificacion;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalCalificacion;
        }

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverCalificacion;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverCalificacion;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverCalificacion;
        }

        private void btnTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverCalificacion;
        }

        private void lblRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverCalificacion;
        }

        private void picRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverCalificacion;
        }

        private void btnRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalCalificacion;
        }

        private void picRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalCalificacion;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalCalificacion;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalCalificacion;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalCalificacion;
        }

        private void btnSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverCalificacion;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverCalificacion;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverCalificacion;
        }

        private void btnSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalCalificacion;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalCalificacion;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalCalificacion;
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

        private void btnTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverCalificacion;
            
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverCalificacion; 
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverCalificacion;
        }

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalCalificacion;
        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalCalificacion;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalCalificacion;
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverCalificacion;
        }

        private void lblUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverCalificacion;
        }

        private void picIconoUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverCalificacion;
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalCalificacion; 
        }

        private void lblUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalCalificacion;
        }

        private void picIconoUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalCalificacion;
        }

        private void btnPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverCalificacion;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverCalificacion;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e) {

            btnPaqueteEncabezado.BackColor = colorHoverCalificacion; 
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalCalificacion;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalCalificacion;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalCalificacion;
        }

        private void pnlEmpleado_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverCalificacion;
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverCalificacion;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverCalificacion;
        }

        private void pnlEmpleado_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalCalificacion;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalCalificacion;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalCalificacion;
        }

        private void btnBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverCalificacion; ;
        }

        private void btnBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalCalificacion;
        }

        private void lblBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverCalificacion;
        }

        private void picBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverCalificacion; 
        }

        private void lblBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverCalificacion;
        }

        private void picBodega_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverCalificacion;
        }

        private void pnlEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverCalificacion;
        }

        private void lblEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverCalificacion;
        }

        private void picEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverCalificacion;
        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalCalificacion;
        }

        private void lblEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalCalificacion;
        }

        private void picEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalCalificacion;
        }

        private void pnlPD_MouseHover(object sender, EventArgs e)
        {

            pnlPD.BackColor = colorHoverCalificacion;
        }

        private void lblPaqDet_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverCalificacion;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverCalificacion;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalCalificacion; 
        }

        private void lblPaqDet_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalCalificacion;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalCalificacion;
        }

        private void pnlTransporte_MouseHover(object sender, EventArgs e)
        {
            pnlTransporte.BackColor = colorHoverCalificacion;
        }

        private void lblTransporte_MouseHover(object sender, EventArgs e)
        {
            pnlTransporte.BackColor = colorHoverCalificacion;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pnlTransporte.BackColor = colorHoverCalificacion;
        }

        private void lblTransporte_MouseLeave(object sender, EventArgs e)
        {
            pnlTransporte.BackColor = colorNormalCalificacion;
        }

        private void pnlTransporte_MouseLeave(object sender, EventArgs e)
        {
            pnlTransporte.BackColor = colorNormalCalificacion;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pnlTransporte.BackColor = colorNormalCalificacion;
        }

        private void lblCalificacion_MouseHover(object sender, EventArgs e)
        {
            pnlTransporte.BackColor = colorHoverCalificacion; 
        }

        private void btnCalificacionP_MouseHover(object sender, EventArgs e)
        {
            pnlTransporte.BackColor = colorNormalCalificacion;
        }

        private void pnlBotonGuardarC_MouseClick(object sender, MouseEventArgs e)
        {
            //String eodega = "A";
            CalificacionPiloto calificacion = funObtenerTxt();
            calificacion.funInsertar();
            /* Final de ejecucion de funcion insertar un cliente */

            funCargarTabla(null);
            funVaciarCampos();
        }

        public CalificacionPiloto funObtenerTxt()
        {
            /*Inicio obteniedo variables a usar con mi ABC cliente */
            String idCalificacion = txtIdCalificacion.Text;
            String idPiloto = cbxPiloto.SelectedValue.ToString();
            String idPaqueteE = cbxPaqueteEnc.SelectedValue.ToString();
            String idCliente = cbxCliente.SelectedValue.ToString();
            String idEmpleado = cbxIdEmpleado.SelectedValue.ToString();
            String fechaRecep = dtpFechaRecepcion.Value.ToString("yyyy-MM-dd");

            String llegadaTardia = "";

            if(chbLlegadaT.Checked == true)
            {
                llegadaTardia = "1";
            }
            else
            {
                llegadaTardia = "0";
            }

            String llegadaTiempo = "";

            if (chbLlegadaTiempo.Checked == true)
            {
                llegadaTiempo = "1";
            }
            else
            {
                llegadaTiempo = "0";
            }

            String percances = "";

            if (chbPercances.Checked == true)
            {
                percances = "1";
            }
            else
            {
                percances = "0";
            }

            String retrazos = "";

            if (chbRetrazos.Checked == true)
            {
                retrazos ="1";
            }
            else
            {
                retrazos = "0";
            }

            String observaciones = richObservaciones.Text;

            /*Final obteniedo variables a usar con mi ABC */

            CalificacionPiloto calificacion = new CalificacionPiloto(idCalificacion, idPiloto, idPaqueteE, idCliente, idEmpleado, fechaRecep, llegadaTardia, llegadaTiempo, percances, retrazos, observaciones);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */

            return calificacion;
        }

        private void funCargarTabla(string dato)
        {
            List<CalificacionPiloto> lista = new List<CalificacionPiloto>();
            CalificacionPiloto calificacion = new CalificacionPiloto();

            dgvCalificacion.DataSource = calificacion.consulta(dato);
        }

        public void funVaciarCampos()
        {
            txtIdCalificacion.Text = "";
            dtpFechaRecepcion.ResetText();
            chbLlegadaT.Checked = false;
            chbLlegadaTiempo.Checked = false;
            chbPercances.Checked = false;
            chbRetrazos.Checked = false;
        }

        private void pnlLLenarCamposC_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();
            //traer los campos desde la tabla
            txtIdCalificacion.Text = dgvCalificacion.CurrentRow.Cells[0].Value.ToString();

            String idPiloto = dgvCalificacion.CurrentRow.Cells[1].Value.ToString();

            /*Obteniendo Nombre piloto*/
            CalificacionPiloto calificacion = new CalificacionPiloto();
            calificacion.obtenerNombrePiloto(idPiloto);
            cbxPiloto.SelectedValue = idPiloto;

            cbxPaqueteEnc.SelectedValue = dgvCalificacion.CurrentRow.Cells[2].Value.ToString();

            /*Obteniendo Nombre de Cliente*/
            String idCliente = dgvCalificacion.CurrentRow.Cells[3].Value.ToString();
            
            calificacion.obtenerNombreCliente(idCliente);
            cbxCliente.SelectedValue = idCliente;

            /*Obteniendo Nombre de Empleado*/
            String idEmpleado = dgvCalificacion.CurrentRow.Cells[4].Value.ToString();
            
            calificacion.obtenerNombreEmpleado(idEmpleado);
            cbxIdEmpleado.SelectedValue = idEmpleado;

            /*Fecha Recepcion*/
            dtpFechaRecepcion.Value = Convert.ToDateTime(dgvCalificacion.CurrentRow.Cells[5].Value.ToString());

            /*Llegada Tardía*/
            String llegadaTardia = dgvCalificacion.CurrentRow.Cells[6].Value.ToString();
            if(llegadaTardia.Equals("True"))
            {
                chbLlegadaT.Checked = true;
            }
            else
            {
                chbLlegadaT.Checked = false;
            }

            /*Llegada a Tiempo*/
            String llegadaTiempo = dgvCalificacion.CurrentRow.Cells[7].Value.ToString();
            Console.WriteLine(llegadaTiempo);
            if (llegadaTiempo.Equals("True"))
            {
                chbLlegadaTiempo.Checked = true;
            }
            else
            {
                chbLlegadaTiempo.Checked = false;
            }

            /*percances*/
            String percances = dgvCalificacion.CurrentRow.Cells[8].Value.ToString();
            if (percances.Equals("True"))
            {
                chbPercances.Checked = true;
            }
            else
            {
                chbPercances.Checked = false;
            }

            /*retrasos*/
            String retrasos = dgvCalificacion.CurrentRow.Cells[9].Value.ToString();
            if (retrasos.Equals("True"))
            {
                chbRetrazos.Checked = true;
            }
            else
            {
                chbRetrazos.Checked = false;
            }

            richObservaciones.Text = dgvCalificacion.CurrentRow.Cells[10].Value.ToString();

        }

        private void pnlModificarC_MouseClick(object sender, MouseEventArgs e)
        {
            //String estatus = "A";
            String idCalificacion = txtIdCalificacion.Text;
            CalificacionPiloto calificacion = funObtenerTxt();

            calificacion.funModificar(idCalificacion);
            funCargarTabla(null);

            calificacion.funBuscarSetearTxt(txtIdCalificacion, cbxPiloto, cbxPaqueteEnc, cbxCliente, cbxIdEmpleado, dtpFechaRecepcion, chbLlegadaT, chbLlegadaTiempo, chbPercances, chbRetrazos, richObservaciones, idCalificacion);

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
            btnPiloto.BackColor = colorHoverCalificacion;
        }

        private void lblPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverCalificacion;
        }

        private void picIconoPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverCalificacion;
        }

        private void btnPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalCalificacion;
        }

        private void lblPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalCalificacion;
        }

        private void picIconoPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalCalificacion;
        }

        private void btnBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverCalificacion;
        }

        private void lblBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverCalificacion;
        }

        private void picIconoBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverCalificacion;
        }

        private void btnBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalCalificacion;
        }

        private void lblBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalCalificacion;
        }

        private void picIconoBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalCalificacion;
        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pnlPD_MouseHover_1(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverCalificacion;
        }

        private void pnlPD_MouseLeave_1(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalCalificacion;
        }
    }
}
