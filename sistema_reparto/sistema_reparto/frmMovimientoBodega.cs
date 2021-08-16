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
    public partial class frmMovimientoBodega : Form
    {

        /* Codigo para redondear mi panel*/
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
        Color colorHoverMovB = Color.FromArgb(80, 115, 119);
        Color colorNormalMovB = Color.FromArgb(59, 102, 107);



        public frmMovimientoBodega()
        {
            InitializeComponent();
            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            /*Iniciamos bloqueando campos */

            MovBodega movBo = new MovBodega();

            /* Inicio llenado mis Combobox */
            movBo.funLlenarCombo(cbxIdPaqueteEnc);
            movBo.funLlenarComboBodega(cbxIdBodega);
            movBo.funLlenarComboTipoMov(cbxIdTipoMobB);
            /* Final llenado mis Combobox */

            pnlInventario.Visible = false;
            pnlIdMovBodega.Visible = false;
            pnlIdPaquete.Visible = false;
            pnlEmp.Visible = false;
            pnlClient.Visible = false;
            pnlIdTipoMov.Visible = false;
            pnlIdBodega.Visible = false;
            pnlFechaMobB.Visible = false;
            pnlBotonGuardarMovB.Visible = false;
            pnlDesa.Visible = false;
            txtBuscarMovB.Visible = false;
            pnlBotonBuscarMovB.Visible = false;
            dgvIn.Visible = false;
            pnlLlenarCamposMoDB.Visible = false;
            pnlBordeMoVBodega.Visible = false;
            lblAbastecer.Visible = false;
            pnlBordeAbas.Visible = false;
            lblDesa.Visible = false;
            pnlBordeDes.Visible = false;
            txtBuscarMovBo.Visible = false;
            pnlBuscarBodega.Visible = false;
            dgbMovBo.Visible = false;

            txtEmpleado.Enabled = false;
            txtCliente.Enabled = false;
            cbxIdTipoMobB.Enabled = false;

            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;

        }

        private void frmMovimientoBodega_Load(object sender, EventArgs e)
        {

        }

        private void lblRegistrarMovBodega_MouseClick(object sender, MouseEventArgs e)
        {


            /*Ocultaremos algunos elementos*/
            pnlBordeMoVBodega.Visible = true;

            pnlIdMovBodega.Visible = true;
            pnlIdBodega.Visible = true;
            pnlIdPaquete.Visible = true;
            pnlIdTipoMov.Visible = true;
            pnlFechaMobB.Visible = true;
            pnlBotonGuardarMovB.Visible = true
                ;
            txtBuscarMovB.Visible = true;
            pnlBotonBuscarMovB.Visible = true;
            dgvIn.Visible = true;
            pnlLlenarCamposMoDB.Visible = false;




        }

        private void lblAbcMovBodega_MouseClick(object sender, MouseEventArgs e)
        {
            /*Ocultaremos algunos elementos y otros los haremos visibles*/
            pnlBordeMoVBodega.Visible = true;

            lblAbastecer.Visible = true;
            lblDesa.Visible = true;


            /*pnlIdMovBodega.Visible = false;
            pnlIdBodega.Visible = false;
            pnlIdPaquete.Visible = false;
            pnlIdTipoMov.Visible = false;
            pnlFechaMobB.Visible = false;
            pnlBotonGuardarMovB.Visible = false;
            txtBuscarMovB.Visible = false;
            pnlBotonBuscarMovB.Visible = false;
            dgvIn.Visible = false;
            pnlLlenarCamposMoDB.Visible = false;*/



        }

        public void funVaciarCampos()
        {
            txtInventario.Text = "";
            txtMovBodega.Text = "";
            
            cbxIdPaqueteEnc.SelectedIndex = 0;
        
           
            cbxIdBodega.SelectedIndex = 0;
            

            txtFechaMobBod.Value = DateTime.Now;
        }

        private void lblModificarMovBodega_MouseClick(object sender, MouseEventArgs e)
        {
            /*Bloquearemos y haremos visibles algunos elementos*/
            pnlBordeMoVBodega.Visible = true;


            pnlIdMovBodega.Visible = true;
            pnlIdBodega.Visible = true;
            pnlIdPaquete.Visible = true;
            pnlIdTipoMov.Visible = true;
            pnlFechaMobB.Visible = true;
            pnlBotonGuardarMovB.Visible = false;

            txtBuscarMovB.Visible = true;
            pnlBotonBuscarMovB.Visible = true;
            dgvIn.Visible = true;
            pnlLlenarCamposMoDB.Visible = false;

            /*Hacemos invisibles*/
            pnlIdMovBodega.Enabled = false;


        }

        private void frmMovimientoBodega_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverMovB;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalMovB;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverMovB;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalMovB;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverMovB;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalMovB;
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

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverMovB;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalMovB;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverMovB;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalMovB;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverMovB;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalMovB;
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

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverMovB;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalMovB;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverMovB;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalMovB;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverMovB;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalMovB;
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

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverMovB;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalMovB;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverMovB;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalMovB;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverMovB;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalMovB;
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

        private void picTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void lblTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void picTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void btnRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverMovB;
        }

        private void btnRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalMovB;

        }

        private void lblRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverMovB;
        }

        private void lblRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalMovB;
        }

        private void picRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverMovB;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverMovB;
        }

        private void picRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalMovB;
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

        private void pnlSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverMovB;
        }

        private void pnlSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalMovB;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverMovB;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalMovB;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalMovB;
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

        private void btnTipoMovimiento_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {

        }

        private void lblTipoMovimiento_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picTipoMovimiento_MouseHover(object sender, EventArgs e)
        {

        }

        private void picTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {

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

        private void btnTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverMovB;
        }

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalMovB;
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverMovB;
        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalMovB;
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverMovB;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalMovB;
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

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverMovB;
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalMovB;
        }

        private void picIconoUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverMovB;
        }

        private void picIconoUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalMovB;
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

        private void btnPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverMovB;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalMovB;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverMovB;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalMovB;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverMovB;

        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalMovB;
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

        private void pnlEmpleado_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverMovB;
        }

        private void pnlEmpleado_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalMovB;
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverMovB;
        }

        private void lnlEmpleado_MouseLeave(object sender, EventArgs e)
        {

            pnlEmpleado.BackColor = colorNormalMovB;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverMovB;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalMovB;
        }

        private void pnlEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void lnlEmpleado_MouseClick(object sender, MouseEventArgs e)
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
            pnlEnvio.BackColor = colorHoverMovB;
        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalMovB;
        }

        private void lblEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverMovB;
        }

        private void lblEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalMovB;
        }

        private void picEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverMovB;
        }

        private void picEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalMovB;
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

        private void pnlMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalMovB;
        }

        private void pnlMovBodega_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void lblMovimientoBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverMovB;

        }

        private void lblMovimientoBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalMovB;
        }

        private void picMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverMovB;
        }

        private void picMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalMovB;
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

        private void pnlBotonGuardarMovB_MouseClick(object sender, MouseEventArgs e)
        {
            String idMovBo = txtMovBodega.Text;
            String idPaquete = cbxIdPaqueteEnc.SelectedValue.ToString();
            String tipoMov = cbxIdTipoMobB.SelectedValue.ToString();
            String bodega = cbxIdBodega.SelectedValue.ToString();
            String fecha = txtFechaMobBod.Value.ToString("yyyy-MM-dd");
            String idInv = txtInventario.Text;

            if(idInv == "" || idMovBo == "")
            {
                MessageBox.Show("Ingrese Datos Correctamente!");
            }
            else
            {
                MovBodega movBo = new MovBodega(idMovBo, bodega, tipoMov, idPaquete, fecha, idInv);

                movBo.funAbastecerIn();

                funCargarTablaIn(null);
                funCargarTablaMovBo(null);

                funVaciarCampos();
            }

            
        }

        private void cbxIdPaqueteEnc_SelectedValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbxIdPaqueteEnc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxIdPaqueteEnc.SelectedValue != null)
            {
                String idPaquete = cbxIdPaqueteEnc.SelectedValue.ToString();

                MovBodega movBo = new MovBodega();

                movBo.funSeteandoTexts(idPaquete, txtEmpleado, txtCliente);
            }
        }

        private void lblAbastecer_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeAbas.Visible = true;
            pnlBordeDes.Visible = false;

            pnlInventario.Visible = true;
            pnlIdMovBodega.Visible = true;
            pnlIdPaquete.Visible = true;
            pnlEmp.Visible = true;
            pnlClient.Visible = true;
            pnlIdTipoMov.Visible = true;
            pnlIdBodega.Visible = true;
            pnlFechaMobB.Visible = true;
            pnlBotonGuardarMovB.Visible = true;
            pnlDesa.Visible = false;
            txtBuscarMovB.Visible = true;
            pnlBotonBuscarMovB.Visible = true;
            dgvIn.Visible = true;
            pnlLlenarCamposMoDB.Visible = true;
            pnlBuscarBodega.Visible = true;
            dgbMovBo.Visible = true;
            txtBuscarMovBo.Visible = true;

            txtInventario.Enabled = true;
            cbxIdPaqueteEnc.Enabled = true;
            cbxIdBodega.Enabled = true;

            cbxIdTipoMobB.SelectedValue = 1;

            funCargarTablaIn(null);
            funCargarTablaMovBo(null);

            funVaciarCampos();
        }

        /* Inicio funcion para cargar mi tabla de Inventario */
        private void funCargarTablaIn(string dato)
        {
            List<Inventario> lista = new List<Inventario>();
            Inventario inventario = new Inventario();

            dgvIn.DataSource = inventario.consulta(dato);
        }

        private void funCargarTablaMovBo(string dato)
        {
            List<MovBodega> lista = new List<MovBodega>();
            MovBodega movBo = new MovBodega();

            dgbMovBo.DataSource = movBo.consulta(dato);
        }

        private void pnlLlenarCamposMoDB_MouseClick(object sender, MouseEventArgs e)
        {
            txtInventario.Text = dgvIn.CurrentRow.Cells[0].Value.ToString();
            cbxIdPaqueteEnc.SelectedValue = dgvIn.CurrentRow.Cells[2].Value.ToString();
            cbxIdBodega.SelectedValue = dgvIn.CurrentRow.Cells[1].Value.ToString();
            txtFechaMobBod.Value = Convert.ToDateTime(dgvIn.CurrentRow.Cells[6].Value.ToString());
        }

        private void lblDesa_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeAbas.Visible = false;
            pnlBordeDes.Visible = true;

            pnlInventario.Visible = true;
            pnlIdMovBodega.Visible = true;
            pnlIdPaquete.Visible = true;
            pnlEmp.Visible = true;
            pnlClient.Visible = true;
            pnlIdTipoMov.Visible = true;
            pnlIdBodega.Visible = true;
            pnlFechaMobB.Visible = true;
            txtBuscarMovB.Visible = true;
            pnlBotonBuscarMovB.Visible = true;
            dgvIn.Visible = true;
            pnlLlenarCamposMoDB.Visible = true;
            pnlBuscarBodega.Visible = true;
            dgbMovBo.Visible = true;
            txtBuscarMovBo.Visible = true;

            txtInventario.Enabled = false;
            cbxIdPaqueteEnc.Enabled = false;
            cbxIdBodega.Enabled = false;
            pnlBotonGuardarMovB.Visible = false;
            pnlDesa.Visible = true;

            cbxIdTipoMobB.SelectedValue = 2;

            funCargarTablaIn(null);
            funCargarTablaMovBo(null);

            funVaciarCampos();
        }

        private void pnlDesa_MouseClick(object sender, MouseEventArgs e)
        {
            String idMovBo = txtMovBodega.Text;
            String idPaquete = cbxIdPaqueteEnc.SelectedValue.ToString();
            String tipoMov = cbxIdTipoMobB.SelectedValue.ToString();
            String bodega = cbxIdBodega.SelectedValue.ToString();
            String fecha = txtFechaMobBod.Value.ToString("yyyy-MM-dd");
            String idInv = txtInventario.Text;

            if (idInv == "" || idMovBo == "")
            {
                MessageBox.Show("Ingrese Datos Correctamente!");
            }
            else
            {
                MovBodega movBo = new MovBodega(idMovBo, bodega, tipoMov, idPaquete, fecha, idInv);

                movBo.funDesAbastecer();

                movBo.funLlenarCombo(cbxIdPaqueteEnc);

                funCargarTablaIn(null);
                funCargarTablaMovBo(null);

                funVaciarCampos();
            }

            
        }

        private void pnlBuscarMovBo_MouseClick(object sender, MouseEventArgs e)
        {
            String buscarMovBo = txtBuscarMovBo.Text;

            funCargarTablaMovBo(buscarMovBo);
        }

        private void pnlBotonBuscarMovB_Click(object sender, EventArgs e)
        {
            String buscarIn = txtBuscarMovB.Text;

            funCargarTablaIn(buscarIn);
        }

        private void pnlMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverMovB;
        }

        private void pnlBuscarMovBo_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pnlBuscarBodega_MouseClick(object sender, MouseEventArgs e)
        {
            String buscarMovBo = txtBuscarMovBo.Text;
            funCargarTablaMovBo(buscarMovBo);
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
            btnCalificacionP.BackColor = colorHoverMovB;
        }

        private void lblCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverMovB;
        }

        private void picCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverMovB;
        }

        private void btnCalificacionP_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalMovB;
        }

        private void lblCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalMovB;
        }

        private void picCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalMovB;
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
            btnPiloto.BackColor = colorHoverMovB;
        }

        private void lblPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverMovB;
        }

        private void picIconoPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverMovB;
        }

        private void btnPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalMovB;
        }

        private void lblPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalMovB;
        }

        private void picIconoPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalMovB;
        }

        private void btnBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverMovB;
        }

        private void lblBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverMovB;
        }

        private void picIconoBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverMovB;
        }

        private void btnBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalMovB;
        }

        private void lblBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalMovB;
        }

        private void picIconoBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalMovB;
        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pnlPD_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverMovB;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalMovB;
        }

        private void pnlTrans_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverMovB;
        }

        private void pnlTrans_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalMovB;
        }

        private void btnInventario_MouseHover(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorHoverMovB;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorNormalMovB;
        }

        private void pnlPD_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteDetalle obj = new frmPaqueteDetalle();
            obj.Visible = true;
            Visible = false;
        }

        private void pnlTrans_MouseClick(object sender, MouseEventArgs e)
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
        /* Final funcion para cargar mi tabla de Inventario */

    }
}
