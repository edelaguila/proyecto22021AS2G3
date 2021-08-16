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
    public partial class frmBodega : Form
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
        Color colorHoverBodega = Color.FromArgb(80, 115, 119);
        Color colorNormalBodega = Color.FromArgb(59, 102, 107);

        /* Codigo para mover mi panel */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public frmBodega()
        {
            InitializeComponent();
            
            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            /*Cargando valores en los combobox*/
            Bodega bodega = new Bodega();
            bodega.cargarCombobox(cbxUbicacion, "ubicacion", "idUbicacion", "nombreUbicacion");
            bodega.cargarCombobox(cbxSubUbicacion, "subUbicacion", "idSububicacion", "nombreSubUbicacion");
            bodega.cargarCombobox(cbxIdPaqueteE, "paqueteEncabezado", "idPaqueteEncabezado", "idPaqueteEncabezado");
            bodega.cargarCombobox(cbxIdCliente, "cliente", "idCliente", "nombreCliente");
            bodega.cargarCombobox(cbxIdEmpleado, "empleado", "idEmpleado", "nombreEmpleado");

            /*Habilitar partes iniciales del form*/
            lblTituloBodega.Visible = true;
            lblAbcBodega.Visible = true;

            pnlBordeBodega.Visible = false;
            lblRegistrarBodega.Visible = false;
            pnlBordeRegistrar.Visible = false;
            lblModificarBodega.Visible = false;
            pnlBordeModificar.Visible = false;
            lblDarBaja.Visible = false;
            pnlBordeDarBaja.Visible = false;
            /*Fin, Habilitar partes iniciales del form*/

            /*Ocultando elementos (elementos)*/
            pnlCampoIDB.Visible = false;
            pnlIdUbicacion.Visible = false;
            pnlSubUbicacion.Visible = false;
            pnlIdPaquete.Visible = false;
            pnlCampoIdC.Visible = false;
            pnlcampoIdE.Visible = false;
            pnlCampoEstatus.Visible = false;
            txtBuscarBodega.Visible = false;
            pnlBotonBuscarB.Visible = false;
            dgvBodega.Visible = false;
            pnlLLenarCamposB.Visible = false;
            pnlLlenarCamposCDB.Visible = false;

            pnlBotonGuardarB.Visible = false;
            pnlModificarB.Visible = false;
            pnlActivarB.Visible = false;
            pnlDarBajaB.Visible = false;
            /*Fin Ocultando elementos (elementos)*/

            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;
        }

        private void btnCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();
            obj.Visible = true;

            Visible = false;
        }

        private void frmBodega_Load(object sender, EventArgs e)
        {

        }

        private void frmBodega_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void btnTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void lblTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void picTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
           
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

        private void pnlSubUbicacion_MouseClick(object sender, MouseEventArgs e)
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

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverBodega;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverBodega;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverBodega;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverBodega;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverBodega;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverBodega;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverBodega;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverBodega;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverBodega;
        }

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverBodega;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverBodega;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverBodega;
        }

        private void btnRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverBodega;
        }

        private void lblRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverBodega;
        }

        private void picRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverBodega;
        }

        private void pnlSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverBodega;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverBodega;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverBodega;
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

        private void btnTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverBodega;
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverBodega;
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverBodega;
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverBodega;
        }

        private void lblUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverBodega;
        }

        private void picIconoUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverBodega;
        }

        private void btnPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverBodega;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverBodega;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverBodega;
        }

        private void pnlEmpleado_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverBodega;
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverBodega;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverBodega;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalBodega;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalBodega;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalBodega;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalBodega;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalBodega;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalBodega;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalBodega;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalBodega;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalBodega;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalBodega;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalBodega;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalBodega;
        }

        private void btnRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalBodega;
        }

        private void lblRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalBodega;
        }

        private void picRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalBodega;
        }

        private void btnSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalBodega;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalBodega;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalBodega;
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

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalBodega;
        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalBodega;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalBodega;
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalBodega;
        }

        private void lblUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalBodega;
        }

        private void picIconoUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalBodega;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalBodega;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalBodega;
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalBodega;
        }

        private void pnlEmpleado_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalBodega;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalBodega;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalBodega;
        }

        private void btnBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverBodega;
        }

        private void lblBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverBodega;
        }

        private void picBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverBodega;
        }

        private void btnBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalBodega;
        }

        private void lblBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalBodega;
        }

        private void picBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalBodega;
        }

        private void lblAbcBodega_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeBodega.Visible = true;
            lblRegistrarBodega.Visible = true;
            pnlBordeRegistrar.Visible = false;
            lblModificarBodega.Visible = true;
            pnlBordeModificar.Visible = false;
            lblDarBaja.Visible = true;
            pnlBordeDarBaja.Visible = false;
        }

        private void lblRegistrarBodega_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = true;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = false;

            funCargarTabla(null);
            funVaciarCampos();

            /*Modificando elementos para cada pestaña*/
            pnlCampoIDB.Visible = true;
            pnlIdUbicacion.Visible = true;
            pnlSubUbicacion.Visible = true;
            pnlIdPaquete.Visible = false;
            pnlCampoIdC.Visible = false;
            pnlcampoIdE.Visible = false;
            pnlCampoEstatus.Visible = false;
            txtBuscarBodega.Visible = true;
            pnlBotonBuscarB.Visible = true;
            dgvBodega.Visible = true;
            pnlLLenarCamposB.Visible = true;
            pnlLlenarCamposCDB.Visible = false;

            pnlBotonGuardarB.Visible = true;
            pnlModificarB.Visible = false;
            pnlActivarB.Visible = false;
            pnlDarBajaB.Visible = false;
            /*Fin Modificando elementos para cada pestaña*/

            /*Habilitando elementos para cada pestaña*/
            pnlCampoIDB.Enabled = true;
            pnlIdUbicacion.Enabled = true;
            pnlSubUbicacion.Enabled = true;
            pnlIdPaquete.Enabled = true;
            pnlCampoIdC.Enabled = true;
            pnlcampoIdE.Enabled = true;
            pnlCampoEstatus.Enabled = false;
            txtBuscarBodega.Enabled = true;
            pnlBotonBuscarB.Enabled = true;
            dgvBodega.Enabled = true    ;
            /*Fin habilitando Modificando elementos para cada pestaña*/
        }

        private void lblModificarBodega_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = true;
            pnlBordeDarBaja.Visible = false;

            funCargarTabla(null);
            funVaciarCampos();

            /*Modificando elementos para cada pestaña*/
            pnlCampoIDB.Visible = true;
            pnlIdUbicacion.Visible = true;
            pnlSubUbicacion.Visible = true;
            pnlIdPaquete.Visible = false;
            pnlCampoIdC.Visible = false;
            pnlcampoIdE.Visible = false;
            pnlCampoEstatus.Visible = false;
            txtBuscarBodega.Visible = true;
            pnlBotonBuscarB.Visible = true;
            dgvBodega.Visible = true;
            pnlLLenarCamposB.Visible = true;
            pnlLlenarCamposCDB.Visible = false;

            pnlBotonGuardarB.Visible = false;
            pnlModificarB.Visible = true;
            pnlActivarB.Visible = false;
            pnlDarBajaB.Visible = false;
            /*Fin Modificando elementos para cada pestaña*/

            /*Habilitando elementos para cada pestaña*/
            pnlCampoIDB.Enabled = false;
            pnlIdUbicacion.Enabled = true;
            pnlSubUbicacion.Enabled = true;
            pnlIdPaquete.Enabled = false;
            pnlCampoIdC.Enabled = false;
            pnlcampoIdE.Enabled = false;
            pnlCampoEstatus.Enabled = false;
            txtBuscarBodega.Enabled = true;
            pnlBotonBuscarB.Enabled = true;
            dgvBodega.Enabled = true;
            /*Fin habilitando Modificando elementos para cada pestaña*/
        }

        private void lblDarBaja_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = true;

            funCargarTabla(null);
            funVaciarCampos();

            /*Modificando elementos para cada pestaña*/
            pnlCampoIDB.Visible = true;
            pnlIdUbicacion.Visible = true;
            pnlSubUbicacion.Visible = true;
            pnlIdPaquete.Visible = false;
            pnlCampoIdC.Visible = false;
            pnlcampoIdE.Visible = false;
            pnlCampoEstatus.Visible = true;
            txtBuscarBodega.Visible = true;
            pnlBotonBuscarB.Visible = true;
            dgvBodega.Visible = true;
            pnlLLenarCamposB.Visible = false;
            pnlLlenarCamposCDB.Visible = true;

            pnlBotonGuardarB.Visible = false;
            pnlModificarB.Visible = false;
            pnlActivarB.Visible = false;
            pnlDarBajaB.Visible = false;
            /*Fin Modificando elementos para cada pestaña*/

            /*Habilitando elementos para cada pestaña*/
            pnlCampoIDB.Enabled = false;
            pnlIdUbicacion.Enabled = false;
            pnlSubUbicacion.Enabled = false;
            pnlIdPaquete.Enabled = false;
            pnlCampoIdC.Enabled = false;
            pnlcampoIdE.Enabled = false;
            pnlCampoEstatus.Enabled = false;
            txtBuscarBodega.Enabled = true;
            pnlBotonBuscarB.Enabled = true;
            dgvBodega.Enabled = true;
            /*Fin habilitando Modificando elementos para cada pestaña*/
        }

        private void pnlBotonGuardarB_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio de ejecucion de funcion insertar una bodega */

            if (txtIdBodega.Text == "")
            {
                MessageBox.Show("No se pueden ingresar campos vacios, Todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String estatusBodega = "A";
                Bodega bodega = funObtenerTxt(estatusBodega);
                bodega.funInsertar();
                /* Final de ejecucion de funcion insertar un cliente */

                funCargarTabla(null);
                funVaciarCampos();
            }
        }

        private Bodega funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC Bodega */
            String idBodega = txtIdBodega.Text;
            String idUbicacion = cbxUbicacion.SelectedValue.ToString();
            String idSubUbicacion = cbxSubUbicacion.SelectedValue.ToString();
            
            

            /*Final obteniedo variables a usar con mi ABC */

            /* Inicio creamos un objeto de tipo Bodega para poder utilizar el metodo de insertar */
            Bodega bodega = new Bodega(idBodega, idUbicacion, idSubUbicacion, estatus);
            /* Final creamos un objeto de tipo Bodega para poder utilizar el metodo de insertar  */

            return bodega;
        }

        private void funVaciarCampos()
        {
            txtIdBodega.Text = "";
            //cbxUbicacion.SelectedIndex = 0;
            //cbxSubUbicacion.SelectedIndex = 0;
            //cbxIdPaqueteE.SelectedIndex = 0;
            //cbxIdCliente.SelectedIndex = 0;
            //cbxIdEmpleado.SelectedIndex = 0;
            txtEstatusB.Text = "";
            txtBuscarBodega.Text = "";

        }

        private void funCargarTabla(string dato)
        {
            //List<Bodega> lista = new List<Bodega>();
            Bodega bodega = new Bodega();

            dgvBodega.DataSource = bodega.consulta(dato);
        }

        private void pnlModificarB_MouseClick(object sender, MouseEventArgs e)
        {
            String estatusBodega = "A";
            String idBodega = txtIdBodega.Text;
            Bodega bodega = funObtenerTxt(estatusBodega);

            bodega.funModificar(idBodega);
            funCargarTabla(null);

            bodega.funBuscarSetearTxt(txtIdBodega, cbxUbicacion, cbxSubUbicacion, txtEstatusB, idBodega);

        }

        private void pnlLLenarCamposB_MouseClick(object sender, MouseEventArgs e)
        {
            //traer los campos desde la tabla
            txtIdBodega.Text = dgvBodega.CurrentRow.Cells[0].Value.ToString();

            String idUbicacion = dgvBodega.CurrentRow.Cells[1].Value.ToString();

            /*Obteniendo Nombre de Ubicacion*/
            Bodega bodega = new Bodega();
            bodega.obtenerNombreUbicacion(idUbicacion);
            cbxUbicacion.SelectedValue = idUbicacion;


            String idSubUbicacion = dgvBodega.CurrentRow.Cells[2].Value.ToString();

            /*Obteniendo Nombre de SubUbicacion*/
            bodega.obtenerNombreSubUbicacion(idSubUbicacion);
            cbxSubUbicacion.SelectedValue = idSubUbicacion;

           

            txtEstatusB.Text = dgvBodega.CurrentRow.Cells[3].Value.ToString();

        }

        private void pnlBotonBuscarB_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarPE = txtBuscarBodega.Text;
            funCargarTabla(buscarPE);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlActivarB.Visible = false;
            pnlDarBajaB.Visible = false;
            /* Final Vaciando los campos */
        }

        private void pnlLlenarCamposCDB_MouseClick(object sender, MouseEventArgs e)
        {
            //traer los campos desde la tabla
            txtIdBodega.Text = dgvBodega.CurrentRow.Cells[0].Value.ToString();

            String idUbicacion = dgvBodega.CurrentRow.Cells[1].Value.ToString();

            /*Obteniendo Nombre de Ubicacion*/
            Bodega bodega = new Bodega();
            bodega.obtenerNombreUbicacion(idUbicacion);
            cbxUbicacion.SelectedValue = idUbicacion;


            String idSubUbicacion = dgvBodega.CurrentRow.Cells[2].Value.ToString();

            /*Obteniendo Nombre de SubUbicacion*/
            bodega.obtenerNombreSubUbicacion(idSubUbicacion);
            cbxSubUbicacion.SelectedValue = idSubUbicacion;

            txtEstatusB.Text = dgvBodega.CurrentRow.Cells[3].Value.ToString();


            Bodega pbodega = new Bodega();
            String idBodega = txtIdBodega.Text;
            String EstatusB = pbodega.funBuscarEstatus(idBodega);

            if (EstatusB == "A")
            {
                pnlActivarB.Visible = false;
                pnlDarBajaB.Visible = true;
            }
            else if (EstatusB == "I")
            {
                pnlDarBajaB.Visible = false;
                pnlActivarB.Visible = true;
            }
        }

        private void pnlActivarB_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdBodega = txtIdBodega.Text;
            Bodega bodega = funObtenerTxt(estatus);

            bodega.funActivarCliente();
            funCargarTabla(null);

            pnlDarBajaB.Visible = true;
            pnlActivarB.Visible = false;

            bodega.funBuscarSetearTxt(txtIdBodega, cbxUbicacion, cbxSubUbicacion, txtEstatusB, pIdBodega);

        }

        private void pnlDarBajaB_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdBodega = txtIdBodega.Text;
            Bodega bodega = funObtenerTxt(estatus);

            bodega.funDarBajaBodega();
            funCargarTabla(null);

            pnlDarBajaB.Visible = false;
            pnlActivarB.Visible = true;

            bodega.funBuscarSetearTxt(txtIdBodega, cbxUbicacion, cbxSubUbicacion, txtEstatusB, pIdBodega);

        }

        private void pnlBotonGuardarB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMovBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmMovimientoBodega movBodega = new frmMovimientoBodega();

            movBodega.Visible = true;

            Visible = false;
        }

        private void lblMovimientoBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmMovimientoBodega movBodega = new frmMovimientoBodega();

            movBodega.Visible = true;

            Visible = false;
        }

        private void picMovBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmMovimientoBodega movBodega = new frmMovimientoBodega();

            movBodega.Visible = true;

            Visible = false;
        }

        private void pnlMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverBodega;
        }

        private void lblMovimientoBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverBodega;
        }

        private void picMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverBodega;
        }

        private void pnlMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalBodega;
        }

        private void lblMovimientoBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalBodega;
        }

        private void picMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalBodega;
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

        private void pnlEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverBodega;
        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalBodega;
        }

        private void lblEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalBodega;
        }

        private void lblEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverBodega;
        }

        private void picEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverBodega;
        }

        private void picEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalBodega;
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
            btnCalificacionP.BackColor = colorHoverBodega;
        }

        private void lblCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverBodega;
        }

        private void picCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverBodega;
        }

        private void btnCalificacionP_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalBodega;
        }

        private void lblCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalBodega;
        }

        private void picCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalBodega;
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
            btnPiloto.BackColor = colorHoverBodega;
        }

        private void lblPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverBodega;
        }

        private void picIconoPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverBodega;
        }

        private void btnPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalBodega;
        }

        private void lblPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalBodega;
        }

        private void picIconoPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalBodega;
        }

        private void btnBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverBodega;
        }

        private void lblBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverBodega;
        }

        private void picIconoBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverBodega;
        }

        private void btnBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalBodega;
        }

        private void lblBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalBodega;
        }

        private void picIconoBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalBodega;
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
            pnlPD.BackColor = colorHoverBodega;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalBodega;
        }

        private void pnlTrans_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverBodega;
        }

        private void pnlTrans_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalBodega;
        }

        private void pnlTrans_MouseClick(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
            obj.Visible = true;
            Visible = false;
        }
    }
}
