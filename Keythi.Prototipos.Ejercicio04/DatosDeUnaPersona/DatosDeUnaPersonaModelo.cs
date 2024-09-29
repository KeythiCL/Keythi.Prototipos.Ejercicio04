using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keythi.Prototipos.Ejercicio04.DatosDeUnaPersona
{
    internal class DatosDeUnaPersonaModelo
    {
        public List<Persona> Personas { get; private set; } = new List<Persona>
        {
            new Persona { Documento = 1234562, Nombre = "Juan", Apellido = "Pérez", TipoNumero = TiposNumero.CASA, CodigoPais = 54, CodigoArea = 11, NumeroTel = 5555123 },
            new Persona { Documento = 8765432, Nombre = "María", Apellido = "García", TipoNumero = TiposNumero.TRABAJO, CodigoPais = 1, CodigoArea = 212, NumeroTel = 134567 },
            new Persona { Documento = 2345672, Nombre = "Pedro", Apellido = "López", TipoNumero = TiposNumero.OTRO, CodigoPais = 34, CodigoArea = 91, NumeroTel = 98764321 },
            new Persona { Documento = 3456782, Nombre = "Ana", Apellido = "Torres", TipoNumero = TiposNumero.CASA, CodigoPais = 44, CodigoArea = 20, NumeroTel = 765421 },
            new Persona { Documento = 4567890, Nombre = "Carlos", Apellido = "Fernández", TipoNumero = TiposNumero.CASA, CodigoPais = 49, CodigoArea = 30, NumeroTel = 310987 },
            new Persona { Documento = 5678901, Nombre = "Laura", Apellido = "Ramírez", TipoNumero = TiposNumero.CASA, CodigoPais = 33, CodigoArea = 1, NumeroTel = 9988766 },
            new Persona { Documento = 6789012, Nombre = "José", Apellido = "Martínez", TipoNumero = TiposNumero.CASA, CodigoPais = 61, CodigoArea = 3, NumeroTel = 123214 },
            new Persona { Documento = 7890124, Nombre = "Sofía", Apellido = "González", TipoNumero = TiposNumero.TRABAJO, CodigoPais = 54, CodigoArea = 223, NumeroTel = 444678 },
            new Persona { Documento = 8901245, Nombre = "Luis", Apellido = "Sánchez", TipoNumero = TiposNumero.OTRO, CodigoPais = 52, CodigoArea = 55, NumeroTel = 9876542 },
            new Persona { Documento = 9012456, Nombre = "Gabriela", Apellido = "Méndez", TipoNumero = TiposNumero.TRABAJO, CodigoPais = 57, CodigoArea = 1, NumeroTel = 765432 },
            new Persona { Documento = 1123344, Nombre = "Martín", Apellido = "Suárez", TipoNumero = TiposNumero.TRABAJO, CodigoPais = 1, CodigoArea = 305, NumeroTel = 321098 },
            new Persona { Documento = 2234455, Nombre = "Verónica", Apellido = "Castro", TipoNumero = TiposNumero.OTRO, CodigoPais = 55, CodigoArea = 11, NumeroTel = 654321 },
            new Persona { Documento = 3445566, Nombre = "Nicolás", Apellido = "Ibáñez", TipoNumero = TiposNumero.CASA, CodigoPais = 34, CodigoArea = 93, NumeroTel = 23456789 },
            new Persona { Documento = 4556677, Nombre = "Paula", Apellido = "Delgado", TipoNumero = TiposNumero.CASA, CodigoPais = 49, CodigoArea = 69, NumeroTel = 87654 },
            new Persona { Documento = 5667788, Nombre = "Diego", Apellido = "Vázquez", TipoNumero = TiposNumero.OTRO, CodigoPais = 54, CodigoArea = 351, NumeroTel = 554321 }
        };

        internal string IngresarDatos(Persona persona)
        {
            // Validación de Documento: debe ser un número de 7-8 dígitos
            if (persona.Documento < 1000000 || persona.Documento >= 100000000)
            {
                return "Ingrese un documento de 7-8 dígitos.";
            }

            // Validar si el documento ya existe
            foreach (var personaGuardada in Personas)
            {
                if (personaGuardada.Documento == persona.Documento)
                {
                    return $"Este documento ya existe: {persona.Documento}.";
                }
            }

            // Validación del Nombre: requerido y con un máximo de 30 caracteres
            if (string.IsNullOrWhiteSpace(persona.Nombre))
            {
                return "El nombre es requerido.";
            }
            if (persona.Nombre.Length > 30)
            {
                return "El nombre no debe superar los 30 caracteres.";
            }

            // Validación del Apellido: requerido y con un máximo de 30 caracteres
            if (string.IsNullOrWhiteSpace(persona.Apellido))
            {
                return "El apellido es requerido.";
            }
            if (persona.Apellido.Length > 30)
            {
                return "El apellido no debe superar los 30 caracteres.";
            }

            // Validación del Código de País: debe ser un número de 2 dígitos
            if (persona.CodigoPais < 10 || persona.CodigoPais >= 100)
            {
                return "El código de país debe tener 2 cifras.";
            }

            // Validación del Código de Área: debe ser un número de 2 dígitos
            if (persona.CodigoArea < 10 || persona.CodigoArea >= 100)
            {
                return "El código de área debe tener 2 cifras.";
            }

            // Validación del Número de Teléfono: debe ser un número de 6-8 dígitos
            if (persona.NumeroTel < 100000 || persona.NumeroTel >= 100000000)
            {
                return "El número de teléfono debe tener entre 6 y 8 dígitos.";
            }

            // Si todas las validaciones son correctas, se puede agregar la persona
            Personas.Add(persona);
            return null; // No hay errores
        }

    }
}
