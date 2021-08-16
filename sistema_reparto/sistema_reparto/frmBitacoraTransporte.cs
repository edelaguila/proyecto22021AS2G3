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
    public partial class frmBitacoraTransporte : Form
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

        Color colorHoverBitaTrans = Color.FromArgb(80, 115, 119);
        Color colorNormalBitaTrans = Color.FromArgb(59, 102, 107);
        public frmBitacoraTransporte()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            funCargarTabla(null);
            funVaciarCampos();

            BitacoraTransporte bitacoraTransporte = new BitacoraTransporte();
            bitacoraTransporte.funLlenarCombo(cbxIdTrans, "transporte", "idTransporte", "nombreTransporte");
            bitacoraTransporte.funLlenarCombo(cbxIdPiloto, "piloto", "idPiloto", "nombrePiloto");


            /*Inicio Esconder contenidos de mi form Bitacora Transporte */
            lblTituloBitaTrans.Visible = true;
            lblAbcBitaTrans.Visible = true;
            pnlBordeBitaTrans.Visible = false;

            lblRegistrarBitaTrans.Visible = false;
            lblModificarBitaTrans.Visible = false;
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;

            pnlCampoIDBiTran.Visible = false;
            pnlCampoIDTrans.Visible = false;
            pnlCampoIDPiloto.Visible = false;
            pnlCampoKMIni.Visible = false;
            pnlCampoKMFin.Visible = false;
            pnlFechaSal.Visible = false;
            pnlFechaEnt.Visible = false;
            pnlCampoHoraSal.Visible = false;
            pnlCampoHoraEnt.Visible = false;
            pnlCampoLugarSal.Visible = false;
            pnlCampoLugarLle.Visible = false;
            pnlCampoNivelGas.Visible = false;
            pnlBotonGuardarBT.Visible = false;
            pnlModificarBT.Visible = false;
            txtBuscarBitaTrans.Visible = false;
            pnlBotonBuscarBitaTrans.Visible = false;
            dgvBitaTrans.Visible = false;
            pnlLLenarCamposBT.Visible = false;


            /*Final Esconder contenidos de mi form Bitacora Transporte */

            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;
        }

        private void frmBitacoraTransporte_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Paint(object sender, PaintEventArgs e)
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

        private void frmBitacoraTransporte_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void btnBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverBitaTrans;
        }

        private void lblAbcBitaTrans_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeBitaTrans.Visible = true;
            lblRegistrarBitaTrans.Visible = true;
            lblModificarBitaTrans.Visible = true;
        }

        private void lblRegistrarBitaTrans_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = true;
            pnlBordeModificar.Visible = false;
            pnlCampoIDBiTran.Enabled = false;

            /*Inicio Esconder y mostrando contenidos de mi form Bitacora Transporte */
            pnlCampoIDBiTran.Visible = true;
            pnlCampoIDTrans.Visible = true;
            pnlCampoIDPiloto.Visible = true;
            pnlCampoKMIni.Visible = true;
            pnlCampoKMFin.Visible = true;
            pnlFechaSal.Visible = true;
            pnlFechaEnt.Visible = true;
            pnlCampoHoraSal.Visible = true;
            pnlCampoHoraEnt.Visible = true;
            pnlCampoLugarSal.Visible = true;
            pnlCampoLugarLle.Visible = true;
            pnlCampoNivelGas.Visible = true;
            pnlBotonGuardarBT.Visible = true;
            pnlModificarBT.Visible = false;
            txtBuscarBitaTrans.Visible = true;
            pnlBotonBuscarBitaTrans.Visible = true;
            dgvBitaTrans.Visible = true;
            pnlLLenarCamposBT.Visible = true;
                /*Final Esconder y mostrando contenidos de mi form Bitacora Transporte */
        }

        private void lblModificarBitaTrans_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = true;
            pnlCampoIDBiTran.Enabled = false;


            /*Inicio Esconder y mostrando contenidos de mi form Bitacora Transporte */
            pnlCampoIDBiTran.Visible = true;
            pnlCampoIDTrans.Visible = true;
            pnlCampoIDPiloto.Visible = true;
            pnlCampoKMIni.Visible = true;
            pnlCampoKMFin.Visible = true;
            pnlFechaSal.Visible = true;
            pnlFechaEnt.Visible = true;
            pnlCampoHoraSal.Visible = true;
            pnlCampoHoraEnt.Visible = true;
            pnlCampoLugarSal.Visible = true;
            pnlCampoLugarLle.Visible = true;
            pnlCampoNivelGas.Visible = true;
            pnlBotonGuardarBT.Visible = false;
            pnlModificarBT.Visible = true;
            txtBuscarBitaTrans.Visible = true;
            pnlBotonBuscarBitaTrans.Visible = true;
            dgvBitaTrans.Visible = true;
            pnlLLenarCamposBT.Visible = true;
            /*Final Esconder y mostrando contenidos de mi form Bitacora Transporte */
        }

        private void lblDarBaja_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;

            /*Inicio Esconder y mostrando contenidos de mi form Bitacora Transporte */
            pnlCampoIDBiTran.Visible = true;
            pnlCampoIDTrans.Visible = true;
            pnlCampoIDPiloto.Visible = true;
            pnlCampoKMIni.Visible = true;
            pnlCampoKMFin.Visible = true;
            pnlFechaSal.Visible = true;
            pnlFechaEnt.Visible = true;
            pnlCampoHoraSal.Visible = true;
            pnlCampoHoraEnt.Visible = true;
            pnlCampoLugarSal.Visible = true;
            pnlCampoLugarLle.Visible = true;
            pnlCampoNivelGas.Visible = true;
            pnlBotonGuardarBT.Visible = false;
            pnlModificarBT.Visible = false;
            txtBuscarBitaTrans.Visible = true;
            pnlBotonBuscarBitaTrans.Visible = true;
            dgvBitaTrans.Visible = true;
            pnlLLenarCamposBT.Visible = false;
            /*Final Esconder y mostrando contenidos de mi form Bitacora Transporte */
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverBitaTrans;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverBitaTrans;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverBitaTrans;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalBitaTrans;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalBitaTrans;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalBitaTrans;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverBitaTrans;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverBitaTrans;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverBitaTrans;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalBitaTrans;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalBitaTrans;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalBitaTrans;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverBitaTrans;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverBitaTrans;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverBitaTrans;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalBitaTrans;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalBitaTrans;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalBitaTrans;
        }

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverBitaTrans;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverBitaTrans;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverBitaTrans;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalBitaTrans;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalBitaTrans;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalBitaTrans;
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
            btnRuta.BackColor = colorHoverBitaTrans;
        }

        private void lblRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverBitaTrans;
        }

        private void picRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverBitaTrans;
        }

        private void btnRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalBitaTrans;
        }

        private void lblRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalBitaTrans;
        }

        private void picRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalBitaTrans;
        }

        private void pnlSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverBitaTrans;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverBitaTrans;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverBitaTrans;
        }

        private void pnlSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalBitaTrans;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalBitaTrans;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalBitaTrans;
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
            btnTipoTransporte.BackColor = colorHoverBitaTrans;
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverBitaTrans;
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverBitaTrans;
        }

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalBitaTrans;
        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalBitaTrans;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalBitaTrans;
        }

        private void btnPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverBitaTrans;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverBitaTrans;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverBitaTrans;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalBitaTrans;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalBitaTrans;
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalBitaTrans;
        }

        private void btnPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverBitaTrans;
        }

        private void lblPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverBitaTrans;
        }

        private void picIconoPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverBitaTrans;
        }

        private void btnPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalBitaTrans;
        }

        private void lblPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalBitaTrans;
        }

        private void picIconoPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalBitaTrans;
        }

        private void lblBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverBitaTrans;
        }

        private void picIconoBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverBitaTrans;
        }

        private void btnBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalBitaTrans;
        }

        private void lblBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalBitaTrans;
        }

        private void picIconoBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalBitaTrans;
        }

        private void pnlBotonGuardarBT_MouseClick(object sender, MouseEventArgs e)
        {
            //String EstatusRuta = "A";
            //BitacoraTransporte bitacoraTransporte = funObtenerTxt(EstatusRuta);
            BitacoraTransporte bitacoraTransporte = funObtenerTxt();
            bitacoraTransporte.funInsertar();
            /* Final de ejecucion de funcion insertar un Ruta */

            funCargarTabla(null);
            funVaciarCampos();
        }

        private void pnlModificarBT_Paint(object sender, PaintEventArgs e)
        {
           // String idBitacora = txtIdBiTran.Text;
            // Ruta ruta = funObtenerTxt(EstatusRuta);
            //BitacoraTransporte bitacoraTransporte = new BitacoraTransporte();
            //bitacoraTransporte.funModificar(idBitacora);
           // funCargarTabla(null);
            //bitacoraTransporte.funBuscarSetearTxt(txtIdBiTran, cbxIdTrans, cbxIdPiloto, txtKMIni, txtKMFin,txtFechaSal, txtFechaEnt, txtHoraSal, txtHoraEnt,txtLugarSal, txtLugarLlegada, txtNivelGas, idBitacora);
        }

        private void pnlModificarBT_MouseClick(object sender, MouseEventArgs e)
        {

            String idBitacora = txtIdBiTran.Text;
            // Ruta ruta = funObtenerTxt(EstatusRuta);
            BitacoraTransporte bitacoraTransporte = funObtenerTxt();
            bitacoraTransporte.funModificar(idBitacora);
            funCargarTabla(null);
            bitacoraTransporte.funBuscarSetearTxt(txtIdBiTran, cbxIdTrans, cbxIdPiloto, txtKMIni, txtKMFin, txtFechaSal, txtFechaEnt, txtHoraSal, txtHoraEnt, txtLugarSal, txtLugarLlegada, txtNivelGas, idBitacora);
        }

        private void pnlLLenarCamposBT_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdBiTran.Text = dgvBitaTrans.CurrentRow.Cells[0].Value.ToString();

            BitacoraTransporte bitacoraTransporte = new BitacoraTransporte();

            String idTransporte = dgvBitaTrans.CurrentRow.Cells[1].Value.ToString();
            bitacoraTransporte.obtenerNombreT(idTransporte);
            cbxIdTrans.SelectedValue = idTransporte;


            String idPioloto = dgvBitaTrans.CurrentRow.Cells[2].Value.ToString();
            bitacoraTransporte.obtenerNombreP(idPioloto);
            cbxIdPiloto.SelectedValue = idPioloto;

            txtKMIni.Text = dgvBitaTrans.CurrentRow.Cells[3].Value.ToString();
            txtKMFin.Text = dgvBitaTrans.CurrentRow.Cells[4].Value.ToString();

            // De string a dateTime
            txtFechaSal.Value = Convert.ToDateTime(dgvBitaTrans.CurrentRow.Cells[5].Value.ToString());
            txtFechaEnt.Value = Convert.ToDateTime(dgvBitaTrans.CurrentRow.Cells[6].Value.ToString());

            txtHoraSal.Value = Convert.ToDateTime(dgvBitaTrans.CurrentRow.Cells[7].Value.ToString());
            txtHoraEnt.Value = Convert.ToDateTime(dgvBitaTrans.CurrentRow.Cells[8].Value.ToString());

            txtLugarSal.Text = dgvBitaTrans.CurrentRow.Cells[9].Value.ToString();
            txtLugarLlegada.Text = dgvBitaTrans.CurrentRow.Cells[10].Value.ToString();
            txtNivelGas.Text = dgvBitaTrans.CurrentRow.Cells[11].Value.ToString();
        }

        private void pnlBotonBuscarBitaTrans_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarBT = txtBuscarBitaTrans.Text;
            funCargarTabla(buscarBT);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            /* Final Vaciando los campos */
        }
        public void funVaciarCampos()
        {
            txtIdBiTran.Text = "";
            cbxIdTrans.Text = "";
            cbxIdPiloto.Text = "";
            txtKMIni.Text = "";
            txtKMFin.Text = "";
            txtFechaSal.Text = "";
            txtFechaEnt.Text = "";
            txtHoraSal.Text = "";
            txtHoraEnt.Text = "";
            txtLugarSal.Text = "";
            txtLugarLlegada.Text = "";
            txtNivelGas.Text = "";
        }
        public BitacoraTransporte funObtenerTxt()
        {
            /*Inicio obteniedo variables a usar con mi ABC cliente */
            String idBTTrans = "0";
            String idTrans = cbxIdTrans.SelectedValue.ToString();
            String idPiloto = cbxIdPiloto.SelectedValue.ToString();
            String kminicio = txtKMIni.Text;
            String kmfinal = txtKMFin.Text;

            String fechaSal = txtFechaSal.Value.ToString("yyyy-MM-dd");
            String fechaEnt = txtFechaEnt.Value.ToString("yyyy-MM-dd");
            String horaSal = txtHoraSal.Value.ToString("HH:mm");
            String horaEnt = txtHoraEnt.Value.ToString("HH:mm");

            String lugarSal = txtLugarSal.Text;
            String lugarLle = txtLugarLlegada.Text;
            String nivelGas = txtNivelGas.Text;



            /*Final obteniedo variables a usar con mi ABC */

            /* Inicio creamos un objeto de tipo paqueteEncabezado para poder utilizar el metodo de insertar */
            BitacoraTransporte bitacoraTransporte = new BitacoraTransporte(idBTTrans, idTrans, idPiloto, kminicio, kmfinal, fechaSal, fechaEnt, horaSal, horaEnt, lugarSal, lugarLle, nivelGas);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */

            return bitacoraTransporte;
        }
        private void funCargarTabla(string dato)
        {
            List<BitacoraTransporte> lista = new List<BitacoraTransporte>();
            BitacoraTransporte bitacoraTransporte = new BitacoraTransporte();

            dgvBitaTrans.DataSource = bitacoraTransporte.consulta(dato);
        }

        private void pnlBgSide_Paint(object sender, PaintEventArgs e)
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
            btnUsuarios.BackColor = colorHoverBitaTrans;
        }

        private void lblUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverBitaTrans;
        }

        private void picIconoUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverBitaTrans;
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalBitaTrans;
        }

        private void lblUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalBitaTrans;
        }

        private void picIconoUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalBitaTrans;
        }

        private void pnlPD_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverBitaTrans;
        }

        private void lblPaqDet_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverBitaTrans;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverBitaTrans;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalBitaTrans;
        }

        private void lblPaqDet_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalBitaTrans;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalBitaTrans;
        }

        private void pnlEmpleado_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverBitaTrans;
        }

        private void label18_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverBitaTrans;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverBitaTrans;
        }

        private void pnlEmpleado_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalBitaTrans;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalBitaTrans;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalBitaTrans;
        }

        private void btnBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverBitaTrans;
        }

        private void lblBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverBitaTrans;
        }

        private void picBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverBitaTrans;
        }

        private void btnBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalBitaTrans;
        }

        private void lblBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalBitaTrans;
        }

        private void picBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalBitaTrans;
        }

        private void pnlEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverBitaTrans;
        }

        private void lblEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverBitaTrans;
        }

        private void picEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverBitaTrans;
        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalBitaTrans;
        }

        private void lblEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalBitaTrans;
        }

        private void picEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalBitaTrans;
        }

        private void pnlTrans_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverBitaTrans;
        }

        private void label25_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverBitaTrans;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverBitaTrans;
        }

        private void pnlTrans_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalBitaTrans;
        }

        private void label25_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalBitaTrans;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalBitaTrans;
        }

        private void pnlMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverBitaTrans;
        }

        private void lblMovimientoBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverBitaTrans;
        }

        private void picMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverBitaTrans;
        }

        private void pnlMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalBitaTrans;
        }

        private void lblMovimientoBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalBitaTrans;
        }

        private void picMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalBitaTrans;
        }

        private void btnCalificacionP_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverBitaTrans;
        }

        private void lblCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverBitaTrans;
        }

        private void picCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverBitaTrans;
        }

        private void btnCalificacionP_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalBitaTrans;
        }

        private void lblCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalBitaTrans;
        }

        private void picCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalBitaTrans;
        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void lblInventario_MouseClick(object sender, MouseEventArgs e)
        {
            frmInventario obj = new frmInventario();
            obj.Visible = true;
            Visible = false;
        }

        private void lblInventario_MouseHover(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorHoverBitaTrans;
        }

        private void lblInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorNormalBitaTrans;
        }
    }
}
