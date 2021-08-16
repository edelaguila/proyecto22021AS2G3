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
    public partial class frmTipoTransporte : Form
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
        Color colorHoverTipoReparto = Color.FromArgb(80, 115, 119);
        Color colorNormalTipoReparto = Color.FromArgb(59, 102, 107);

        /* Codigo para mover mi panel */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmTipoTransporte()
        {
            InitializeComponent();
            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            /*Oculto todos los elementos al ingresar*/
            pnlBordeTipoReparto.Visible = false;
            lblRegistrarTipoReparto.Visible = false;
            pnlBordeRegistrarTR.Visible = false;
            lblModificarTipoReparto.Visible = false;
            pnlBordeModificarTR.Visible = false;
            lblDarBajaTipoReparto.Visible = false;
            pnlBordeDarBajaTR.Visible = false;
            pnlCampoId.Visible = false;
            pnlCampoNombreTR.Visible = false;
            pnlCampoETR.Visible = false;
            txtBuscarTipoTransporte.Visible = false;
            pnlBotonBuscarTR.Visible = false;
            dgvTipoReparto.Visible = false;

            pnlModificarTR.Visible = false;
            pnlBotonGuardarTR.Visible = false;
            pnlActivarTT.Visible = false;
            pnlDarBajaTT.Visible = false;
            pnlLlenarCamposTRDB.Visible = false;
            pnlLLenarCamposTR.Visible = false;

            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;

        }

        private void frmTipoTransporte_Load(object sender, EventArgs e)
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

        private void lblTituloDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void frmTipoTransporte_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblAbcTipoReparto_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeTipoReparto.Visible = true;
            lblRegistrarTipoReparto.Visible = true;
            lblModificarTipoReparto.Visible = true;
            lblDarBajaTipoReparto.Visible = true;
        }

        private void lblRegistrarTipoReparto_MouseClick(object sender, MouseEventArgs e)
        {

            /* Inicio cargando datos en tabla Departamentos */
            TipoTransporte tipoTransporte = new TipoTransporte();
            funCargarTabla(null);


            pnlBordeRegistrarTR.Visible = true;
            pnlCampoId.Visible = true;
            pnlCampoNombreTR.Visible = true;
            pnlCampoETR.Visible = false;
            pnlLLenarCamposTR.Visible = true;
            txtBuscarTipoTransporte.Visible = true;
            pnlBotonBuscarTR.Visible = true;
            dgvTipoReparto.Visible = true;
            pnlBotonGuardarTR.Visible = true;
            pnlBordeModificarTR.Visible = false;
            pnlModificarTR.Visible = false;
            pnlBordeDarBajaTR.Visible = false;
            pnlLlenarCamposTRDB.Visible = false;
            pnlActivarTT.Visible = false;
            pnlDarBajaTT.Visible = false;




            /*inicio deshabilitando y habilitando contenidos de mi form */
            pnlCampoId.Enabled = true;
            pnlCampoNombreTR.Enabled = true;
            txtBuscarTipoTransporte.Enabled = true;
            pnlBotonBuscarTR.Enabled = true;
            dgvTipoReparto.Enabled = true;
            pnlLLenarCamposTR.Enabled = true;

            funVaciarCampos();
        }

        private void pnlBotonGuardarTR_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtIdTipoTransporte.Text == "" || txtNombreTipoTransporte.Text == "")
            {
                MessageBox.Show("No se pueden dejar campos vacios ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /* Inicio de ejecucion de funcion insertar un Tipo Transporte */
                String EstatusTipoTransporte = "A";
                TipoTransporte tipoTransporte = funObtenerTxt(EstatusTipoTransporte);
                tipoTransporte.funInsertar();
                /* Final de ejecucion de funcion insertar un Tipo Transporte */

                funCargarTabla(null);
                funVaciarCampos();
            }
        }



        public void funVaciarCampos()
        {
            txtIdTipoTransporte.Text = "";
            txtNombreTipoTransporte.Text = "";
            txtEstatusTipoTransporte.Text = "";
            txtBuscarTipoTransporte.Text = "";
        }

        /* Inicio funcion para cargar mi tabla de tipoTransporte */
        private void funCargarTabla(string dato)
        {
            List<TipoTransporte> lista = new List<TipoTransporte>();
            TipoTransporte tipoTransporte = new TipoTransporte();

            dgvTipoReparto.DataSource = tipoTransporte.consulta(dato);
        }
        /* Final funcion para cargar mi tabla de tipoTransporte */
        public TipoTransporte funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC tipoTransporte */
            String pCodigoTT = txtIdTipoTransporte.Text;
            String pNombreTT = txtNombreTipoTransporte.Text;
            /*Final obteniedo variables a usar con mi ABC tipoTransporte */

            /* Inicio creamos un objeto de tipo cliente para poder utilizar el metodo de insertar tipoTransporte */
            TipoTransporte tipoTransporte = new TipoTransporte(pCodigoTT, pNombreTT, estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar tipoTransporte */

            return tipoTransporte;
        }


        private void pnlBotonBuscarD_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarTipoTransporte = txtBuscarTipoTransporte.Text;
            funCargarTabla(buscarTipoTransporte);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlDarBajaTT.Visible = false;

            pnlActivarTT.Visible = false;
            /* Final Vaciando los campos */
        }

        private void lblModificarTipoReparto_MouseClick(object sender, MouseEventArgs e)
        {

            funVaciarCampos();
            funCargarTabla(null);


            pnlBordeModificarTR.Visible = true;
            pnlCampoId.Visible = true;
            pnlCampoNombreTR.Visible = true;
            pnlCampoETR.Visible = false;
            pnlLLenarCamposTR.Visible = true;
            txtBuscarTipoTransporte.Visible = true;
            pnlBotonBuscarTR.Visible = true;
            dgvTipoReparto.Visible = true;
            pnlBotonGuardarTR.Visible = false;
            pnlModificarTR.Visible = true;
            pnlBordeRegistrarTR.Visible = false;
            pnlBordeDarBajaTR.Visible = false;
            pnlLlenarCamposTRDB.Visible = false;
            pnlActivarTT.Visible = false;
            pnlDarBajaTT.Visible = false;


            /*inicio deshabilitando y habilitando contenidos de mi form */
            pnlCampoId.Enabled = false;
            pnlCampoNombreTR.Enabled = true;
            txtBuscarTipoTransporte.Enabled = true;
            pnlBotonBuscarTR.Enabled = true;
            dgvTipoReparto.Enabled = true;
            pnlLLenarCamposTR.Enabled = true;
        }

        private void lblDarBajaTipoReparto_MouseClick(object sender, MouseEventArgs e)
        {

            funVaciarCampos();
            pnlBordeDarBajaTR.Visible = true;

            pnlBordeModificarTR.Visible = false;
            pnlCampoId.Visible = true;
            pnlCampoNombreTR.Visible = true;
            pnlCampoETR.Visible = true;
            pnlLLenarCamposTR.Visible = false;
            txtBuscarTipoTransporte.Visible = true;
            pnlBotonBuscarTR.Visible = true;
            dgvTipoReparto.Visible = true;
            pnlBotonGuardarTR.Visible = false;
            pnlModificarTR.Visible = false;
            pnlBordeRegistrarTR.Visible = false;
            pnlLlenarCamposTRDB.Visible = true;
            pnlActivarTT.Visible = false;
            pnlDarBajaTT.Visible = false;

            /*inicio deshabilitando y habilitando contenidos de mi form */
            pnlCampoId.Enabled = false;
            pnlCampoNombreTR.Enabled = false;
            txtBuscarTipoTransporte.Enabled = true;
            pnlBotonBuscarTR.Enabled = true;
            dgvTipoReparto.Enabled = true;
            pnlLLenarCamposTR.Enabled = true;
            pnlCampoETR.Enabled = false;

            funCargarTabla(null);
        }

        private void pnlModificarTR_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverTipoReparto;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalTipoReparto;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverTipoReparto;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalTipoReparto;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverTipoReparto;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalTipoReparto;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverTipoReparto;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalTipoReparto;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverTipoReparto;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalTipoReparto;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverTipoReparto;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalTipoReparto;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverTipoReparto;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalTipoReparto;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverTipoReparto;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalTipoReparto;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverTipoReparto;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalTipoReparto;
        }

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverTipoReparto;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalTipoReparto;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverTipoReparto;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalTipoReparto;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverTipoReparto;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalTipoReparto;
        }

        private void btnTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverTipoReparto;
        }

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalTipoReparto;
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverTipoReparto;
        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalTipoReparto;
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverTipoReparto;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalTipoReparto;
        }

        private void pnlBotonGuardarTR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLLenarCamposTR_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdTipoTransporte.Text = dgvTipoReparto.CurrentRow.Cells[0].Value.ToString();
            txtNombreTipoTransporte.Text = dgvTipoReparto.CurrentRow.Cells[1].Value.ToString();
            txtEstatusTipoTransporte.Text = dgvTipoReparto.CurrentRow.Cells[2].Value.ToString();
        }

        private void pnlModificarTR_MouseClick(object sender, MouseEventArgs e)
        {
            String EstatusTipoTransporte = "A";
            String IdTipoTransporte = txtIdTipoTransporte.Text;
            TipoTransporte tipoTransporte = funObtenerTxt(EstatusTipoTransporte);

            tipoTransporte.funModificar(IdTipoTransporte);
            funCargarTabla(null);
            tipoTransporte.funBuscarSetearTxt(txtIdTipoTransporte, txtNombreTipoTransporte, txtEstatusTipoTransporte, IdTipoTransporte);
        }

        private void pnlLlenarCamposTRDB_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdTipoTransporte.Text = dgvTipoReparto.CurrentRow.Cells[0].Value.ToString();
            txtNombreTipoTransporte.Text = dgvTipoReparto.CurrentRow.Cells[1].Value.ToString();
            txtEstatusTipoTransporte.Text = dgvTipoReparto.CurrentRow.Cells[2].Value.ToString();

            TipoTransporte tipoTransporte = new TipoTransporte();
            String pIdTipoTransporte = txtIdTipoTransporte.Text;
            String pEstatusTipoTransporte = tipoTransporte.funBuscarEstatus(pIdTipoTransporte);

            if (pEstatusTipoTransporte == "A")
            {
                pnlActivarTT.Visible = false;
                pnlDarBajaTT.Visible = true;
            }
            else if (pEstatusTipoTransporte == "I")
            {
                pnlDarBajaTT.Visible = false;
                pnlActivarTT.Visible = true;
            }
        }

        private void pnlActivarTT_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdTipoTransporte = txtIdTipoTransporte.Text;
            TipoTransporte tipoTransporte = funObtenerTxt(estatus);

            tipoTransporte.funActivarTipoTransporte();
            funCargarTabla(null);

            pnlDarBajaTT.Visible = true;
            pnlActivarTT.Visible = false;

            tipoTransporte.funBuscarSetearTxt(txtIdTipoTransporte, txtNombreTipoTransporte, txtEstatusTipoTransporte, pIdTipoTransporte);

        }

        private void pnlDarBajaTT_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdTipoTransporte = txtIdTipoTransporte.Text;
            TipoTransporte tipoTransporte = funObtenerTxt(estatus);

            tipoTransporte.funDarBajaTipoTransporte();
            funCargarTabla(null);

            pnlActivarTT.Visible = true;
            pnlDarBajaTT.Visible = false;


            tipoTransporte.funBuscarSetearTxt(txtIdTipoTransporte, txtNombreTipoTransporte, txtEstatusTipoTransporte, pIdTipoTransporte);

        }

        private void pnlBotonBuscarTR_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarTipoTransporte = txtBuscarTipoTransporte.Text;
            funCargarTabla(buscarTipoTransporte);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlDarBajaTT.Visible = false;
            

            pnlActivarTT.Visible = false;
            /* Final Vaciando los campos */
           
        }

        private void btnTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverTipoReparto;
        }

        private void btnTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalTipoReparto;
        }

        private void lblTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverTipoReparto;
        }

        private void lblTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalTipoReparto;
        }

        private void picTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverTipoReparto;
        }

        private void picTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalTipoReparto;
        }

        private void btnRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta obj = new frmRuta();

            obj.Visible = true;

            Visible = false;
        }

        private void btnRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverTipoReparto;
        }

        private void btnRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalTipoReparto;
        }

        private void lblRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverTipoReparto;
        }

        private void lblRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalTipoReparto;

        }

        private void picRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverTipoReparto;
        }

        private void picRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalTipoReparto;
        }

        private void pnlSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion obj = new frmSubUbicacion();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverTipoReparto; 
        }

        private void pnlSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalTipoReparto;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverTipoReparto;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalTipoReparto;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverTipoReparto;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalTipoReparto;
        }

        private void btnTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoMovimiento obj = new frmTipoMovimiento();

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

        private void btnTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte obj = new frmTipoTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void lblTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void picTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            

            
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

        private void lblUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.Visible = true;

            Visible = false;
        }

        private void btnUsuarios_MouseClick(object sender, MouseEventArgs e)
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
            btnPaqueteEncabezado.BackColor = colorHoverTipoReparto;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverTipoReparto;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverTipoReparto;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalTipoReparto;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalTipoReparto;
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalTipoReparto;
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
            btnBodega.BackColor = colorHoverTipoReparto;
        }

        private void lblBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverTipoReparto;
        }

        private void picBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverTipoReparto;
        }

        private void btnBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalTipoReparto;
        }

        private void lblBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalTipoReparto;
        }

        private void picBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalTipoReparto;
        }

        private void pnlEmpleado_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverTipoReparto;
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverTipoReparto;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverTipoReparto;
        }

        private void pnlEmpleado_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalTipoReparto;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalTipoReparto;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalTipoReparto;
        }

        private void label10_MouseClick(object sender, MouseEventArgs e)
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
            pnlEnvio.BackColor = colorHoverTipoReparto;
        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalTipoReparto;
        }

        private void lblEnvio_MouseEnter(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverTipoReparto;
        }

        private void lblEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalTipoReparto;
        }

        private void picEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverTipoReparto;
        }

        private void picEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalTipoReparto;
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
            pnlMovBodega.BackColor = colorHoverTipoReparto;
        }

        private void lblMovimientoBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverTipoReparto;
        }

        private void picMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverTipoReparto;
        }

        private void pnlMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalTipoReparto;
        }

        private void lblMovimientoBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalTipoReparto;
        }

        private void picMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalTipoReparto;
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverTipoReparto;
        }

        private void lblUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverTipoReparto;
        }

        private void picIconoUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverTipoReparto;
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalTipoReparto;
        }

        private void lblUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalTipoReparto;
        }

        private void picIconoUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalTipoReparto;
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
            btnCalificacionP.BackColor = colorHoverTipoReparto;
        }

        private void lblCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverTipoReparto;
        }

        private void picCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverTipoReparto;
        }

        private void btnCalificacionP_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalTipoReparto;
        }

        private void lblCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalTipoReparto;
        }

        private void picCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalTipoReparto;
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
            btnPiloto.BackColor = colorHoverTipoReparto;
        }

        private void lblPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverTipoReparto;
        }

        private void picIconoPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverTipoReparto;
        }

        private void btnPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalTipoReparto;
        }

        private void lblPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalTipoReparto;
        }

        private void picIconoPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalTipoReparto;
        }

        private void btnBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverTipoReparto;
        }

        private void lblBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverTipoReparto;
        }

        private void picIconoBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverTipoReparto;
        }

        private void btnBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalTipoReparto;
        }

        private void lblBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalTipoReparto;
        }

        private void picIconoBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalTipoReparto;
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
            pnlPD.BackColor = colorHoverTipoReparto;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalTipoReparto;
        }

        private void pnlTrans_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
            obj.Visible = true;
            Visible = false;
        }

        private void pnlTrans_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverTipoReparto;
        }

        private void pnlTrans_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalTipoReparto;
        }

        private void btnInventario_MouseClick(object sender, MouseEventArgs e)
        {
            frmInventario obj = new frmInventario();
            obj.Visible = true;
            Visible = false;
        }

        private void btnInventario_MouseHover(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorHoverTipoReparto;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorNormalTipoReparto;
        }
    }
}
