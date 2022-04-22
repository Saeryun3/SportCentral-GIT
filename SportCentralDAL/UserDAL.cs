using SportCentralInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralDAL
{
   public class UserDAL : IUser 
   {
        SqlConnection sqlConnection = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi479257;User=dbi479257;Password=Dagal555;");

   }
}
