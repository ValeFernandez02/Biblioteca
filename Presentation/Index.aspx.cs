using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Libro objLibro = new Libro();
            objLibro.Nombre = "Las mil y una noches";
            objLibro.ISBN1 = "978-2-17-23420-0";
            objLibro.Año = 1996;
            objLibro.Tematica = "Novela Literaria";
            objLibro.Paginas1 = 328;

            Libro objLibro2 = new Libro();
            objLibro2.Nombre = "Don quijote de la mancha";
            objLibro2.ISBN1 = "977-1-24-42089-0";
            objLibro2.Año = 1989;
            objLibro2.Tematica = "Novela Literaria";
            objLibro2.Paginas1 = 1040;

            Libro objlibro3 = new Libro();
            objlibro3.Nombre = "Crimen y castigo";
            objlibro3.ISBN1 = "968-7-43-42891-0";
            objlibro3.Año = 2023;
            objlibro3.Tematica = "Novelas literarias ";
            objlibro3.Paginas1 = 768;

            string msj1 = objLibro.mostrarMensaje();
            Lblmsj1.Text = msj1;
            string msj2 = objLibro2.mostrarMensaje();
            Lblmsj2.Text = msj2;
            string msj3 = objlibro3.mostrarMensaje();
            Lblmsj3.Text = msj3;
        }
    }
}