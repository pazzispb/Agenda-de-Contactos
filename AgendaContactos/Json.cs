using AgendaContactos.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AgendaContactos
{
    public class Json
    {
        StreamWriter sw;
        string json;
        string directorioBase = AppDomain.CurrentDomain.BaseDirectory;//directorio base del proyecto

        string LeerJson(string archivo)
        {
            if (String.IsNullOrEmpty(archivo)) //valida que el parametro no sea null o vacio
                return null;
            if (archivo != "contactos" && archivo != "categorias") //valida que el parametro concuerde con algunos de los archivos json del proyecto
                return null;
            var ruta = $"{directorioBase}//{archivo}.json"; //forma la ruta del archivo json a leer
            if (!File.Exists(ruta)) //si el archivo no existe
                return null;
            return File.ReadAllText(ruta); //returna su contenido
        }
        public List<Contacto> ObtenerContactos()
        {
            json = LeerJson("contactos");//almacena en una variable el contenido del archivo Json
            if (String.IsNullOrEmpty(json)) return null; //return null si el contenido del archivo esta vacio o es null
            return JsonConvert.DeserializeObject<List<Contacto>>(json);//retorna en formato de lista el contenido del json
        }
        public List<Categoria> ObtenerCategorias()
        {
            json = LeerJson("categorias");//almacena en una variable el contenido del archivo Json
            if (String.IsNullOrEmpty(json)) return null; //return null si el contenido del archivo esta vacio o es null
            return JsonConvert.DeserializeObject<List<Categoria>>(json);//retorna en formato de lista el contenido del json
        }
        public void GuardarContactos(List<Contacto> contactos)
        {
            var ruta = $"{directorioBase}//contactos.json"; //forma la ruta del archivo json a escribir
            json = JsonConvert.SerializeObject(contactos);//convierte a formato json el listado
            sw = new StreamWriter(ruta, false, Encoding.UTF8);
            sw.Write(json);//carga al archivo el json
            sw.Close();
        }
        public void GuardarCategorias(List<Categoria> categorias)
        {
            var ruta = $"{directorioBase}//categorias.json"; //forma la ruta del archivo json a escribir
            json = JsonConvert.SerializeObject(categorias);//convierte a formato json el listado
            sw = new StreamWriter(ruta, false, Encoding.UTF8);
            sw.Write(json);//carga al archivo el json
            sw.Close();
        }
    }
}
