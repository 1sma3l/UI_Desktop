﻿using System;
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

            //Formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//Al maximizar se ajusta al area de trabajo sin quitar la barra de tareas
        }

        //Estructura para almacenar colores RGB
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
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

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(30, 31, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childform)
        {
            if(currentChildForm != null)
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
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftborderBtn.Visible = false;
            iconCurrentChildrenFrom.IconChar = IconChar.Home;
            iconCurrentChildrenFrom.IconColor = Color.MediumPurple;
            lblTitleChildFrom.Text = "Inicio";
        }

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
    }
}