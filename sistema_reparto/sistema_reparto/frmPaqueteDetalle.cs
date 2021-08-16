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
    public partial class frmPaqueteDetalle : Form
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
        Color colorHoverCliente = Color.FromArgb(80, 115, 119);
        Color colorNormalCliente = Color.FromArgb(59, 102, 107);

        public frmPaqueteDetalle()
        {
            InitializeComponent();
            PaqueteDetalle paqueteDetalle = new PaqueteDetalle();
            paqueteDetalle.funLlenarComboTE(cbxPE, "paqueteEncabezado", "idPaqueteEncabezado", "idPaqueteEncabezado");
            paqueteDetalle.funLlenarComboTE(cbxIdCliente, "cliente", "idCliente", "nombreCliente");
            paqueteDetalle.funLlenarComboTE(cbxIdEmpleado, "empleado", "idEmpleado", "nombreEmpleado");



            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblTituloPaqueDet.Visible = true;
            pnlBordePaqDet.Visible = false;
            lblAbcEmpleado.Visible = true;
            lblRegistrarPaqDet.Visible = false;
            pnlBordeRegistrarPD.Visible = false;
            pnlCampoIDPE.Visible = false;
            pnlCampoIdCliente.Visible = false;
            pnlCampoIdCliente.Visible = false;
            pnlCampoIdEmpleado.Visible = false;
            pnlCampoIdOrden.Visible = false;
            pnlCampoDP.Visible = false;
            dgvPD.Visible = false;
            txtBuscarPD.Visible = false;
            pnlBotonGuardarPD.Visible = false;
            pnlModificarPD.Visible = false;
            pnlLlenarCamposPDDB.Visible = false;
            pnlLLenarCamposPD.Visible = false;
            pnlEliminar.Visible = false;
            pnlBotonBuscarPD.Visible = false;
            pnlBordeDarBajaPD.Visible = false;
            pnlBordeModificarPD.Visible = false;
            lblModificarPaqDet.Visible = false;
            lblEliminarPD.Visible = false;


        }


        /* Codigo para mover mi panel */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmPaqueteDetalle_Load(object sender, EventArgs e)
        {
            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;
        }

        private void frmPaqueteDetalle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblAbcEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordePaqDet.Visible = true;
            lblRegistrarPaqDet.Visible = true;
            lblModificarPaqDet.Visible = true;
            lblEliminarPD.Visible = true;
           

        }

        private void lblRegistrarPaqDet_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio cargando datos en tabla Ruta */
            PaqueteDetalle paqueteDetalle = new PaqueteDetalle();
            funCargarTabla(null);

            pnlBordeRegistrarPD.Visible = true;
            lblModificarPaqDet.Visible = true;
            pnlBordeModificarPD.Visible = false;
            lblEliminarPD.Visible = true;
            pnlBordeDarBajaPD.Visible = false;
            pnlCampoIDPE.Visible = true;
            pnlCampoIdCliente.Visible = true;
            pnlCampoIdEmpleado.Visible = true;
            pnlCampoIdOrden.Visible = true;
            pnlCampoDP.Visible = true;
            dgvPD.Visible = true;
            txtBuscarPD.Visible = true;
            pnlEliminar.Visible = false;
            pnlModificarPD.Visible = false;
            pnlBotonGuardarPD.Visible = true;
            pnlBotonBuscarPD.Visible = true;
            pnlLLenarCamposPD.Visible = true;
            pnlLlenarCamposPDDB.Visible = false;
            pnlCampoIdOrden.Visible = false;
            pnlCampoIdOrden.Enabled = false;
            cbxPE.Enabled = true;
            cbxIdCliente.Enabled = true;
            cbxIdEmpleado.Enabled = true;
            richDescProd.Enabled = true;


        }

        private void lblModificarPaqDet_MouseClick(object sender, MouseEventArgs e)
        {
            PaqueteDetalle paqueteDetalle = new PaqueteDetalle();
            funCargarTabla(null);

            pnlBordeRegistrarPD.Visible = false;
            lblModificarPaqDet.Visible = true;
            pnlBordeModificarPD.Visible = true;
            lblEliminarPD.Visible = true;
            pnlBordeDarBajaPD.Visible = false;
            pnlCampoIDPE.Visible = true;
            pnlCampoIdCliente.Visible = true;
            pnlCampoIdEmpleado.Visible = true;
            pnlCampoIdOrden.Visible = true;
            pnlCampoDP.Visible = true;
            dgvPD.Visible = true;
            txtBuscarPD.Visible = true;
            pnlEliminar.Visible = false;
            pnlModificarPD.Visible = true;
            pnlBotonGuardarPD.Visible = false;
            pnlBotonBuscarPD.Visible = true;
            pnlLLenarCamposPD.Visible = true;
            pnlLlenarCamposPDDB.Visible = false;
            pnlCampoIdOrden.Enabled = false;
            pnlCampoIdOrden.Visible = true;



        }

        private void lblEliminarPD_MouseClick(object sender, MouseEventArgs e)
        {
            PaqueteDetalle paqueteDetalle = new PaqueteDetalle();
            funCargarTabla(null);
            funVaciarCampos();

            pnlBordeRegistrarPD.Visible = false;
            lblModificarPaqDet.Visible = true;
            pnlBordeModificarPD.Visible = false;
            lblEliminarPD.Visible = true;
            pnlBordeDarBajaPD.Visible = true;
            pnlCampoIDPE.Visible = true;
            pnlCampoIdCliente.Visible = true;
            pnlCampoIdEmpleado.Visible = true;
            pnlCampoIdOrden.Visible = true;
            pnlCampoDP.Visible = true;
            dgvPD.Visible = true;
            txtBuscarPD.Visible = true;
            pnlEliminar.Visible = false;
            pnlModificarPD.Visible = false;
            pnlBotonGuardarPD.Visible = false;
            pnlBotonBuscarPD.Visible = true;
            pnlBotonGuardarPD.Visible = false;
            pnlLLenarCamposPD.Visible = true;
            pnlEliminar.Visible = true;
            pnlLlenarCamposPDDB.Visible = false;
            pnlLLenarCamposPD.Visible = true;
            pnlCampoIdOrden.Visible = true;

            pnlCampoIdOrden.Enabled = true;
            cbxPE.Enabled = false;
            cbxIdCliente.Enabled = false;
            cbxIdEmpleado.Enabled = false;
            richDescProd.Enabled = false;
        }

        private void funCargarTabla(string dato)
        {
            List<Ruta> lista = new List<Ruta>();
            PaqueteDetalle paqueteDetalle = new PaqueteDetalle();

            dgvPD.DataSource = paqueteDetalle.consulta(dato);
        }

        private void pnlBotonBuscarE_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarPD = txtBuscarPD.Text;
            funCargarTabla(buscarPD);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();

            /* Final Vaciando los campos */
        }

        public void funVaciarCampos()
        {
            cbxPE.SelectedItem = "";
            cbxIdCliente.SelectedItem = "";
            cbxIdEmpleado.SelectedItem = "";
            txtIdOrden.Text = "";
            richDescProd.Text = "";
        }/*
        private void pnlBotonGuardarE_MouseClick(object sender, MouseEventArgs e)
        {
            /*///* //Inicio de ejecucion de funcion insertar un empleado */
            //String OrdenNum = "A";
            //PaqueteDetalle paqueteDetalle = funObtenerTxt(OrdenNum);
            //paqueteDetalle.funInsertar();
            ///* Final de ejecucion de funcion insertar un empleado */
            //funCargarTabla(null);
            //funVaciarCampos();
        //}

        public PaqueteDetalle funObtenerTxt()
        {
            /*Inicio obteniedo variables a usar con mi ABC empleado */
            String pIdPE = cbxPE.SelectedValue.ToString();
            String pIdCliente = cbxIdCliente.SelectedValue.ToString();
            String pIdE = cbxIdEmpleado.SelectedValue.ToString();
            String pIdOrde = "0";
            String pDescProd = richDescProd.Text;

            /*Final obteniedo variables a usar con mi ABC Departamento */

            /* Inicio creamos un objeto de tipo empleado para poder utilizar el metodo de insertar Ruta */
            PaqueteDetalle paqueteDetalle = new PaqueteDetalle(pIdPE, pIdCliente, pIdE, pIdOrde, pDescProd);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar Ruta */

            return paqueteDetalle;
        }

        private void pnlBotonGuardarPD_MouseClick(object sender, MouseEventArgs e)
        {
            funCargarTabla(null);
            //funVaciarCampos();
            /* Inicio de ejecucion de funcion insertar un empleado */
            //String ordena = "0";
            PaqueteDetalle paqueteDetalle = funObtenerTxt();
            paqueteDetalle.funInsertar();
            /* Final de ejecucion de funcion insertar un empleado */
            funCargarTabla(null);
            funVaciarCampos();
        }

        private void pnlLLenarCamposPD_MouseClick(object sender, MouseEventArgs e)
        {
            PaqueteDetalle paqueteDetalle = new PaqueteDetalle();

            //cbxPE.Text = dgvPD.CurrentRow.Cells[0].Value.ToString();
            //cbxIdCliente.Text = dgvPD.CurrentRow.Cells[1].Value.ToString();
            //cbxIdEmpleado.Text = dgvPD.CurrentRow.Cells[2].Value.ToString();
            cbxPE.SelectedValue = dgvPD.CurrentRow.Cells[0].Value.ToString();
            txtIdOrden.Text = dgvPD.CurrentRow.Cells[3].Value.ToString();
            richDescProd.Text = dgvPD.CurrentRow.Cells[4].Value.ToString();

            String idCliente = dgvPD.CurrentRow.Cells[1].Value.ToString();
            String idEmpleado = dgvPD.CurrentRow.Cells[2].Value.ToString();

            paqueteDetalle.obtenerNombreCliente(idCliente);
            cbxIdCliente.SelectedValue = idCliente;

            paqueteDetalle.obtenerNombreEmpleado(idEmpleado);
            cbxIdEmpleado.SelectedValue = idEmpleado;



        }

        private void pnlModificarPD_MouseClick(object sender, MouseEventArgs e)
        {
            String idOrden = txtIdOrden.Text;
            PaqueteDetalle paqueteDetalle = funObtenerTxt();

            paqueteDetalle.funModificar(idOrden);
            funCargarTabla(null);
            paqueteDetalle.funBuscarSetearTxt(cbxPE, cbxIdCliente, cbxIdEmpleado, txtIdOrden, richDescProd, idOrden);
        }

        private void pnlEliminar_MouseClick(object sender, MouseEventArgs e)
        {
            String idOrden = txtIdOrden.Text;
            PaqueteDetalle paqueteDetalle = funObtenerTxt();

            paqueteDetalle.funEliminar(idOrden);
            funCargarTabla(null);
            paqueteDetalle.funBuscarSetearTxt(cbxPE, cbxIdCliente, cbxIdEmpleado, txtIdOrden, richDescProd, idOrden);
        }

        private void txtBuscarPD_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlBotonBuscarPD_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarPD = txtBuscarPD.Text;
            funCargarTabla(buscarPD);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            /* Final Vaciando los campos */
        }

        private void richDescProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();
            obj.Visible = true;
            Visible = false;
        }

        private void pnlCliente_MouseHover(object sender, EventArgs e)
        {
            pnlCliente.BackColor = colorHoverCliente;
        }

        private void pnlCliente_MouseLeave(object sender, EventArgs e)
        {
            pnlCliente.BackColor = colorNormalCliente;
        }

        private void label43_MouseHover(object sender, EventArgs e)
        {
            pnlCliente.BackColor = colorHoverCliente;
        }

        private void label43_MouseLeave(object sender, EventArgs e)
        {
            pnlCliente.BackColor = colorNormalCliente;
        }

        private void pictureBox17_MouseHover(object sender, EventArgs e)
        {
            pnlCliente.BackColor = colorHoverCliente;
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pnlCliente.BackColor = colorNormalCliente;
        }

        private void pnlPuesto_MouseHover(object sender, EventArgs e)
        {
            pnlPuesto.BackColor = colorHoverCliente;
        }

        private void pnlPuesto_MouseLeave(object sender, EventArgs e)
        {
            pnlPuesto.BackColor = colorNormalCliente;
        }

        private void label39_MouseHover(object sender, EventArgs e)
        {
            pnlPuesto.BackColor = colorHoverCliente;
        }

        private void label39_MouseLeave(object sender, EventArgs e)
        {
            pnlPuesto.BackColor = colorNormalCliente;
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pnlPuesto.BackColor = colorNormalCliente;
        }

        private void pnlDepartamento_MouseHover(object sender, EventArgs e)
        {
            pnlDepartamento.BackColor = colorHoverCliente;
        }

        private void pnlDepartamento_MouseLeave(object sender, EventArgs e)
        {
            pnlDepartamento.BackColor = colorNormalCliente;
        }

        private void pnlUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlUbicacion.BackColor = colorHoverCliente;
        }

        private void pnlUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlUbicacion.BackColor = colorNormalCliente;        
        }

        private void pnlTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pnlTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pnlRuta_MouseHover(object sender, EventArgs e)
        {
            pnlRuta.BackColor = colorHoverCliente;
        }

        private void pnlRuta_MouseLeave(object sender, EventArgs e)
        {
            pnlRuta.BackColor = colorNormalCliente;
        }

        private void pnlSU_MouseHover(object sender, EventArgs e)
        {
            pnlSU.BackColor = colorHoverCliente;
        }

        private void pnlSU_MouseLeave(object sender, EventArgs e)
        {
            pnlSU.BackColor = colorNormalCliente;
        }

        private void pnlTM_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void pnlTM_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pnlTT_MouseHover(object sender, EventArgs e)
        {
            pnlTT.BackColor = colorHoverCliente;
        }

        private void pnlUsuarios_MouseHover(object sender, EventArgs e)
        {
            pnlUsuarios.BackColor = colorHoverCliente;
        }

        private void pnlUsuarios_MouseLeave(object sender, EventArgs e)
        {
            pnlUsuarios.BackColor = colorNormalCliente;
        }

        private void pnlPE_MouseHover(object sender, EventArgs e)
        {
            pnlPE.BackColor = colorHoverCliente;
        }

        private void pnlPE_MouseLeave(object sender, EventArgs e)
        {
            pnlPE.BackColor = colorNormalCliente;
        }

        private void pnlEmpleado_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverCliente;
        }

        private void pnlEmpleado_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalCliente;
        }

        private void pnlBodega_MouseHover(object sender, EventArgs e)
        {
            pnlBodega.BackColor = colorHoverCliente;
        }

        private void pnlBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlBodega.BackColor = colorNormalCliente;
        }

        private void pnlEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverCliente;
        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalCliente;
        }

        private void pnlPD_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverCliente;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalCliente;
        }

        private void pnlTT_MouseLeave(object sender, EventArgs e)
        {
            pnlTT.BackColor = colorNormalCliente;
        }

        private void pnlTrans_MouseClick(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
            obj.Visible = true;
            Visible = false;
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

        private void pnlTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pnlRuta_MouseClick(object sender, MouseEventArgs e)
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
            frmEmpleado obj = new frmEmpleado();
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

        private void pnlTrans_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
            obj.Visible = true;
            Visible = false;
        }

        private void pnlTrans_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverCliente;
        }

        private void pnlTrans_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalCliente;
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
            pnlMovBodega.BackColor = colorHoverCliente;
        }

        private void lblMovimientoBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverCliente;
        }

        private void picMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverCliente;
        }

        private void pnlMovBodega_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pnlMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalCliente;
        }

        private void lblMovimientoBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalCliente;
        }

        private void picMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalCliente;
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
            btnCalificacionP.BackColor = colorHoverCliente;

        }

        private void lblCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverCliente;
        }

        private void picCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverCliente;
        }

        private void btnCalificacionP_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalCliente;
        }

        private void lblCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalCliente;
        }

        private void picCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalCliente;
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
            btnPiloto.BackColor = colorHoverCliente;
        }

        private void lblPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverCliente;
        }

        private void picIconoPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverCliente;
        }

        private void btnPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalCliente;
        }

        private void lblPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalCliente;
        }

        private void picIconoPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalCliente;
        }

        private void btnBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverCliente;
        }

        private void lblBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverCliente;
        }

        private void picIconoBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverCliente;
        }

        private void btnBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalCliente;
        }

        private void lblBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalCliente;
        }

        private void picIconoBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalCliente;
        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnInventario_MouseHover(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorHoverCliente;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = colorNormalCliente;
        }

        private void btnInventario_MouseClick(object sender, MouseEventArgs e)
        {
            frmInventario obj = new frmInventario();
            obj.Visible = true;
            Visible = false;
        }
    }
}
