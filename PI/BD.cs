using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PI{
    class BD{
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;

        private string dataSource = @"localhost";
        private string initialCatalog = "AppFiec";
        private string integratedSecurity = "True";

        public bool getConnection(){
            try{
                //con = new SqlConnection("Data Source="+dataSource+";Initial Catalog="+initialCatalog+";Integrated Security="+integratedSecurity);
                con = new SqlConnection(Properties.Settings.Default.Setting);
                return true;
            }catch (Exception e){
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public void close(){
            try{
                if (con != null) con.Close();
            }catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
