using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn //Esquinas redondas (diseño)
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 48, 48)); //Esquinas redondas (diseño)
        }

        private void cafe1_Click(object sender, EventArgs e)
        {
            panelCafe.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void cafe2_Click(object sender, EventArgs e)
        {
            panelCafe.Visible = false;
            panel3.Visible = false;
        }

        private void cafe3_Click(object sender, EventArgs e)
        {
            panelCafe.Visible = false;
        }

        private void atras3_Click(object sender, EventArgs e)
        {
            panelCafe.Visible = true;
        }

        private void atras2_Click(object sender, EventArgs e)
        {
            panelCafe.Visible = true;
            panel3.Visible = true;
        }

        private void atras1_Click_1(object sender, EventArgs e)
        {
            panelCafe.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblHora3.Text = DateTime.Now.ToString("hh:mm:ss");
            lblHora2.Text = DateTime.Now.ToString("hh:mm:ss");
            lblHora1.Text = DateTime.Now.ToString("hh:mm:ss");
            lblHoraLogin.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void ipadBoton_Click(object sender, EventArgs e)
        {
            if (panelLogin.Visible)
            {
                panelLogin.Visible = false;
                lblHoraLogin.Visible = false;
                barradeEstadoLogin.Visible = false;
            }
            else
            {
                Application.Exit();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
