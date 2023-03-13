using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public class Libro
    {
        private string nombre ;
        private string ISBN ;
        private int año ;
        private string tematica;
        private int Paginas;

        public string Nombre { get => nombre; set => nombre = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public int Año { get => año; set => año = value; }
        public string Tematica { get => tematica; set => tematica = value; }
        public int Paginas1 { get => Paginas; set => Paginas = value; }

        public string mostrarMensaje()
        {
            if (año > 2015)
            {
                string msj = "El " + nombre + "De temmatica " + tematica + "Publicado en el " + año + " Es moderno ";
                return msj;
            }
            else
            {
                string msj = "El " + nombre + "De temmatica " + tematica + "Publicado en el " + año + " Es clasico ";
                return msj;
            }
        }
    }
}