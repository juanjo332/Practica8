using System;
using Gtk;
using Coneccion;
using System.Collections;

public partial class MainWindow: Gtk.Window
{	
	Int16 x;
	Int16 y;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnmostrarClicked (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
		this.titulos ();
		this.cuerpo ();
		this.Child.ShowAll ();

	}

	private void titulos()
	{
		this.x = 25;
		this.y = 58;
		this.etiqueta("lblID", "<span size=\"14000\" foreground=\"BLUE\" weight=\"bold\">ID</span>");
		this.x += 100;
		this.etiqueta("lblCodigo", "<span size=\"14000\" foreground=\"BLUE\" weight=\"bold\">NOMBRE</span>");
		this.x += 200;
		this.etiqueta("lblNombre", "<span size=\"14000\" foreground=\"BLUE\" weight=\"bold\">AÑO</span>");
		this.x += 200;
		this.etiqueta("lblOpciones", "<span size=\"14000\" foreground=\"BLUE\" weight=\"bold\">FABRICANTE_NOMBRE</span>");
	}

	private void cuerpo()
	{
		Acciones acciones = new Acciones();
		ArrayList alumnos = acciones.ObtenerTodos ();
		foreach(datos Datos in alumnos){
			this.x = 25;
			this.y += 40;
			registros(Datos);
	      }
	}

	
	  private void registros(datos Datos)
		{
			this.etiqueta("lblID_" + Datos.idVideojuego, "<span size=\"12000\" foreground=\"#000000\">" + Datos.idVideojuego + "</span>");
			this.x += 100;
			this.etiqueta("lblCodigo_" +Datos.idVideojuego , "<span size=\"12000\" foreground=\"#000000\">" + Datos.nombre + "</span>");
			this.x += 200;
			this.etiqueta("lblNombre_" + Datos.idVideojuego, "<span size=\"12000\" foreground=\"#000000\">" + Datos.Anio+ "</span>");
			this.x += 200;
		    this.etiqueta("lblNombre_" + Datos.idVideojuego, "<span size=\"12000\" foreground=\"#000000\">" + Datos.FabricanteNombre+ "</span>");
		    this.x += 200;
			this.opciones(alumno);
		}

	private void etiqueta(string nombre, string markup)
	{
		Gtk.Label etiqueta = new global::Gtk.Label ();
		etiqueta.Name = nombre;
		etiqueta.Markup = markup;
		etiqueta.UseMarkup = true;
		this.fixed1.Add (etiqueta);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[etiqueta]));
		w11.X = this.x;
		w11.Y = this.y;
	}
}
