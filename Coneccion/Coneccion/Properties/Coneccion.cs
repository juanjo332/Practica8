using System;
using MySql.Data.MySqlClient;

namespace Coneccion
{
	public class Coneccion
	{
		public Coneccion ()
		{
		}
		protected MySqlConnection myConeccion;

		protected void InciarConeccion()
		{
			string Enlace = 
				    "Server=localhost;" +
					"Database=mySQL;" +
					"User ID=juan;" +
					"Password=JohnJoseph332;" +
					"Pooling=false;";
			this.myConeccion = new MySqlConnection (Enlace);
			this.myConeccion.Open ();
		}

		protected void CerrarConneccion()
		{
			this.myConeccion.Close ();
			this.myConeccion = null;
		}
	}
}

