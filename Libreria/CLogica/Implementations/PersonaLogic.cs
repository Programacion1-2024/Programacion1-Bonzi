﻿using CLogica.Contracts;
using CEntidades.Entidades;
using Microsoft.Identity.Client;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CDatos.Repositories.Contracts;
using System.Globalization;

namespace CLogica.Implementations
{
        public class PersonaLogic : IPersonaLogic
    {
        private IPersonaRepository _personaRepository;
        public PersonaLogic(IPersonaRepository personaRepository) {
            _personaRepository = personaRepository;
        }
        public void AltaPersona(Persona personaNueva) 
        {
            List<string> camposErroneos = new List<string>();

            if (string.IsNullOrEmpty(personaNueva.Nombre) || !IsValidName(personaNueva.Nombre))
                camposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(personaNueva.Apellido) || !IsValidName(personaNueva.Apellido))
                camposErroneos.Add("Apellido");

            if (string.IsNullOrEmpty(personaNueva.Documento) || !IsValidDocumento(personaNueva.Documento) || _personaRepository.FindByCondition(p => p.Documento == personaNueva.Documento).Count() != 0)
                camposErroneos.Add("Documento");

            if (string.IsNullOrEmpty(personaNueva.Telefono) || !IsValidTelefono(personaNueva.Telefono))
                camposErroneos.Add("Teléfono");

            if (string.IsNullOrEmpty(personaNueva.Email) || !IsValidEmail(personaNueva.Email))
                camposErroneos.Add("Email");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", System.String.Join(", ", camposErroneos));
            }

            Persona persona = new Persona();
            persona.Nombre = personaNueva.Nombre;
            persona.Apellido = personaNueva.Apellido;
            persona.Nacionalidad = personaNueva.Nacionalidad;
            persona.Documento = personaNueva.Documento;
            persona.TipoDocumento = personaNueva.TipoDocumento;
            persona.Telefono = personaNueva.Telefono;
            persona.Email = personaNueva.Email;
            if(personaNueva.Autor != null)
            {
                persona.Autor = personaNueva.Autor;
            }
            if (personaNueva.Empleado != null)
            {
                persona.Empleado = personaNueva.Empleado;
            }
            if (personaNueva.Cliente != null)
            {
                persona.Cliente = personaNueva.Cliente;
            }
            _personaRepository.Create(persona);
            _personaRepository.Save();
        }

        public void ActualizacionPersona(string documento, Persona personaActualizar)
        {
            List<string> camposErroneos = new List<string>();

            if (string.IsNullOrEmpty(personaActualizar.Nombre) || !IsValidName(personaActualizar.Nombre))
                camposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(personaActualizar.Apellido) || !IsValidName(personaActualizar.Apellido))
                camposErroneos.Add("Apellido");

            if (string.IsNullOrEmpty(personaActualizar.Documento) || !IsValidDocumento(personaActualizar.Documento) || _personaRepository.FindByCondition(p => p.Documento == personaActualizar.Documento).Count() != 0)
                camposErroneos.Add("Documento");

            if (string.IsNullOrEmpty(personaActualizar.Telefono) || !IsValidTelefono(personaActualizar.Telefono))
                camposErroneos.Add("Teléfono");

            if (string.IsNullOrEmpty(personaActualizar.Email) || !IsValidEmail(personaActualizar.Email))
                camposErroneos.Add("Email");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", System.String.Join(", ", camposErroneos));
            }

            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException("El documento ingresado es inválido");

            Persona? persona = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();

            if (persona == null)
            {
                throw new ArgumentNullException("No se ha encontrado una persona con ese documento.");
            }

            persona.Nombre = personaActualizar.Nombre;
            persona.Apellido = personaActualizar.Apellido;
            persona.Documento = personaActualizar.Documento;
            persona.Telefono = personaActualizar.Telefono;
            persona.Email = personaActualizar.Email;
            
            _personaRepository.Update(persona);
            _personaRepository.Save();
        }
        public void EliminarPersona(string documento)
        {
            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException("El documento ingresado es inválido");

            Persona? persona = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();

            if (persona == null)
            {
                throw new ArgumentNullException("No se ha encontrado una persona con ese documento.");
            }
            _personaRepository.Delete(persona);
            _personaRepository.Save();
        }
        private bool ContainsInvalidCharacter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '&', '*', '/', '(' ,')' ,'=' ,',' ,'.' };
            return caracteres.Any(c => text.Contains(c));
        }
        private bool IsValidName(string nombre)
        {
            return nombre.Length < 15 && !ContainsInvalidCharacter(nombre);
        }
        public bool IsValidDocumento(string documento) 
        {
            return documento.Length == 8 && documento.All(c => Char.IsNumber(c));            
        }
        public bool IsValidTelefono(string telefono)
        {
            return telefono.Length == 10 && telefono.All(c => Char.IsNumber(c));           
        }
        public bool IsValidEmail(string email)
        {
            return email.Contains("@") && !ContainsInvalidCharacter(email);            
        }
    }
}