using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDataBase {
    class DataBaseConnection {

        private string connectionString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521))" +
            "(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)));Password= password;User ID=c##volohov";

        public String getConnectionString() {
            return connectionString;
        }
    }
}
