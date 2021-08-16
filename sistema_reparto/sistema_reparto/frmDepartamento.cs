﻿using System;
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
    public partial class frmDepartamento : Form
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
        Color colorHoverDepartamento = Color.FromArgb(80, 115, 119);
        Color colorNormalDepartamento = Color.FromArgb(59, 102, 107);


        public frmDepartamento()
        {
            InitializeComponent();

            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            /*Oculto todos los elementos al ingresar*/
            pnlBordeDepartamento.Visible = false;
            lblRegistrarDepartamento.Visible = false;
            pnlBordeRegistrarD.Visible = false;
            lblModificarDepartamento.Visible = false;
            pnlBordeModificarD.Visible = false;
            lblDarBajaDepartamento.Visible = false;
            pnlBordeDarBajaD.Visible = false;
            pnlCampoIdD.Visible = false;
            pnlCampoNombreD.Visible = false;
            pnlCampoED.Visible = false;
            txtBuscarDepartamento.Visible = false;
            pnlBotonBuscarD.Visible = false;
            dgvDepartamentos.Visible = false;
            pnlActivarD.Visible = false;
            pnlDarBajaD.Visible = false;
            pnlLLenarCamposD.Visible = false;
            pnlLlenarCamposDDB.Visible = false;
            pnlBotonGuardarD.Visible = false;
            pnlModificarD.Visible = false;

            String idUsuario = Login.idUsuario;

            LoginC loginC = new LoginC();

            txtNombreUsu.Text = loginC.funBuscarNormbre(idUsuario);
            txtIdUsu.Text = idUsuario;


        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void frmDepartamento_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCliente_MouseClick(object sender, MouseEventArgs e)
        {
           
            frmPrincipal obj = new frmPrincipal();

            obj.Visible = true;

            Visible = false;

        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverDepartamento;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalDepartamento;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverDepartamento;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalDepartamento;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverDepartamento;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalDepartamento;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverDepartamento;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalDepartamento;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverDepartamento;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalDepartamento;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverDepartamento;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalDepartamento;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverDepartamento;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalDepartamento;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverDepartamento;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalDepartamento;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverDepartamento;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalDepartamento;
        }

        private void lblAbcDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio visibles mis labes y bordes*/
            pnlBordeDepartamento.Visible = true;
            lblRegistrarDepartamento.Visible = true;
            lblModificarDepartamento.Visible = true;
            lblDarBajaDepartamento.Visible = true;
            /* fin visibles mis labes y bordes*/

        }

        private void lblRegistrarDepartamento_MouseClick(object sender, MouseEventArgs e)
        {


            /* Inicio cargando datos en tabla Departamentos */
            Departamento departamento = new Departamento();
            funCargarTabla(null);

            pnlBordeRegistrarD.Visible = true;
            pnlBordeModificarD.Visible = false;
            pnlBordeDarBajaD.Visible = false;

            /*Mostar los elementos*/
            pnlCampoIdD.Visible = true;
            pnlCampoNombreD.Visible = true;
            pnlCampoED.Visible = false;
            txtBuscarDepartamento.Visible = true;
            pnlBotonBuscarD.Visible = true;
            dgvDepartamentos.Visible = true;
            pnlActivarD.Visible = false;
            pnlDarBajaD.Visible = false;
            pnlLLenarCamposD.Visible = true;
            pnlLlenarCamposDDB.Visible = false;
            pnlBotonGuardarD.Visible = true;
            pnlModificarD.Visible = false;

            /*inicio deshabilitando y habilitando contenidos de mi form */
            pnlCampoIdD.Enabled = true;
            pnlCampoNombreD.Enabled = true;
            txtBuscarDepartamento.Enabled = true;
            pnlBotonBuscarD.Enabled = true;
            dgvDepartamentos.Enabled = true;
            pnlLLenarCamposD.Enabled = true;

            funVaciarCampos();
        }

        private void lblModificarDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();
            funCargarTabla(null);

            pnlBordeRegistrarD.Visible = false;
            pnlBordeModificarD.Visible = true;
            pnlBordeDarBajaD.Visible = false;

            /*Mostar los elementos*/
            pnlCampoIdD.Visible = true;
            pnlCampoNombreD.Visible = true;
            pnlCampoED.Visible = false;
            txtBuscarDepartamento.Visible = true;
            pnlBotonBuscarD.Visible = true;
            dgvDepartamentos.Visible = true;
            pnlActivarD.Visible = false;
            pnlDarBajaD.Visible = false;
            pnlLLenarCamposD.Visible = true;
            pnlLlenarCamposDDB.Visible = false;
            pnlBotonGuardarD.Visible = false;
            pnlModificarD.Visible = true;
            

            /*inicio deshabilitando y habilitando contenidos de mi form */
            pnlCampoIdD.Enabled = false;
            pnlCampoNombreD.Enabled = true;
            txtBuscarDepartamento.Enabled = true;
            pnlBotonBuscarD.Enabled = true;
            dgvDepartamentos.Enabled = true;
            pnlLLenarCamposD.Enabled = true;
        }

        private void lblDarBajaDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();

            pnlBordeRegistrarD.Visible = false;
            pnlBordeModificarD.Visible = false;
            pnlBordeDarBajaD.Visible = true;

            /*Mostar los elementos*/
            pnlCampoIdD.Visible = true;
            pnlCampoNombreD.Visible = true;
            pnlCampoED.Visible = true;
            txtBuscarDepartamento.Visible = true;
            pnlBotonBuscarD.Visible = true;
            dgvDepartamentos.Visible = true;
            pnlActivarD.Visible = false;
            pnlDarBajaD.Visible = false;
            pnlLLenarCamposD.Visible = false;
            pnlLlenarCamposDDB.Visible = true;
            pnlBotonGuardarD.Visible = false;
            pnlModificarD.Visible = false;
           

            /*inicio deshabilitando y habilitando contenidos de mi form */
            pnlCampoIdD.Enabled = false;
            pnlCampoNombreD.Enabled = false;
            txtBuscarDepartamento.Enabled = true;
            pnlBotonBuscarD.Enabled = true;
            dgvDepartamentos.Enabled = true;
            pnlLLenarCamposD.Enabled = true;
            txtEstatusDepartamento.Enabled = false;

            funCargarTabla(null);
        }

        private void btnPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos obj = new frmPuestos();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlBotonGuardarD_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio de ejecucion de funcion insertar un PueDepartamentostp */
            

            if(txtIdDepartamento.Text=="" || txtNombreDepartamento.Text == "")
            {
                MessageBox.Show("No se pueden ingresar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String EstatusDepartamento = "A";
                Departamento departamento = funObtenerTxt(EstatusDepartamento);
                departamento.funInsertar();
                /* Final de ejecucion de funcion insertar un Departamento */

                funCargarTabla(null);
                funVaciarCampos();
            }

            
        }

        public void funVaciarCampos()
        {
            txtIdDepartamento.Text = "";
            txtNombreDepartamento.Text = "";
            txtEstatusDepartamento.Text = "";
            txtBuscarDepartamento.Text = "";
        }

        /* Inicio funcion para cargar mi tabla de Departamento */
        private void funCargarTabla(string dato)
        {
            List<Departamento> lista = new List<Departamento>();
            Departamento departamento = new Departamento();

            dgvDepartamentos.DataSource = departamento.consulta(dato);
        }
        /* Final funcion para cargar mi tabla de Departamento */
        public Departamento funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC Departamento */
            String pCodigoD = txtIdDepartamento.Text;
            String pNombreD = txtNombreDepartamento.Text;
            /*Final obteniedo variables a usar con mi ABC Departamento */

            /* Inicio creamos un objeto de tipo cliente para poder utilizar el metodo de insertar Departamento */
            Departamento departamento = new Departamento(pCodigoD, pNombreD, estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar Departamento */

            return departamento;
        }

        private void pnlBotonBuscarD_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarDepartamento = txtBuscarDepartamento.Text;
            funCargarTabla(buscarDepartamento);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlDarBajaD.Visible = false;

            pnlActivarD.Visible = false;
            /* Final Vaciando los campos */
        }

        private void txtBuscarDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        /*Iniciamos a llenar las cajas de texto*/
        private void pnlLLenarCamposD_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdDepartamento.Text = dgvDepartamentos.CurrentRow.Cells[0].Value.ToString();
            txtNombreDepartamento.Text = dgvDepartamentos.CurrentRow.Cells[1].Value.ToString();
            txtEstatusDepartamento.Text = dgvDepartamentos.CurrentRow.Cells[2].Value.ToString();
        }

        private void pnlModificarD_MouseClick(object sender, MouseEventArgs e)
        {
            String EstatusDepartamento = "A";
            String idDepartamento= txtIdDepartamento.Text;
            Departamento departamento = funObtenerTxt(EstatusDepartamento);

            departamento.funModificar(idDepartamento);
            funCargarTabla(null);
            departamento.funBuscarSetearTxt(txtIdDepartamento, txtNombreDepartamento, txtEstatusDepartamento, idDepartamento);
        }

        private void pnlLlenarCamposDDB_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdDepartamento.Text = dgvDepartamentos.CurrentRow.Cells[0].Value.ToString();
            txtNombreDepartamento.Text = dgvDepartamentos.CurrentRow.Cells[1].Value.ToString();
            txtEstatusDepartamento.Text = dgvDepartamentos.CurrentRow.Cells[2].Value.ToString();

            Departamento departamento = new Departamento();
            String pidDepartamento = txtIdDepartamento.Text;
            String pestatusDepartamento = departamento.funBuscarEstatus(pidDepartamento);

            if (pestatusDepartamento == "A")
            {
                pnlActivarD.Visible = false;
                pnlDarBajaD.Visible = true;
            }
            else if (pestatusDepartamento == "I")
            {
                pnlDarBajaD.Visible = false;
                pnlActivarD.Visible = true;
            }
        }

        private void pnlActivarD_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdDepartamento = txtIdDepartamento.Text;
            Departamento departamento = funObtenerTxt(estatus);

            departamento.funActivarDepartamento();
            funCargarTabla(null);

            pnlDarBajaD.Visible = true;
            pnlActivarD.Visible = false;

            departamento.funBuscarSetearTxt(txtIdDepartamento, txtNombreDepartamento, txtEstatusDepartamento, pIdDepartamento);
        }

        private void pnlDarBajaD_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdDepartamento = txtIdDepartamento.Text;
            Departamento departamento = funObtenerTxt(estatus);

            departamento.funDarBajaDepartamento();
            funCargarTabla(null);

            pnlActivarD.Visible = true;
            pnlDarBajaD.Visible = false;

            departamento.funBuscarSetearTxt(txtIdDepartamento, txtNombreDepartamento, txtEstatusDepartamento, pIdDepartamento);
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
            //lblAbcDepartamento.Visible = true;
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

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverDepartamento;

        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalDepartamento;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverDepartamento;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalDepartamento;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverDepartamento;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalDepartamento;
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

        private void pnlLlenarCamposDDB_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pnlRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta ruta = new frmRuta();
            ruta.Visible = true;

            Visible = false;
        }

        private void label9_DoubleClick(object sender, EventArgs e)
        {

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

        private void pnlRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverDepartamento;
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverDepartamento;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverDepartamento;
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
            btnRuta.BackColor = colorNormalDepartamento;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalDepartamento;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalDepartamento;
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

        private void pnlSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            
            pnlSubUbicacion.BackColor = colorHoverDepartamento;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverDepartamento;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverDepartamento;
        }

        private void pnlSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalDepartamento;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalDepartamento;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalDepartamento;
        }

        private void btnTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverDepartamento;
        }

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalDepartamento;
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverDepartamento;
        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalDepartamento;
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverDepartamento;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalDepartamento;
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
            btnPaqueteEncabezado.BackColor = colorHoverDepartamento;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverDepartamento;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverDepartamento;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalDepartamento;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalDepartamento;
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalDepartamento;
        }

        private void pnlEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlEmpleado_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverDepartamento;
        }

        private void pnlEmpleado_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalDepartamento;

        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverDepartamento;
        }

        private void lblUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverDepartamento;
        }

        private void picIconoUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorHoverDepartamento;
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalDepartamento;
        }

        private void lblUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalDepartamento;
        }

        private void picIconoUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = colorNormalDepartamento;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalDepartamento;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalDepartamento;
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverDepartamento;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverDepartamento;
        }

        private void label14_MouseClick(object sender, MouseEventArgs e)
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
            btnBodega.BackColor = colorHoverDepartamento;
        }

        private void lblBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverDepartamento;
        }

        private void picBodega_MouseHover(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorHoverDepartamento;
        }

        private void btnBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalDepartamento;
        }

        private void lblBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalDepartamento;
        }

        private void picBodega_MouseLeave(object sender, EventArgs e)
        {
            btnBodega.BackColor = colorNormalDepartamento;
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
            pnlEnvio.BackColor = colorHoverDepartamento;
        }

        private void pnlEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalDepartamento;
        }

        private void lblEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverDepartamento;
        }

        private void lblEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalDepartamento;
        }

        private void picEnvio_MouseHover(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorHoverDepartamento;
        }

        private void picEnvio_MouseLeave(object sender, EventArgs e)
        {
            pnlEnvio.BackColor = colorNormalDepartamento;
        }

        private void pnlTrans_MouseClick(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
            obj.Visible = true;
            Visible = false;
        }

        private void pnlPD_MouseHover(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorHoverDepartamento;
        }

        private void pnlPD_MouseLeave(object sender, EventArgs e)
        {
            pnlPD.BackColor = colorNormalDepartamento;
        }

        private void pnlPD_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteDetalle obj = new frmPaqueteDetalle();
            obj.Visible = true;
            Visible = false;
        }

        private void pnlTrans_MouseHover(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorHoverDepartamento;
        }

        private void pnlTrans_MouseLeave(object sender, EventArgs e)
        {
            pnlTrans.BackColor = colorNormalDepartamento;
        }

        private void pnlTrans_MouseClick_1(object sender, MouseEventArgs e)
        {
            frmTransporte obj = new frmTransporte();
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
            pnlMovBodega.BackColor = colorHoverDepartamento;
        }

        private void lblMovimientoBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverDepartamento;
        }

        private void picMovBodega_MouseHover(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorHoverDepartamento;
        }

        private void pnlMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalDepartamento;
        }

        private void lblMovimientoBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalDepartamento;
        }

        private void picMovBodega_MouseLeave(object sender, EventArgs e)
        {
            pnlMovBodega.BackColor = colorNormalDepartamento;
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
            btnCalificacionP.BackColor = colorHoverDepartamento;
        }

        private void lblCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverDepartamento;
        }

        private void picCalificacion_MouseHover(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorHoverDepartamento;
        }

        private void btnCalificacionP_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalDepartamento;
        }

        private void lblCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalDepartamento;
        }

        private void picCalificacion_MouseLeave(object sender, EventArgs e)
        {
            btnCalificacionP.BackColor = colorNormalDepartamento;
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
            btnPiloto.BackColor = colorHoverDepartamento;
        }

        private void lblPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverDepartamento;
        }

        private void picIconoPiloto_MouseHover(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorHoverDepartamento;
        }

        private void btnPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalDepartamento;
        }

        private void lblPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalDepartamento;
        }

        private void picIconoPiloto_MouseLeave(object sender, EventArgs e)
        {
            btnPiloto.BackColor = colorNormalDepartamento;
        }

        private void btnBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverDepartamento;
        }

        private void lblBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverDepartamento;
        }

        private void picIconoBitaTrans_MouseHover(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorHoverDepartamento;
        }

        private void btnBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalDepartamento;
        }

        private void lblBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalDepartamento;
        }

        private void picIconoBitaTrans_MouseLeave(object sender, EventArgs e)
        {
            btnBitaTrans.BackColor = colorNormalDepartamento;
        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
    /* Final de funcion para evitar el uso de recursivo de tantas variables */
