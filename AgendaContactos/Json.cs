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
        StreamWriter sw; //objeto para escribir dentro del archivo json
        string json; //variable para almacenar la lista en notacion json
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
        public int? ObtenerIdSiguiente() //obtiene el id correspondiente al siguiente contacto
        {
            if (ObtenerContactos().Count() > 0) return ObtenerContactos().Max(x => x.Id) + 1; //si hay mas se un contacto, busca el id mas alto y retornalo sumado de uno
            else return 1; //si no hay contactos, retorna 1 como primer id
        }
        
        public List<Contacto> ObtenerContactos() //retorna una lista de contactos
        {
            json = LeerJson("contactos");//almacena en una variable el contenido del archivo Json
            if (String.IsNullOrEmpty(json)) return new List<Contacto>(); //return null si el contenido del archivo esta vacio o es null
            return JsonConvert.DeserializeObject<List<Contacto>>(json);//retorna en formato de lista el contenido del json
        }
        public List<Categoria> ObtenerCategorias() //retorna una lista de categorias
        {
            json = LeerJson("categorias");//almacena en una variable el contenido del archivo Json
            if (String.IsNullOrEmpty(json)) return new List<Categoria>(); //return null si el contenido del archivo esta vacio o es null
            return JsonConvert.DeserializeObject<List<Categoria>>(json);//retorna en formato de lista el contenido del json
        }
        public void GuardarContactos(List<Contacto> contactos, string ubicacion = "interno") //guarda los contactos, cuando se le especifica una ubicacion significa que se estan exportando contactos
        {
            var ruta = ubicacion;//la ruta es la ubicacion especificada
            if(ubicacion == "interno") ruta = $"{directorioBase}//contactos.json"; //si se quiere almacenar en el json interno del sistema, forma la ruta del archivo json a escribir
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
        public void ImportarContactos(List<Contacto> agregar) //importa contactos al json del sistema
        {
            var ruta = $"{directorioBase}//contactos.json"; //forma la ruta del archivo json a escribir
            var listado = ObtenerContactos();//obtiene los contactos actuales del sistema
            int? contador = ObtenerIdSiguiente();//obtiene el siguiente id
            foreach (Contacto c in agregar)//recorre todos los contactos a importar
            {
                c.Id = contador;//colocale un id al contacto
                contador++;
                listado.Add(c);//agregalo a la lista
            }
            json = JsonConvert.SerializeObject(listado);//convierte a formato json el listado
            sw = new StreamWriter(ruta, false, Encoding.UTF8);
            sw.Write(json);//carga al archivo el json
            sw.Close();
        }
    }
}
