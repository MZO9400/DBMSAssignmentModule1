using System;
using System.Text;
using System.Data.SqlClient;

namespace DBMS {
	public class ConnectionString {
		public static String getConnectionString() {
			return new SqlConnectionStringBuilder {
				DataSource = "HAMZAST440\\SQLSERVER",
				IntegratedSecurity = true,
				InitialCatalog = "DBMS"
			}.ConnectionString;
		}
		public static String getPassword() {
			return "61qz+AW<b]<sSCC9";
		}
	}
}
