using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MenuContextualEnWindowsForms
{
    //Ahora vamos a hacer la herencia de la clase publicacion agregando un propiedad mas q contenga una imagen
    public class PublicacionImagen : Publicacion
    {
        public string urlimagen { get; set; } = "";
        public PublicacionImagen(string titulo, string autor, string urlimagen, bool espublico)
        {
            this.id = nuevoid();
            this.titulo = titulo;
            this.autor = autor;
            this.espublico = espublico;
            this.urlimagen = urlimagen;
        }
    }
    public class Publicacion
    {
        //Solo declaramos el acumulador q nos servira para asignar un id unico autoincrementable
        private static int publicacionid;
        //aqui declaramos e inicializamos los siguientes parametros de la clase
        public int id { get; set; } = 0;
        public string titulo { get; set; } = "";
        public string autor { get; set; } = "";
        public bool espublico { get; set; } = true;
        //generamos el contructor de la clase
        public Publicacion() { }
        //generamos un metodo sobrecargado del constructor para asignar los valores de un nuevo
        //eleento de la clase
        public Publicacion(string titulo, string autor, bool espublico)
        {
            this.id = nuevoid();
            this.titulo = titulo;
            this.autor = autor;
            this.espublico = espublico;
        }
        protected int nuevoid()
        {
            return ++publicacionid;
        }
        //vamos a sobreescribirt el metodo tostring de la clase de modo q lo usemos para dale el formato
        //q nosotros necesamos para mostrar alguna cadena de texto
        public override string ToString()
        {
            return string.Format("Este id {0} pertenece a {1} con titulo {2}", this.id, this.autor, this.titulo);
        }
    }
}
