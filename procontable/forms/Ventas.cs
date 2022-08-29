using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procontable.forms
{
    public partial class Ventas : Form
    {
        public static Ventas instancia = null;

        public static Ventas ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new Ventas(); 
                return instancia;
            }
            return instancia;
        }

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
          cargargrid(dataGridView1);
        }

        /* Metodos */
        private void cargargrid(DataGridView grid)
        {
            DataTable dt = new DataTable();
            Conexion camy = new Conexion();
            camy.cndbc.Open();

            string query1 = " SELECT Correlativo,tipoDocumento,Cliente,Formapago,CAST(Subtotal AS Decimal(18,2)) AS Subtotal, CAST(Iva AS Decimal(18,2)) AS Iva," +
                            " CAST(Total AS Decimal(18,2)) AS Total FROM Ventas ";
            
            SqlCommand cmd = new SqlCommand(query1 , camy.cndbc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            
            grid.DataSource = dt;
        }
    }
}
