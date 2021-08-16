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
    public partial class frmPuestos : Form
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

        Color colorHoverPuesto = Color.FromArgb(80, 115, 119);
        Color colorNormalPuesto = Color.FromArgb(59, 102, 107);

        public frmPuestos()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            /*Inicio Esconder contenidos de mi form puestos */
            pnlBordePuesto.Visible = false;
            lblRegistrarPuesto.Visible = false;
            pnlBordeRegistrarP.Visible = false;
            lblModificarPuesto.Visible = false;
            pnlBordeModificarP.Visible = false;
            lblDarBajaP.Visible = false;
            pnlBordeDarBajaP.Visible = false;
            pnlCampoIdP.Visible = false;
            pnlCampoNombreP.Visible = false;
            pnlContenidoEP.Visible = false;
            pnlDarBajaP.Visible = false;
            pnlActivarP.Visible = false;
            txtBuscarPuesto.Visible = false;
            pnlBotonBuscarP.Visible = false;
            dgvPuesto.Visible = false;
            pnlLlenarCamposPDB.Visible = false;
            pnlLLenarCamposP.Visible = false;
            pnlBotonGuardarP.Visible = false;
            pnlModificarP.Visible = false;
            /*Final Esconder contenidos de mi form puestos */

            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;
        }

        private void frmPuestos_Load(object sender, EventArgs e)
        {

        }

        private void frmPuestos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPuesto_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();

            obj.Visible = true;

            Visible = false;
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverPuesto;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalPuesto;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalPuesto;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverPuesto;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverPuesto;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalPuesto;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverPuesto;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalPuesto;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalPuesto;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverPuesto;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverPuesto;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalPuesto;
        }

        private void btnDepartamento_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverPuesto;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalPuesto;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverPuesto;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalPuesto;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverPuesto;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalPuesto;
        }

        private void lblAbcPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio haciedno visibles mis labels y bordes */
            pnlBordePuesto.Visible = true;
            lblRegistrarPuesto.Visible = true;
            lblModificarPuesto.Visible = true;
            lblDarBajaP.Visible = true;
            /* Final haciedno visibles mis labels y bordes */
        }

        private void lblRegistrarPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio cargando datos en tabla Puestos */
            Puesto puesto = new Puesto();
            funCargarTabla(null);

            pnlBordeDarBajaP.Visible = false;
            pnlBordeModificarP.Visible = false;
            pnlBordeRegistrarP.Visible = true;

            /*Inicio Esconder y mostrando contenidos de mi form puestos */
            pnlCampoIdP.Visible = true;
            pnlCampoNombreP.Visible = true;
            pnlContenidoEP.Visible = false;
            pnlDarBajaP.Visible = false;
            pnlActivarP.Visible = false;
            txtBuscarPuesto.Visible = true;
            pnlBotonBuscarP.Visible = true;
            dgvPuesto.Visible = true;
            pnlLlenarCamposPDB.Visible = false;
            pnlLLenarCamposP.Visible = true;
            pnlBotonGuardarP.Visible = true;
            pnlModificarP.Visible = false;
            /*Final Esconder y mostrando contenidos de mi form puestos */

            /*Inicio deshabilitando y habilitando contenidos de mi form puestos */
            pnlCampoIdP.Enabled = true;
            pnlCampoNombreP.Enabled = true;
            txtBuscarPuesto.Enabled = true;
            pnlBotonBuscarP.Enabled = true;
            dgvPuesto.Enabled = true;
            pnlLLenarCamposP.Enabled = true;
            /*Final deshabilitando y habilitando contenidos de mi form puestos */

            funVaciarCampos();
        }

        private void lblModificarPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();
            funCargarTabla(null);

            pnlBordeDarBajaP.Visible = false;
            pnlBordeRegistrarP.Visible = false;
            pnlBordeModificarP.Visible = true;

            /*Inicio Esconder y mostrando contenidos de mi form puestos */
            pnlCampoIdP.Visible = true;
            pnlCampoNombreP.Visible = true;
            pnlContenidoEP.Visible = false;
            pnlDarBajaP.Visible = false;
            pnlActivarP.Visible = false;
            txtBuscarPuesto.Visible = true;
            pnlBotonBuscarP.Visible = true;
            dgvPuesto.Visible = true;
            pnlLlenarCamposPDB.Visible = false;
            pnlLLenarCamposP.Visible = true;
            pnlBotonGuardarP.Visible = false;
            pnlModificarP.Visible = true;

            /*Final Esconder y mostrando contenidos de mi form puestos */

            /*Inicio deshabilitando y habilitando contenidos de mi form puestos */
            pnlCampoIdP.Enabled = false;
            pnlCampoNombreP.Enabled = true;
            txtBuscarPuesto.Enabled = true;
            pnlBotonBuscarP.Enabled = true;
            dgvPuesto.Enabled = true;
            pnlLLenarCamposP.Enabled = true;
            /*Final deshabilitando y habilitando contenidos de mi form puestos */

        }

        private void lblDarBajaP_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();

            pnlBordeRegistrarP.Visible = false;
            pnlBordeModificarP.Visible = false;
            pnlBordeDarBajaP.Visible = true;

            /*Inicio Esconder y mostrando contenidos de mi form puestos */
            pnlCampoIdP.Visible = true;
            pnlCampoNombreP.Visible = true;
            pnlContenidoEP.Visible = true;
            pnlDarBajaP.Visible = false;
            pnlActivarP.Visible = false;
            txtBuscarPuesto.Visible = true;
            pnlBotonBuscarP.Visible = true;
            dgvPuesto.Visible = true;
            pnlLlenarCamposPDB.Visible = true;
            pnlLLenarCamposP.Visible = true;
            pnlBotonGuardarP.Visible = false;
            pnlModificarP.Visible = false;
            pnlLLenarCamposP.Visible = false;
            /*Final Esconder y mostrando contenidos de mi form puestos */

            /*Inicio deshabilitando y habilitando contenidos de mi form puestos */
            pnlCampoIdP.Enabled = false;
            pnlCampoNombreP.Enabled = false;
            txtEstatusPuesto.Enabled = false;
            txtBuscarPuesto.Enabled = true;
            pnlBotonBuscarP.Enabled = true;
            dgvPuesto.Enabled = true;
            pnlLLenarCamposP.Enabled = true;
            /*Final deshabilitando y habilitando contenidos de mi form puestos */

            funCargarTabla(null);
        }

        private void pnlBotonGuardarP_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio de ejecucion de funcion insertar un Puestp */

            if(txtIdPuesto.Text=="" || txtNombrePuesto.Text == "")
            {
                MessageBox.Show("No se pueden ingresar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String estatusPuesto = "A";
                Puesto puesto = funObtenerTxt(estatusPuesto);
                puesto.funInsertar();
                /* Final de ejecucion de funcion insertar un Puesto */

                funCargarTabla(null);
                funVaciarCampos();
            }

            
        }

        public Puesto funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC Puesto */
            String pCodigoP = txtIdPuesto.Text;
            String pNombreP = txtNombrePuesto.Text;
            /*Final obteniedo variables a usar con mi ABC Puesto */

            /* Inicio creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */
            Puesto puesto = new Puesto(pCodigoP,pNombreP,estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */

            return puesto;
        }
        /* Final de funcion para evitar el uso de recursivo de tantas variables */

        /* Inicio funcion para cargar mi tabla de Puesto */
        private void funCargarTabla(string dato)
        {
            List<Puesto> lista = new List<Puesto>();
            Puesto puesto = new Puesto();

            dgvPuesto.DataSource = puesto.consulta(dato);
        }
        /* Final funcion para cargar mi tabla de Puesto */

        /* Inicio de funcion para vaciar mis campos de Puesto */
        public void funVaciarCampos()
        {
            txtIdPuesto.Text = "";
            txtNombrePuesto.Text = "";
            txtEstatusPuesto.Text = "";
            txtBuscarPuesto.Text = "";
        }

        private void pnlBotonBuscarP_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarPuesto = txtBuscarPuesto.Text;
            funCargarTabla(buscarPuesto);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlDarBajaP.Visible = false;
            pnlActivarP.Visible = false;
            /* Final Vaciando los campos */
        }

        /* Inicio Llenando campos de mi busqueda en la tabla */
        private void pnlLLenarCamposP_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdPuesto.Text = dgvPuesto.CurrentRow.Cells[0].Value.ToString();
            txtNombrePuesto.Text = dgvPuesto.CurrentRow.Cells[1].Value.ToString();
            txtEstatusPuesto.Text = dgvPuesto.CurrentRow.Cells[2].Value.ToString();
        }

        private void pnlModificarP_MouseClick(object sender, MouseEventArgs e)
        {
            String estatusPuesto = "A";
            String idPuesto = txtIdPuesto.Text;
            Puesto puesto = funObtenerTxt(estatusPuesto);

            puesto.funModificar(idPuesto);
            funCargarTabla(null);
            puesto.funBuscarSetearTxt(txtIdPuesto, txtNombrePuesto, txtEstatusPuesto, idPuesto);
        }

        private void pnlLlenarCamposPDB_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdPuesto.Text = dgvPuesto.CurrentRow.Cells[0].Value.ToString();
            txtNombrePuesto.Text = dgvPuesto.CurrentRow.Cells[1].Value.ToString();
            txtEstatusPuesto.Text = dgvPuesto.CurrentRow.Cells[2].Value.ToString();

            Puesto puesto = new Puesto();
            String pidPuesto = txtIdPuesto.Text;
            String pestatusPuesto = puesto.funBuscarEstatus(pidPuesto);

            if (pestatusPuesto == "A")
            {
                pnlActivarP.Visible = false;
                pnlDarBajaP.Visible = true;
            }
            else if (pestatusPuesto == "I")
            {
                pnlDarBajaP.Visible = false;
                pnlActivarP.Visible = true;
            }
        }

        private void pnlActivarP_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdPuesto = txtIdPuesto.Text;
            Puesto puesto = funObtenerTxt(estatus);

            puesto.funActivarPuesto();
            funCargarTabla(null);

            pnlDarBajaP.Visible = true;
            pnlActivarP.Visible = false;

           puesto.funBuscarSetearTxt(txtIdPuesto, txtNombrePuesto, txtEstatusPuesto, pIdPuesto);
        }

        private void pnlDarBajaP_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdPuesto = txtIdPuesto.Text;
            Puesto puesto = funObtenerTxt(estatus);

            puesto.funDarBajaPuesto();
            funCargarTabla(null);

            pnlActivarP.Visible = true;
            pnlDarBajaP.Visible = false;

            puesto.funBuscarSetearTxt(txtIdPuesto, txtNombrePuesto, txtEstatusPuesto, pIdPuesto);
        }

        private void lblPuesto_Click(object sender, EventArgs e)
        {

        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Paint(object sender, PaintEventArgs e)
        {

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
            btnUbicacion.BackColor = colorHoverPuesto;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalPuesto;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverPuesto;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalPuesto;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverPuesto;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalPuesto;
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

        private void btnTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void lblTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void picTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dgvPuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlLLenarCamposP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBotonBuscarP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscarPuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlLlenarCamposPDB_Paint(object sender, PaintEventArgs e)
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
            pnlSubUbicacion.BackColor = colorHoverPuesto;
        }

        private void pnlSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalPuesto;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverPuesto;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalPuesto;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverPuesto;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalPuesto;
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

        private void panel3_MouseClick(object sender, MouseEventArgs e)
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

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverPuesto;
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverPuesto;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverPuesto;
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
            btnRuta.BackColor = colorNormalPuesto;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalPuesto;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalPuesto;
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
            frmTipoTransporte objTipoT = new frmTipoTransporte();

            objTipoT.Visible = true;
            Visible = false;
        }

        private void btnTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverPuesto;
        }

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalPuesto;
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverPuesto;
        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalPuesto;
        }

        private void picIconoTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte obj = new frmTipoTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverPuesto;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalPuesto;
        }

        private void lblTipoTransporte_MouseClick(object sender, MouseEventArgs e)
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
            btnPaqueteEncabezado.BackColor = colorHoverPuesto;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverPuesto;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverPuesto;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalPuesto;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverPuesto;
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverPuesto;
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
            btnBodega.BackColor = colorHoverPuesto;
        }

        private void lblBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverPuesto;
        }

        private void picBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverPuesto;
        }

        private void btnBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalPuesto;
        }

        private void lblBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalPuesto;
        }

        private void picBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalPuesto;
        }

        private void label12_MouseClick(object sender, MouseEventArgs e)
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
            pnlEnvio.BackColor = colorHoverPuesto;
        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalPuesto;
        }

        private void lblEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverPuesto;
        }

        private void lblEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalPuesto;
        }

        private void picEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverPuesto;
        }

        private void picEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalPuesto;
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
            pnlMovBodega.BackColor = colorHoverPuesto;
        }

        private void lblMovimientoBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverPuesto;
        }

        private void picMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverPuesto;
        }

        private void pnlMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalPuesto;
        }

        private void lblMovimientoBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalPuesto;
        }

        private void picMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalPuesto;
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverPuesto;
        }

        private void lblUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverPuesto;
        }

        private void picIconoUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverPuesto;
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalPuesto;
        }

        private void lblUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalPuesto;
        }

        private void picIconoUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalPuesto;
        }

        private void btnCalificacionP_MouseClick(object sender, MouseEventArgs e)
        {
           
            frmCalificacionPiloto obj = new frmCalificacionPiloto();
            obj.Visible = true;

            Visible = false;
        }

        private void lblCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverPuesto;
        }

        private void picCalificacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmCalificacionPiloto obj = new frmCalificacionPiloto();
            obj.Visible = true;

            Visible = false;
        }

        private void btnCalificacionP_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverPuesto;
        }

        private void lblCalificacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmCalificacionPiloto obj = new frmCalificacionPiloto();
            obj.Visible = true;

            Visible = false;
        }

        private void picCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverPuesto;
        }

        private void btnCalificacionP_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalPuesto;
        }

        private void lblCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalPuesto;
        }

        private void picCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalPuesto;
        }

        private void btnPil_MouseClick(object sender, MouseEventArgs e)
        {
            frmPiloto obj = new frmPiloto();

            obj.Visible = true;

            Visible = false;
        }

        private void lblPil_MouseClick(object sender, MouseEventArgs e)
        {
            frmPiloto obj = new frmPiloto();

            obj.Visible = true;

            Visible = false;
        }

        private void picIconoPil_MouseClick(object sender, MouseEventArgs e)
        {
            frmPiloto obj = new frmPiloto();

            obj.Visible = true;

            Visible = false;
        }

        private void btnBT_MouseClick(object sender, MouseEventArgs e)
        {
            frmBitacoraTransporte obj = new frmBitacoraTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void lblBT_MouseClick(object sender, MouseEventArgs e)
        {
            frmBitacoraTransporte obj = new frmBitacoraTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void picIconoBT_MouseClick(object sender, MouseEventArgs e)
        {
            frmBitacoraTransporte obj = new frmBitacoraTransporte();

            obj.Visible = true;

            Visible = false;
        }

        private void btnPil_MouseHover(object sender, EventArgs e)
        {
            btnPil.BackColor = colorHoverPuesto;
        }

        private void lblPil_MouseHover(object sender, EventArgs e)
        {
            btnPil.BackColor = colorHoverPuesto;
        }

        private void picIconoPil_MouseHover(object sender, EventArgs e)
        {
            btnPil.BackColor = colorHoverPuesto;
        }

        private void btnPil_MouseLeave(object sender, EventArgs e)
        {
            btnPil.BackColor = colorNormalPuesto;
        }

        private void lblPil_MouseLeave(object sender, EventArgs e)
        {
            btnPil.BackColor = colorNormalPuesto;
        }

        private void picIconoPil_MouseLeave(object sender, EventArgs e)
        {
            btnPil.BackColor = colorNormalPuesto;
        }

        private void btnBT_MouseHover(object sender, EventArgs e)
        {
            btnBT.BackColor = colorHoverPuesto;
        }

        private void lblBT_MouseHover(object sender, EventArgs e)
        {
            btnBT.BackColor = colorHoverPuesto;
        }

        private void picIconoBT_MouseHover(object sender, EventArgs e)
        {
            btnBT.BackColor = colorHoverPuesto;
        }

        private void btnBT_MouseLeave(object sender, EventArgs e)
        {
            btnBT.BackColor = colorNormalPuesto;
        }

        private void lblBT_MouseLeave(object sender, EventArgs e)
        {
            btnBT.BackColor = colorNormalPuesto;
        }

        private void picIconoBT_MouseLeave(object sender, EventArgs e)
        {
            btnBT.BackColor = colorNormalPuesto;
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
            pnlPD.BackColor = colorHoverPuesto;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalPuesto;
        }

        private void pnlTrans_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverPuesto;
        }

        private void pnlTrans_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalPuesto;
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
            btnInventario.BackColor = colorHoverPuesto;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorNormalPuesto;
        }
    }
        /* Final Llenando campos de mi busqueda en la tabla */

    
}
