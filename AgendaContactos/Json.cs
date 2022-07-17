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

        string LeerJson(string archivo, string ubicacion = "interno")
        {
            if (String.IsNullOrEmpty(archivo)) //valida que el parametro no sea null o vacio
                return null;
            var ruta = $"{directorioBase}//{archivo}.json"; //forma la ruta del archivo json a leer
            if (ubicacion == "externo") ruta = archivo;
            if (!File.Exists(ruta)) //si el archivo no existe
                return null;
            return File.ReadAllText(ruta); //returna su contenido
        }
        public int? ObtenerIdSiguiente()
        {
            if (ObtenerContactos().Count() > 0) return ObtenerContactos().Max(x => x.Id) + 1;
            else return 1;
        }
        public List<Contacto> ObtenerContactos()
        {
            json = LeerJson("contactos");//almacena en una variable el contenido del archivo Json
            if (String.IsNullOrEmpty(json)) return new List<Contacto>(); //return null si el contenido del archivo esta vacio o es null
            return JsonConvert.DeserializeObject<List<Contacto>>(json);//retorna en formato de lista el contenido del json
        }
        public List<Categoria> ObtenerCategorias()
        {
            json = LeerJson("categorias");//almacena en una variable el contenido del archivo Json
            if (String.IsNullOrEmpty(json)) return new List<Categoria>(); //return null si el contenido del archivo esta vacio o es null
            return JsonConvert.DeserializeObject<List<Categoria>>(json);//retorna en formato de lista el contenido del json
        }
        public void GuardarContactos(List<Contacto> contactos, string ubicacion = null)
        {
            var ruta = ubicacion;
            if(ubicacion == null) ruta = $"{directorioBase}//contactos.json"; //forma la ruta del archivo json a escribir
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
        public List<Contacto> ObtenerContactos(string archivo)
        {
            json = LeerJson(archivo, "externo");//almacena en una variable el contenido del archivo Json
            if (String.IsNullOrEmpty(json)) return new List<Contacto>(); //return null si el contenido del archivo esta vacio o es null
            return JsonConvert.DeserializeObject<List<Contacto>>(json);//retorna en formato de lista el contenido del json
        }
        public void ImportarContactos(List<Contacto> agregar)
        {
            var ruta = $"{directorioBase}//contactos.json"; //forma la ruta del archivo json a escribir
            var listado = ObtenerContactos();
            int? contador = ObtenerIdSiguiente();
            foreach (Contacto c in agregar)
            {
                c.Id = contador;
                contador++;
                listado.Add(c);
            }
            json = JsonConvert.SerializeObject(listado);//convierte a formato json el listado
            sw = new StreamWriter(ruta, false, Encoding.UTF8);
            sw.Write(json);//carga al archivo el json
            sw.Close();
        }
    }
}
