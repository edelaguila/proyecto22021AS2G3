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
    public partial class frmPiloto : Form
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

        Color colorHoverPiloto = Color.FromArgb(80, 115, 119);
        Color colorNormalPiloto = Color.FromArgb(59, 102, 107);

        public frmPiloto()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            Piloto piloto = new Piloto();
            piloto.funLlenarCombo(cbxIdUser,"usuario", "idUser","nombreUsuario");

            /*Inicio Esconder contenidos de mi form Piloto */
            lblTituloPiloto.Visible = true;
            lblAbcPiloto.Visible = true;
            pnlBordePiloto.Visible = false;
          
            lblRegistrarPiloto.Visible = false;
            pnlBordeRegistrar.Visible = false;
            lblModificarPiloto.Visible = false;
            pnlBordeModificar.Visible = false;
            lblDarBaja.Visible = false;
            pnlBordeDarBaja.Visible = false;
            
            pnlCampoIDPiloto.Visible = false;
            pnlCampoDpiPil.Visible = false;
            pnlCampoIDUser.Visible = false;
            pnlCampoNombrePil.Visible = false;
            pnlCampoApellidoPil.Visible = false;
            pnlCampoTelefonoPil.Visible = false;
            pnlCampoDireccionPil.Visible = false;
            pnlCampoSueldoPil.Visible = false;
            pnlCampoEstatusPil.Visible = false;
            pnlActivarPil.Visible = false;
            pnlDarBajaPil.Visible = false;
            pnlBotonGuardarPil.Visible = false;
            pnlModificarPil.Visible = false;
            txtBuscarPil.Visible = false;
            pnlBotonBuscarPil.Visible = false;
            dgvPiloto.Visible = false;
            pnlLlenarCamposPilDB.Visible = false;
            pnlLLenarCamposPil.Visible = false;
            /*Final Esconder contenidos de mi form Piloto */

            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;
        }

        private void frmPiloto_Load(object sender, EventArgs e)
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

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverPiloto;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverPiloto;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverPiloto;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalPiloto;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalPiloto;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalPiloto;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverPiloto;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverPiloto;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverPiloto;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalPiloto;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalPiloto;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalPiloto;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverPiloto;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverPiloto;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverPiloto;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalPiloto;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalPiloto;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalPiloto;
        }

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverPiloto;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverPiloto;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverPiloto;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalPiloto;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalPiloto;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalPiloto;
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

        private void btnRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverPiloto;
        }

        private void lblRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverPiloto;
        }

        private void picRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverPiloto;
        }

        private void btnRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalPiloto;
        }

        private void lblRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalPiloto;
        }

        private void picRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalPiloto;
        }

        private void pnlSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverPiloto;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverPiloto;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverPiloto;
        }

        private void pnlSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalPiloto;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalPiloto;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalPiloto;
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
            btnTipoTransporte.BackColor = colorHoverPiloto;
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverPiloto;
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverPiloto;
        }

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalPiloto;
        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalPiloto;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalPiloto;
        }

        private void btnPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverPiloto;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverPiloto;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverPiloto;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalPiloto;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalPiloto;
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalPiloto;
        }

        private void btnPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverPiloto;
        }

        private void lblPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverPiloto;
        }

        private void picIconoPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverPiloto;
        }

        private void btnPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalPiloto;
        }

        private void lblPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalPiloto;
        }

        private void picIconoPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalPiloto;
        }

        private void lblAbcPiloto_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordePiloto.Visible = true;
            lblRegistrarPiloto.Visible = true;
            lblModificarPiloto.Visible = true;
            lblDarBaja.Visible = true;
        }

        private void lblRegistrarPiloto_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = true;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = false;

            /*Inicio Esconder y mostrando contenidos de mi form Piloto */
            pnlCampoIDPiloto.Visible = true;
            pnlCampoDpiPil.Visible = true;
            pnlCampoIDUser.Visible = true;
            pnlCampoNombrePil.Visible = true;
            pnlCampoApellidoPil.Visible = true;
            pnlCampoTelefonoPil.Visible = true;
            pnlCampoDireccionPil.Visible = true;
            pnlCampoSueldoPil.Visible = true;
            pnlCampoEstatusPil.Visible = false;
            pnlActivarPil.Visible = false;
            pnlDarBajaPil.Visible = false;
            pnlBotonGuardarPil.Visible = true;
            pnlModificarPil.Visible = false;
            txtBuscarPil.Visible = true;
            pnlBotonBuscarPil.Visible = true;
            dgvPiloto.Visible = true;
            pnlLlenarCamposPilDB.Visible = false;
            pnlLLenarCamposPil.Visible = true;
            /*Final Esconder y mostrando contenidos de mi form Piloto */

            pnlCampoIDPiloto.Enabled = true;
            pnlCampoDpiPil.Enabled = true;
            pnlCampoIDUser.Enabled = true;
            pnlCampoNombrePil.Enabled = true;
            pnlCampoApellidoPil.Enabled = true;
            pnlCampoTelefonoPil.Enabled = true;
            pnlCampoDireccionPil.Enabled = true;
            pnlCampoSueldoPil.Enabled = true;
        }

        private void lblModificarPiloto_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = true;
            pnlBordeDarBaja.Visible = false;

            /*Inicio Esconder y mostrando contenidos de mi form Piloto */
            pnlCampoIDPiloto.Visible = true;
            pnlCampoDpiPil.Visible = true;
            pnlCampoIDUser.Visible = true;
            pnlCampoNombrePil.Visible = true;
            pnlCampoApellidoPil.Visible = true;
            pnlCampoTelefonoPil.Visible = true;
            pnlCampoDireccionPil.Visible = true;
            pnlCampoSueldoPil.Visible = true;
            pnlCampoEstatusPil.Visible = false;
            pnlActivarPil.Visible = false;
            pnlDarBajaPil.Visible = false;
            pnlBotonGuardarPil.Visible = false;
            pnlModificarPil.Visible = true;
            txtBuscarPil.Visible = true;
            pnlBotonBuscarPil.Visible = true;
            dgvPiloto.Visible = true;
            pnlLlenarCamposPilDB.Visible = false;
            pnlLLenarCamposPil.Visible = true;
            /*Final Esconder y mostrando contenidos de mi form Piloto */

            pnlCampoIDPiloto.Enabled = false;
            pnlCampoDpiPil.Enabled = true;
            pnlCampoIDUser.Enabled = true;
            pnlCampoNombrePil.Enabled = true;
            pnlCampoApellidoPil.Enabled = true;
            pnlCampoTelefonoPil.Enabled = true;
            pnlCampoDireccionPil.Enabled = true;
            pnlCampoSueldoPil.Enabled = true;
        }

        private void lblDarBaja_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = true;

            /*Inicio Esconder y mostrando contenidos de mi form Piloto */
            pnlCampoIDPiloto.Visible = true;
            pnlCampoDpiPil.Visible = true;
            pnlCampoIDUser.Visible = true;
            pnlCampoNombrePil.Visible = true;
            pnlCampoApellidoPil.Visible = true;
            pnlCampoTelefonoPil.Visible = true;
            pnlCampoDireccionPil.Visible = true;
            pnlCampoSueldoPil.Visible = true;
            pnlCampoEstatusPil.Visible = true;
            pnlActivarPil.Visible = true;
            pnlDarBajaPil.Visible = true;
            pnlBotonGuardarPil.Visible = false;
            pnlModificarPil.Visible = false;
            txtBuscarPil.Visible = true;
            pnlBotonBuscarPil.Visible = true;
            dgvPiloto.Visible = true;
            pnlLlenarCamposPilDB.Visible = true;
            pnlLLenarCamposPil.Visible = false;
            /*Final Esconder y mostrando contenidos de mi form Piloto */

            pnlCampoIDPiloto.Enabled  = false;
            pnlCampoDpiPil.Enabled = false;
            pnlCampoIDUser.Enabled = false;
            pnlCampoNombrePil.Enabled = false;
            pnlCampoApellidoPil.Enabled = false;
            pnlCampoTelefonoPil.Enabled = false;
            pnlCampoDireccionPil.Enabled = false;
            pnlCampoSueldoPil.Enabled = false;
            pnlCampoEstatusPil.Enabled = false;
        }

        private void frmPiloto_MouseClick(object sender, MouseEventArgs e)
        {

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

        private void frmPiloto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverPiloto;
        }

        private void lblBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverPiloto;
        }

        private void picIconoBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverPiloto;
        }

        private void btnBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalPiloto;
        }

        private void lblBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalPiloto;
        }

        private void picIconoBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalPiloto;
        }

        private void pnlBotonBuscarPil_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarPiloto = txtBuscarPil.Text;
            funCargarTabla(buscarPiloto);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            /* Final Vaciando los campos */
        }
        public void funVaciarCampos()
        {
            txtIdPiloto.Text = "";
            txtDpiPil.Text = "";
            cbxIdUser.SelectedItem = "";
            txtNombrePil.Text = "";
            txtApellidoPil.Text = "";
            txtTelefonoPil.Text = "";
            txtDireccionPil.Text = "";
            txtSueldoPil.Text = "";
            txtEstatusPil.Text = "";
        }
        private void funCargarTabla(string dato)
        {
            List<Piloto> lista = new List<Piloto>();
            Piloto piloto = new Piloto();

            dgvPiloto.DataSource = piloto.consulta(dato);
        }

        private void pnlBotonGuardarPil_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio de ejecucion de funcion insertar un piloto */
            String EstatusPiloto = "A";
            Piloto piloto = funObtenerTxt(EstatusPiloto);
            piloto.funInsertar();
            /* Final de ejecucion de funcion insertar un piloto */
            funCargarTabla(null);
            funVaciarCampos();
        }
        public Piloto funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC piloto */
            String pIdPil = txtIdPiloto.Text;
            String pDpiPil = txtDpiPil.Text;
            String pIdUser = cbxIdUser.SelectedValue.ToString();
            String pNombrePil = txtNombrePil.Text;
            String pApellidoPil = txtApellidoPil.Text;
            String pTelPil = txtTelefonoPil.Text;
            String pDicPil = txtDireccionPil.Text;
            String pSueldoPil = txtSueldoPil.Text;

            /*Final obteniedo variables a usar con mi ABC piloto */

            /* Inicio creamos un objeto piloto para poder utilizar el metodo de insertar */
            Piloto piloto = new Piloto(pIdPil, pDpiPil, pIdUser, pNombrePil, pApellidoPil, pTelPil, pDicPil, pSueldoPil, estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar*/

            return piloto;
        }

        private void txtSueldoPil_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlModificarPil_MouseClick(object sender, MouseEventArgs e)
        {
            String EstatusPiloto = "A";
            String idPiloto = txtIdPiloto.Text;
            Piloto piloto = funObtenerTxt(EstatusPiloto);

            piloto.funModificar(idPiloto);
            funCargarTabla(null);
            piloto.funBuscarSetearTxt(txtIdPiloto, txtDpiPil, cbxIdUser, txtNombrePil, txtApellidoPil, txtTelefonoPil, txtDireccionPil, txtSueldoPil, txtEstatusPil, idPiloto);
        }

        private void pnlLLenarCamposPil_MouseClick(object sender, MouseEventArgs e)
        {
            Piloto piloto = new Piloto();

            txtIdPiloto.Text = dgvPiloto.CurrentRow.Cells[0].Value.ToString();
            txtDpiPil.Text = dgvPiloto.CurrentRow.Cells[1].Value.ToString();

            String idPiloto = dgvPiloto.CurrentRow.Cells[2].Value.ToString();
            piloto.obtenerNombreUsuario(idPiloto);
            cbxIdUser.SelectedValue = idPiloto;

            txtNombrePil.Text = dgvPiloto.CurrentRow.Cells[3].Value.ToString();
            txtApellidoPil.Text = dgvPiloto.CurrentRow.Cells[4].Value.ToString();
            txtTelefonoPil.Text = dgvPiloto.CurrentRow.Cells[5].Value.ToString();
            txtDireccionPil.Text = dgvPiloto.CurrentRow.Cells[6].Value.ToString();
            txtSueldoPil.Text = dgvPiloto.CurrentRow.Cells[7].Value.ToString();
            txtEstatusPil.Text = dgvPiloto.CurrentRow.Cells[8].Value.ToString();
        }

        private void pnlLlenarCamposPilDB_MouseClick(object sender, MouseEventArgs e)
        {
            Piloto piloto = new Piloto();

            txtIdPiloto.Text = dgvPiloto.CurrentRow.Cells[0].Value.ToString();
            txtDpiPil.Text = dgvPiloto.CurrentRow.Cells[1].Value.ToString();

            String idPiloto = dgvPiloto.CurrentRow.Cells[2].Value.ToString();
            piloto.obtenerNombreUsuario(idPiloto);
            cbxIdUser.SelectedValue = idPiloto;

            txtNombrePil.Text = dgvPiloto.CurrentRow.Cells[3].Value.ToString();
            txtApellidoPil.Text = dgvPiloto.CurrentRow.Cells[4].Value.ToString();
            txtTelefonoPil.Text = dgvPiloto.CurrentRow.Cells[5].Value.ToString();
            txtDireccionPil.Text = dgvPiloto.CurrentRow.Cells[6].Value.ToString();
            txtSueldoPil.Text = dgvPiloto.CurrentRow.Cells[7].Value.ToString();
            txtEstatusPil.Text = dgvPiloto.CurrentRow.Cells[8].Value.ToString();

            String pIdPiloto = txtIdPiloto.Text;

            String pEstatusPiloto = piloto.funBuscarEstatus(pIdPiloto);

            if (pEstatusPiloto == "A")
            {
                pnlActivarPil.Visible = false;
                pnlDarBajaPil.Visible = true;
            }
            else if (pEstatusPiloto == "I")
            {
                pnlDarBajaPil.Visible = false;
                pnlActivarPil.Visible = true;
            }
        }

        private void pnlActivarPil_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdPiloto = txtIdPiloto.Text;
            Piloto piloto = funObtenerTxt(estatus);

            piloto.funActivar();
            funCargarTabla(null);

            pnlDarBajaPil.Visible = true;
            pnlActivarPil.Visible = false;

            piloto.funBuscarSetearTxt(txtIdPiloto, txtDpiPil, cbxIdUser, txtNombrePil, txtApellidoPil, txtTelefonoPil, txtDireccionPil, txtSueldoPil, txtEstatusPil, pIdPiloto);
        }

        private void pnlDarBajaPil_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdPiloto = txtIdPiloto.Text;
            Piloto piloto = funObtenerTxt(estatus);

            piloto.funDarBaja();
            funCargarTabla(null);

            pnlActivarPil.Visible = true;
            pnlDarBajaPil.Visible = false;

            piloto.funBuscarSetearTxt(txtIdPiloto, txtDpiPil, cbxIdUser, txtNombrePil, txtApellidoPil, txtTelefonoPil, txtDireccionPil, txtSueldoPil, txtEstatusPil, pIdPiloto);
        }

        private void pnlActivarPil_MouseCaptureChanged(object sender, EventArgs e)
        {

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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteDetalle obj = new frmPaqueteDetalle();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void label18_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
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

        private void pnlTrans_MouseClick(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void label25_MouseClick(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlMovBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmMovimientoBodega obj = new frmMovimientoBodega();

            obj.Visible = true;

            Visible = false;
        }

        private void lblMovimientoBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmMovimientoBodega obj = new frmMovimientoBodega();

            obj.Visible = true;

            Visible = false;
        }

        private void picMovBodega_MouseClick(object sender, MouseEventArgs e)
        {
            frmMovimientoBodega obj = new frmMovimientoBodega();

            obj.Visible = true;

            Visible = false;
        }

        private void btnCalificacionP_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverPiloto;
        }

        private void lblUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverPiloto;
        }

        private void picIconoUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverPiloto;
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalPiloto;
        }

        private void lblUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalPiloto;
        }

        private void picIconoUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalPiloto;
        }

        private void pnlPD_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverPiloto;
        }

        private void lblPaqDet_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverPiloto;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverPiloto;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalPiloto;
        }

        private void lblPaqDet_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalPiloto;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalPiloto;
        }

        private void pnlEmpleado_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverPiloto;
        }

        private void label18_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverPiloto;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverPiloto;
        }

        private void pnlEmpleado_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalPiloto;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalPiloto;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalPiloto;
        }

        private void btnBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverPiloto;
        }

        private void lblBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverPiloto;
        }

        private void picBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverPiloto;
        }

        private void btnBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalPiloto;
        }

        private void lblBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalPiloto;
        }

        private void picBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalPiloto;
        }

        private void pnlEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverPiloto;
        }

        private void lblEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverPiloto;
        }

        private void picEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverPiloto;
        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalPiloto;
        }

        private void lblEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalPiloto;
        }

        private void picEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalPiloto;
        }

        private void pnlTrans_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverPiloto;
        }

        private void label25_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverPiloto;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverPiloto;
        }

        private void pnlTrans_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalPiloto;
        }

        private void label25_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalPiloto;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalPiloto;
        }

        private void pnlMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverPiloto;
        }

        private void lblMovimientoBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverPiloto;
        }

        private void picMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverPiloto;
        }

        private void pnlMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalPiloto;
        }

        private void lblMovimientoBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalPiloto;
        }

        private void picMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalPiloto;
        }

        private void btnCalificacionP_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverPiloto;
        }

        private void lblCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverPiloto;
        }

        private void picCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverPiloto;
        }

        private void btnCalificacionP_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalPiloto;
        }

        private void lblCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalPiloto;
        }

        private void picCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalPiloto;
        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnInventario_MouseClick(object sender, MouseEventArgs e)
        {
            frmInventario obj = new frmInventario();
            obj.Visible = true;
            Visible = false;
        }

        private void btnInventario_MouseHover(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorHoverPiloto;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorNormalPiloto;
        }
    }
}
