using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace procontable.forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        /* variables */
        string nameform = "Login";

        private void login_Load(object sender, EventArgs e)
        {
            btnIngresar1.Select();
        }

        /* Textbox */
        private void txtuser1_Enter(object sender, EventArgs e)
        {
            if (txtuser1.Text == "Usuario")
            {
                txtuser1.Clear();
            }

            Image userpic2 = Image.FromFile(@"C:\procontable\procontable\procontable\Imagenes\user_aqua.png");
            picUser2.Image = userpic2;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtuser1.ForeColor = Color.FromArgb(78, 184, 206);

            Image passpic1 = Image.FromFile(@"C:\procontable\procontable\procontable\Imagenes\key_blanco.png");
            picUserpass1.Image = passpic1;
            panel2.BackColor = Color.WhiteSmoke;
            txtpass1.ForeColor = Color.WhiteSmoke;
        }
        private void txtuser1_Leave(object sender, EventArgs e)
        {
            if (txtuser1.Text == String.Empty)
            {
                txtuser1.Text = "Usuario";
            }
        }
        private void txtuser1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtpass1.Select();
            }
        }
        private void txtpass1_Enter(object sender, EventArgs e)
        {
            if (txtpass1.Text == "Clave")
            {
                txtpass1.Clear();
            }

            Image passpic1 = Image.FromFile(@"C:\procontable\procontable\procontable\Imagenes\key_aqua.png");
            picUserpass1.Image = passpic1;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtpass1.ForeColor = Color.FromArgb(78, 184, 206);

            Image userpic2 = Image.FromFile(@"C:\procontable\procontable\procontable\Imagenes\user_blanco.png");
            picUser2.Image = userpic2;
            panel1.BackColor = Color.WhiteSmoke;
            txtuser1.ForeColor = Color.WhiteSmoke;
        }
        private void txtpass1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar1.Select();
            }
        }

        /* Botones */
        private void btnIngresar1_Click(object sender, EventArgs e)
        {
            vlogin();
        }
        private void btnSalir1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Metodos */
        private bool validardatos(String nuser, String nclave)
        {
            bool datosvacios = false;

            if (nuser == String.Empty || nuser == "Usuario")
            {
                datosvacios = true;
            }
            else
            {
                datosvacios = false;

                if (nclave == String.Empty || nclave == "Clave")
                {
                    datosvacios = true;
                }
                else
                {
                    datosvacios = false;
                }
            }
            return datosvacios;
        }
        private void vlogin()
        {
            /* Variables */
            String nusuario = txtuser1.Text;
            String nclave = txtpass1.Text;
            Boolean npasa = false;

            bool datosvacios = validardatos(nusuario, nclave);

            /* Validar campos vacios */
            if (!datosvacios)
            {
                npasa = logear(nusuario, nclave);

                /* Si encuentra el usuario */
                if (npasa)
                {   
                    this.Hide();
                    forms.Principal formPrincipal = new forms.Principal();
                    formPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario no Válido.", nameform, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Campo de Usuario o Clave esta vacío.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool logear(string nusuario, string ncontrasena)
        {
            bool npasa = false;

            Conexion cav = new Conexion();
            cav.cndbc.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE Usuario=@usuario AND Clave=@clave", cav.cndbc);
                cmd.Parameters.AddWithValue("usuario", nusuario);
                cmd.Parameters.AddWithValue("clave", ncontrasena);
                SqlDataReader df = cmd.ExecuteReader();


                if (df.Read())
                {
                    npasa = true;
                }
                else
                {
                    npasa = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                npasa = false;
            }
            finally
            {
                cav.cndbc.Close();

            }

            cav.cndbc.Close();
            return npasa;
        }
    }
}
