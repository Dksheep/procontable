using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procontable
{
    public class Conexion
    {
        public SqlConnection cndbc = new SqlConnection("server=SERVER; database=procontable;Integrated Security=True"); //\\SQLEXPRESS
    }
}
