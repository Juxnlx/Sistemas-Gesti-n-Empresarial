using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases;
using System.Collections.Generic;

namespace Domain.UseCases
{
    /// <summary>
    /// Caso de uso que gestiona todas las operaciones de Persona
    /// </summary>
    public class PersonaRepositoryUseCase : IPersonaRepositoryUseCase
    {
        private readonly IPersonaRepository _repositorioPersonas;
        private readonly IDepartamentoRepository _repositorioDepartamentos;

        /// <summary>
        /// Constructor que recibe los repositorios mediante inyección de dependencias
        /// </summary>
        public PersonaRepositoryUseCase(IPersonaRepository personaRepository, IDepartamentoRepository departamentoRepository)
        {
            _repositorioPersonas = personaRepository;
            _repositorioDepartamentos = departamentoRepository;
        }

        /// <summary>
        /// Devuelve la lista de personas con el nombre del departamento al que pertenecen
        /// </summary>
        /// <returns>Lista de PersonaConNombreDepartamento</returns>
        public List<PersonaConNombreDepartamento> getListaPersonasConNombreDepartamento()
        {
            var listaPersonas = _repositorioPersonas.getListaPersonas();
            var listaPersonasConNombre = new List<PersonaConNombreDepartamento>();

            foreach (var persona in listaPersonas)
            {
                string nombreDepartamento = _repositorioDepartamentos.getDepartamentoPorId(persona.IDDepartamento)?.nombre ?? "Sin departamento";
                listaPersonasConNombre.Add(new PersonaConNombreDepartamento(persona)
                {
                    nombreDepartamento = nombreDepartamento
                });
            }

            return listaPersonasConNombre;
        }

        /// <summary>
        /// Devuelve una persona junto con el listado completo de departamentos
        /// </summary>
        /// <returns>DTO PersonaConListadoDepartamento</returns>
        public PersonaConListadoDepartamento getPersonaConListadoDepartamento()
        {
            var listaDepartamentos = _repositorioDepartamentos.getListaDepartamentos();
            var personaDummy = new Persona(); // Se llenará en el controller
            return new PersonaConListadoDepartamento(personaDummy)
            {
                listadoDepartamento = listaDepartamentos
            };
        }

        /// <summary>
        /// Devuelve una persona específica con el nombre de su departamento
        /// </summary>
        /// <returns>DTO PersonaConNombreDepartamento</returns>
        public PersonaConNombreDepartamento getPersonaConNombreDepartamento()
        {
            var personaDummy = new Persona(); // Se llenará con la persona deseada
            string nombreDepartamento = _repositorioDepartamentos.getDepartamentoPorId(personaDummy.IDDepartamento)?.nombre ?? "Sin departamento";
            return new PersonaConNombreDepartamento(personaDummy)
            {
                nombreDepartamento = nombreDepartamento
            };
        }

        public int crearPersona(Persona personaNueva)
        {
            return _repositorioPersonas.crearPersona(personaNueva);
        }

        public int actualizarPersona(int idPersona, Persona personaActualizada)
        {
            return _repositorioPersonas.actualizarPersona(idPersona, personaActualizada);
        }

        public int eliminarPersona(int idPersona)
        {
            return _repositorioPersonas.eliminarPersona(idPersona);
        }
    }
}