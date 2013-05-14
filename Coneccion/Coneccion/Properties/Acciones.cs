using System;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Coneccion
{
	public class Acciones:Coneccion
	{
		public Acciones ()
		{
		}

		public ArrayList ObtenerTodos()
		{
			this.InciarConeccion ();

			MySqlCommand comando = new MySqlCommand(QueryDeConneccion(),this.myConeccion);

			MySqlDataReader Lector = comando.EndExecuteReader ();

			ArrayList ListaArreglos = new ArrayList ();

			datos Datos = new datos ();

			while (Lector.Read())
			{
				Datos.idVideojuego = Lector["idVideojuego"].ToString;
				Datos.nombre = Lector["nombre"].ToString;
				Datos.Anio = Lector ["ano"].ToString;
				Datos.FabricanteNombre = Lector["Fabricante_nombre"].ToString;
				ListaArreglos.Add (Datos);
			}

			return ListaArreglos;
		}

		private string QueryDeConneccion()
		{
			return "SELECT * FROM Videojuego";
		}
	}
}

