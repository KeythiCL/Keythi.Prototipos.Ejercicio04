using Keythi.Prototipos.Ejercicio04.DatosDeUnaPersona;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;  // Usamos esta librería para trabajar con JSON

namespace Keythi.Prototipos.Ejercicio04.Almacen
{
    internal class PersonaAlmacen
    {
        private const string archivoJson = @"Persona.json"; // Archivo donde guardamos los datos JSON

        // Método para leer los datos desde el archivo JSON
        public static List<PersonaEnt> ObtenerPersonas()
        {
            // Si el archivo no existe, retornamos una lista vacía
            if (!File.Exists(archivoJson))
            {
                return new List<PersonaEnt>();
            }

            // Leemos el archivo JSON y deserializamos a una lista de PersonaEnt
            var json = File.ReadAllText(archivoJson);
            var personas = JsonSerializer.Deserialize<List<PersonaEnt>>(json);

            return personas ?? new List<PersonaEnt>(); // Retornamos una lista vacía si el JSON no tiene datos
        }

        // Método para grabar los datos en el archivo JSON
        public static void GrabarPersonas(List<PersonaEnt> personas)
        {
            // Serializamos la lista de personas a formato JSON
            var json = JsonSerializer.Serialize(personas, new JsonSerializerOptions { WriteIndented = true });

            // Guardamos el JSON en el archivo
            File.WriteAllText(archivoJson, json);
        }
    }
}


