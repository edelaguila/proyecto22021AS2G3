using System;
using MySql.Data.MySqlClient;
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
    public partial class frmTransporte : Form
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
        Color colorHoverRuta = Color.FromArgb(80, 115, 119);
        Color colorNormalRuta = Color.FromArgb(59, 102, 107);


        public frmTransporte()
        {
            InitializeComponent();
            Empleado empleado = new Empleado();
            empleado.funLlenarComboTE(cbxIdTipoTrans, "tipoTransporte", "idTipoTransporte", "nombreTipoTransporte");

            /*Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            funCargarTabla(null);

            lblRegistrarTransporte.Visible = false;
            lblModificarTransporte.Visible = false;
            lblDarBaja.Visible = false;
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = false;
            pnlBotonBuscarT.Visible = false;
            pnlBordeTransporte.Visible = false;
            pnlCampoIDT.Visible = false;
            pnlCampoNombreT.Visible = false;
            pnlCampoIdTipoTrans.Visible = false;
            pnlCampoPlacaTransporte.Visible = false;
            pnlCampoColorTransporte.Visible = false;
            pnlCampoNoChasis.Visible = false;
            pnlModeloTransporte.Visible = false;
            pnlMarcaTransporte.Visible = false;
            pnlCampoPropietarioTransporte.Visible = false;
            pnlEstatusTrans.Visible = false;
            pnlDarBajaT.Visible = false;
            pnlActivarT.Visible = false;
            pnlModificarT.Visible = false;
            pnlGuardarT.Visible = false;
            dgvTransporte.Visible = false;
            txtBuscarTransporte.Visible = false;
            pnlBotonBuscarT.Visible = false;
            pnlLLenarCamposT.Visible = false;
            pnlLlenarCamposTDB.Visible = false;

            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;



        }

        private void lblTituloEmpleado_Click(object sender, EventArgs e)
        {

        }

        public void funVaciarCampos()
        {
            txtIdTransporte.Text = "";
            txtNombreT.Text = "";
            cbxIdTipoTrans.SelectedItem = "";
            txtPlacaTransporte.Text = "";
            txtColorTransporte.Text = "";
            txtNoChasis.Text = "";
            txtModeloTransporte.Text = "";
            txtMarcaTransporte.Text = "";
            txtPropietarioTransporte.Text = "";
            txtEstatusTransporte.Text = "";
        }


        private void funCargarTabla(string dato)
        {
            List<Ruta> lista = new List<Ruta>();
            Transporte transporte = new Transporte();

            dgvTransporte.DataSource = transporte.consulta(dato);
        }

        public Transporte funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC empleado */
            String pIdTrans = txtIdTransporte.Text;
            String pNombreTrans = txtNombreT.Text;
            String pIdTipoTrans = cbxIdTipoTrans.SelectedValue.ToString();
            String pPlaca = txtPlacaTransporte.Text;
            String pColor = txtColorTransporte.Text;
            String pChasis = txtNoChasis.Text;
            String pModelo = txtModeloTransporte.Text;
            String pMarca = txtMarcaTransporte.Text;
            String pPropietario = txtPropietarioTransporte.Text;

            /*Final obteniedo variables a usar con mi ABC Departamento */

            /* Inicio creamos un objeto de tipo empleado para poder utilizar el metodo de insertar Ruta */
            Transporte transporte = new Transporte(pIdTrans, pNombreTrans, pIdTipoTrans, pPlaca, pColor, pChasis, pModelo, pMarca, pPropietario, estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar Ruta */

            return transporte;
        }



        private void frmTransporte_Load(object sender, EventArgs e)
        {

        }

        private void lblAbcTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            lblRegistrarTransporte.Visible = true;
            lblModificarTransporte.Visible = true;
            lblDarBaja.Visible = true;
            pnlBordeRegistrar.Visible = true;
            pnlBordeModificar.Visible = true;
            pnlBordeDarBaja.Visible = true;
            pnlBotonBuscarT.Visible = false;
            pnlBordeTransporte.Visible = true;
        }

        private void frmTransporte_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblRegistrarTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio cargando datos en tabla Ruta */
            Empleado empleado = new Empleado();
            funCargarTabla(null);

            pnlCampoIDT.Enabled = true;
            pnlCampoNombreT.Enabled = true;
            pnlCampoIdTipoTrans.Enabled = true;
            pnlCampoPlacaTransporte.Enabled = true;
            pnlCampoColorTransporte.Enabled = true;
            pnlCampoNoChasis.Enabled = true;
            pnlModeloTransporte.Enabled = true;
            pnlMarcaTransporte.Enabled = true;
            pnlCampoPropietarioTransporte.Enabled = true;


            lblRegistrarTransporte.Visible = true;
            lblModificarTransporte.Visible = true;
            lblDarBaja.Visible = true;
            pnlBordeRegistrar.Visible = true;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = false;
            pnlBotonBuscarT.Visible = true;
            pnlBordeTransporte.Visible = true;
            pnlCampoIDT.Visible = true;
            pnlCampoNombreT.Visible = true;
            pnlCampoIdTipoTrans.Visible = true;
            pnlCampoPlacaTransporte.Visible = true;
            pnlCampoColorTransporte.Visible = true;
            pnlCampoNoChasis.Visible = true;
            pnlModeloTransporte.Visible = true;
            pnlMarcaTransporte.Visible = true;
            pnlCampoPropietarioTransporte.Visible = true;
            pnlEstatusTrans.Visible = false;
            pnlDarBajaT.Visible = false;
            pnlActivarT.Visible = false;
            pnlModificarT.Visible = false;
            pnlGuardarT.Visible = true;
            dgvTransporte.Visible = true;
            txtBuscarTransporte.Visible = true;
            pnlBotonBuscarT.Visible = true;
            pnlLLenarCamposT.Visible = true;
            pnlLlenarCamposTDB.Visible = false;

            pnlCampoIDT.Enabled = true;

        }

        private void lblModificarTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();
            funCargarTabla(null);

            pnlCampoNombreT.Enabled = true;
            pnlCampoIdTipoTrans.Enabled = true;
            pnlCampoPlacaTransporte.Enabled = true;
            pnlCampoColorTransporte.Enabled = true;
            pnlCampoNoChasis.Enabled = true;
            pnlModeloTransporte.Enabled = true;
            pnlMarcaTransporte.Enabled = true;
            pnlCampoPropietarioTransporte.Enabled = true;


            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = true;
            pnlBordeDarBaja.Visible = false;
            pnlBordeTransporte.Visible = true;
            pnlCampoIDT.Visible = true;
            pnlCampoIDT.Enabled = false;
            pnlCampoNombreT.Visible = true;
            pnlCampoIdTipoTrans.Visible = true;
            pnlCampoPlacaTransporte.Visible = true;
            pnlCampoColorTransporte.Visible = true;
            pnlCampoNoChasis.Visible = true;
            pnlModeloTransporte.Visible = true;
            pnlMarcaTransporte.Visible = true;
            pnlCampoPropietarioTransporte.Visible = true;
            pnlEstatusTrans.Visible = false;
            pnlEstatusTrans.Enabled = false;
            pnlDarBajaT.Visible = false;
            pnlActivarT.Visible = false;
            pnlModificarT.Visible = true;
            pnlGuardarT.Visible = false;
            dgvTransporte.Visible = true;
            txtBuscarTransporte.Visible = true;
            pnlBotonBuscarT.Visible = true;
            pnlLLenarCamposT.Visible = true;
            pnlLlenarCamposTDB.Visible = false;

        }

        private void lblDarBaja_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();


            pnlBordeModificar.Visible = false;
            pnlBordeRegistrar.Visible = false;
            pnlBordeDarBaja.Visible = true;
            pnlBordeTransporte.Visible = true;
            pnlCampoIDT.Visible = true;
            pnlCampoIDT.Enabled = false;
            pnlCampoNombreT.Visible = true;
            pnlCampoNombreT.Enabled = false;
            pnlCampoIdTipoTrans.Visible = true;
            pnlCampoIdTipoTrans.Enabled = false;
            pnlCampoPlacaTransporte.Visible = true;
            pnlCampoPlacaTransporte.Enabled = false;
            pnlCampoColorTransporte.Visible = true;
            pnlCampoColorTransporte.Enabled = false;
            pnlCampoNoChasis.Visible = true;
            pnlCampoNoChasis.Enabled = false;
            pnlModeloTransporte.Visible = true;
            pnlModeloTransporte.Enabled = false;
            pnlMarcaTransporte.Visible = true;
            pnlMarcaTransporte.Enabled = false;
            pnlCampoPropietarioTransporte.Visible = true;
            pnlCampoPropietarioTransporte.Enabled = false;
            pnlEstatusTrans.Visible = true; ;
            txtEstatusTransporte.Enabled = false;
            pnlEstatusTrans.Enabled = false;
            pnlDarBajaT.Visible = false;
            pnlActivarT.Visible = false;
            pnlModificarT.Visible = false;
            pnlGuardarT.Visible = false;
            dgvTransporte.Visible = true;
            txtBuscarTransporte.Visible = true;
            pnlBotonBuscarT.Visible = true;
            pnlLLenarCamposT.Visible = false;
            pnlLlenarCamposTDB.Visible = true;

        }

        private void pnlGuardarT_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio de ejecucion de funcion insertar un empleado */
            String EstatusTransporte = "A";
            Transporte transporte = funObtenerTxt(EstatusTransporte);
            transporte.funInsertar();
            /* Final de ejecucion de funcion insertar un empleado */
            funCargarTabla(null);
            funVaciarCampos();

        }

        private void pnlModificarT_MouseClick(object sender, MouseEventArgs e)
        {
            String EstatusTransporte = "A";
            String idTransporte = txtIdTransporte.Text;
            Transporte transporte = funObtenerTxt(EstatusTransporte);

            transporte.funModificar(idTransporte);
            funCargarTabla(null);
            transporte.funBuscarSetearTxt(txtIdTransporte, txtNombreT, cbxIdTipoTrans, txtPlacaTransporte, txtColorTransporte, txtNoChasis, txtModeloTransporte, txtMarcaTransporte, txtPropietarioTransporte, txtEstatusTransporte, idTransporte);
        }

        private void pnlActivarT_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdTransporte = txtIdTransporte.Text;
            Transporte transporte = funObtenerTxt(estatus);

            transporte.funActivarEmpleado();
            funCargarTabla(null);

            pnlDarBajaT.Visible = true;
            pnlActivarT.Visible = false;

            transporte.funBuscarSetearTxt(txtIdTransporte, txtNombreT, cbxIdTipoTrans, txtPlacaTransporte, txtColorTransporte, txtNoChasis, txtModeloTransporte, txtMarcaTransporte, txtPropietarioTransporte, txtEstatusTransporte, pIdTransporte);
        }

        private void pnlDarBajaT_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdTransporte = txtIdTransporte.Text;
            Transporte transporte = funObtenerTxt(estatus);

            transporte.funDarBajaRuta();
            funCargarTabla(null);

            pnlActivarT.Visible = true;
            pnlDarBajaT.Visible = false;

            transporte.funBuscarSetearTxt(txtIdTransporte, txtNombreT, cbxIdTipoTrans, txtPlacaTransporte, txtColorTransporte, txtNoChasis, txtModeloTransporte, txtMarcaTransporte, txtPropietarioTransporte, txtEstatusTransporte, pIdTransporte);
        }

        private void pnlLLenarCamposT_MouseClick(object sender, MouseEventArgs e)
        {
            Transporte transporte = new Transporte();

            txtIdTransporte.Text = dgvTransporte.CurrentRow.Cells[0].Value.ToString();
            txtNombreT.Text = dgvTransporte.CurrentRow.Cells[1].Value.ToString();
            txtPlacaTransporte.Text = dgvTransporte.CurrentRow.Cells[3].Value.ToString();
            txtColorTransporte.Text = dgvTransporte.CurrentRow.Cells[4].Value.ToString();
            txtNoChasis.Text = dgvTransporte.CurrentRow.Cells[5].Value.ToString();
            txtModeloTransporte.Text = dgvTransporte.CurrentRow.Cells[6].Value.ToString();
            txtMarcaTransporte.Text = dgvTransporte.CurrentRow.Cells[7].Value.ToString();
            txtPropietarioTransporte.Text = dgvTransporte.CurrentRow.Cells[8].Value.ToString();
            txtEstatusTransporte.Text = dgvTransporte.CurrentRow.Cells[9].Value.ToString();

            String idTipoT = dgvTransporte.CurrentRow.Cells[2].Value.ToString();
            transporte.obtenerNombreTipoTransporte(idTipoT);
            cbxIdTipoTrans.SelectedValue = idTipoT;
        }

        private void pnlLlenarCamposTDB_MouseClick(object sender, MouseEventArgs e)
        {
            Transporte transporte = new Transporte();

            txtIdTransporte.Text = dgvTransporte.CurrentRow.Cells[0].Value.ToString();
            txtNombreT.Text = dgvTransporte.CurrentRow.Cells[1].Value.ToString();
            txtPlacaTransporte.Text = dgvTransporte.CurrentRow.Cells[3].Value.ToString();
            txtColorTransporte.Text = dgvTransporte.CurrentRow.Cells[4].Value.ToString();
            txtNoChasis.Text = dgvTransporte.CurrentRow.Cells[5].Value.ToString();
            txtModeloTransporte.Text = dgvTransporte.CurrentRow.Cells[6].Value.ToString();
            txtMarcaTransporte.Text = dgvTransporte.CurrentRow.Cells[7].Value.ToString();
            txtPropietarioTransporte.Text = dgvTransporte.CurrentRow.Cells[8].Value.ToString();
            txtEstatusTransporte.Text = dgvTransporte.CurrentRow.Cells[9].Value.ToString();

            String idTipoT = dgvTransporte.CurrentRow.Cells[2].Value.ToString();
            transporte.obtenerNombreTipoTransporte(idTipoT);
            cbxIdTipoTrans.SelectedValue = idTipoT;

            String pIdTransporte = txtIdTransporte.Text;

            String pEstatusTransporte = transporte.funBuscarEstatus(pIdTransporte);

            if (pEstatusTransporte == "A")
            {
                pnlActivarT.Visible = false;
                pnlDarBajaT.Visible = true;
            }
            else if (pEstatusTransporte == "I")
            {
                pnlDarBajaT.Visible = false;
                pnlActivarT.Visible = true;
            }
        }

        private void pnlBotonBuscarT_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarTransporte = txtBuscarTransporte.Text;
            funCargarTabla(buscarTransporte);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlDarBajaT.Visible = false;

            pnlActivarT.Visible = false;
            /* Final Vaciando los campos */
        }

        private void pnlCliente_MouseHover(object sender, EventArgs e)
        {
            pnlCliente.BackColor = colorHoverRuta;
        }

        private void pnlCliente_MouseLeave(object sender, EventArgs e)
        {
            pnlCliente.BackColor = colorNormalRuta;
        }

        private void pnlPuesto_MouseHover(object sender, EventArgs e)
        {
            pnlPuesto.BackColor = colorHoverRuta;
        }

        private void pnlPuesto_MouseLeave(object sender, EventArgs e)
        {
            pnlPuesto.BackColor = colorNormalRuta;
        }

        private void pnlDepartamento_MouseHover(object sender, EventArgs e)
        {
            pnlDepartamento.BackColor = colorHoverRuta;
        }

        private void pnlDepartamento_MouseLeave(object sender, EventArgs e)
        {
            pnlDepartamento.BackColor = colorNormalRuta;
        }

        private void pnlUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlUbicacion.BackColor = colorHoverRuta;
        }

        private void pnlUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlUbicacion.BackColor = colorNormalRuta;
        }

        private void pnlTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pnlTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pnlRuta_MouseHover(object sender, EventArgs e)
        {
            pnlRuta.BackColor = colorHoverRuta;
        }

        private void pnlRuta_MouseLeave(object sender, EventArgs e)
        {
            pnlRuta.BackColor = colorNormalRuta;
        }

        private void pnlSU_MouseHover(object sender, EventArgs e)
        {
            pnlSU.BackColor = colorHoverRuta;
        }

        private void pnlSU_MouseLeave(object sender, EventArgs e)
        {
            pnlSU.BackColor = colorNormalRuta;
        }

        private void pnlTM_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pnlTM_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pnlTT_MouseHover(object sender, EventArgs e)
        {
            pnlTT.BackColor = colorHoverRuta;
        }

        private void pnlTT_MouseLeave(object sender, EventArgs e)
        {
            pnlTT.BackColor = colorNormalRuta;
        }

        private void pnlUsuarios_MouseHover(object sender, EventArgs e)
        {
            pnlUsuarios.BackColor = colorHoverRuta;
        }

        private void pnlUsuarios_MouseLeave(object sender, EventArgs e)
        {
            pnlUsuarios.BackColor = colorNormalRuta;
        }

        private void pnlPE_MouseHover(object sender, EventArgs e)
        {
            pnlPE.BackColor = colorHoverRuta;
        }

        private void pnlPE_MouseLeave(object sender, EventArgs e)
        {
            pnlPE.BackColor = colorNormalRuta;
        }

        private void pnlEmpleado_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverRuta;
        }

        private void pnlEmpleado_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalRuta;
        }

        private void pnlBodega_MouseHover(object sender, EventArgs e)
        {
            pnlBodega.BackColor = colorHoverRuta;
        }

        private void pnlBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlBodega.BackColor = colorNormalRuta;
        }

        private void pnlEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverRuta;
        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalRuta;
        }

        private void pnlPD_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverRuta;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalRuta;
        }

        private void pnlTransporte_MouseHover(object sender, EventArgs e)
        {
            pnlTransporte.BackColor = colorHoverRuta;
        }

        private void pnlTransporte_MouseLeave(object sender, EventArgs e)
        {
            pnlTransporte.BackColor = colorNormalRuta;
        }

        private void pnlCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos obj = new frmPuestos();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento obj = new frmDepartamento();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion obj = new frmUbicacion();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta obj = new frmRuta();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlCliente_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlPuesto_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmPuestos obj = new frmPuestos();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlDepartamento_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmDepartamento obj = new frmDepartamento();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlUbicacion_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmUbicacion obj = new frmUbicacion();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlTipoEmpleado_MouseClick_1(object sender, MouseEventArgs e)
        {
            
        }

        private void pnlRuta_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmRuta obj = new frmRuta();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlSU_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion obj = new frmSubUbicacion();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlTM_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoMovimiento obj = new frmTipoMovimiento();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlTT_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte obj = new frmTipoTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios obj = new frmUsuarios();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlPE_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteEncabezado obj = new frmPaqueteEncabezado();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteDetalle obj = new frmPaqueteDetalle();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlBodega_MouseClick(object sender, MouseEventArgs e)
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

        private void pnlPD_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteDetalle obj = new frmPaqueteDetalle();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();

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
            pnlMovBodega.BackColor = colorHoverRuta;
        }

        private void lblMovimientoBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverRuta;
        }

        private void picMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverRuta;
        }

        private void pnlMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalRuta;
        }

        private void lblMovimientoBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalRuta;
        }

        private void picMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalRuta;
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
            btnPiloto.BackColor = colorHoverRuta;
        }

        private void lblPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverRuta;
        }

        private void picIconoPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverRuta;
        }

        private void btnPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalRuta;
        }

        private void lblPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalRuta;
        }

        private void picIconoPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalRuta;
        }

        private void btnBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverRuta;
        }

        private void lblBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverRuta;
        }

        private void picIconoBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverRuta;
        }

        private void btnBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalRuta;
        }

        private void lblBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalRuta;
        }

        private void picIconoBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalRuta;
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
            btnInventario.BackColor = colorHoverRuta;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorNormalRuta;
        }
    }
}