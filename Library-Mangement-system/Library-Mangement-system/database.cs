using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_Mangement_system
{
    class database
    {
        public static SqlConnection db()
        {
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-GM27C9I; database=Library; integrated security=SSPI");
            return con;
        }

    }
}
