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
using FontAwesome.Sharp;
using UI_Desktop.Forms;

namespace UI_Desktop
{
    public partial class Form1 : Form
    {
        //Campos
        private IconButton currentBtn;
        private Panel leftborderBtn;
        private Form currentChildForm; //Variable de tipo formulario

        public Form1()
        {
            InitializeComponent();
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftborderBtn);

            //Propiedades para el formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//Al maximizar se ajusta al area de trabajo sin quitar la barra de tareas
        }

       
        #region Colores
        /// <summary>
        /// Estructura para almacenar colores RGB 
        /// colores para las opciones del menú principal
        /// </summary>
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        #endregion

        #region Activar Boton
        /// <summary>
        /// Metodo privado que asigna las propiedades estilisadas al boton
        /// </summary>
        /// <param name="senderBtn">boton</param>
        /// <param name="color">color del boton</param>
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftborderBtn.BackColor = color;
                leftborderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftborderBtn.Visible = true;
                leftborderBtn.BringToFront();

                //Icono del formulario
                iconCurrentChildrenFrom.IconChar = currentBtn.IconChar; //el icono del formulario sera el icono del boton actual
                iconCurrentChildrenFrom.IconColor = color;

            }
        }
        #endregion

        #region Deshabilitar boton
        /// <summary>
        /// Metodo que asigna las propiedades de incio al boton
        /// </summary>
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(30, 31, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion

        #region Abrir Form hijo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="childform"></param>
        private void OpenChildForm(Form childform)
        {
            if (currentChildForm != null)
            {
                //Solo se abre un formulario
                currentChildForm.Close();
            }

            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(childform);//Agregamos los controles del panel hijo al panel de escritorio
            panelDesktop.Tag = childform;//Asocionamos los datos del formulario al panel
            childform.BringToFront();//Traemos el formulario hacia el frente
            childform.Show(); //Lo mostramos
            lblTitleChildFrom.Text = childform.Text;//mostramos el texto del formulario en la etiqueta de "Inicio"
        }
        #endregion

        #region Eventos de botones
        private void btnDash_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            OpenChildForm(new FrmDashBoard());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color2);
            OpenChildForm(new FrmOrdenes());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            OpenChildForm(new FrmProductos());
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color4);
            OpenChildForm(new FrmMarketing());
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color5);
            OpenChildForm(new FrmVentas());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
                currentChildForm.Close(); //Cerramos el formulario hijo que se encuentre abierto
            Reset();
        }
        #endregion

        #region Reset
        /// <summary>
        /// Metodo que reincia los controles y visualizaciones al estado Inicial
        /// </summary>
        private void Reset()
        {
            DisableButton();
            leftborderBtn.Visible = false;
            iconCurrentChildrenFrom.IconChar = IconChar.Home;
            iconCurrentChildrenFrom.IconColor = Color.MediumPurple;
            lblTitleChildFrom.Text = "Inicio";
        }
        #endregion

        #region DLL
        /// <summary>
        /// Se importan las DLL para realizar accion especial
        /// en el Form
        /// </summary>
        //Dibujar form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            //Con los siguientes metodos nos desasemos de la barra de titulo del formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Cargar formulario
        /// <summary>
        /// Carga del fomulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            timerHr.Enabled = true; //Habilitamos el control timer
        }
        #endregion

        #region Timer
        /// <summary>
        /// Evento tick del control timer
        /// alli se asigna el formato de hora y fecha a etiquetas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerHr_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("t");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

    }
}
