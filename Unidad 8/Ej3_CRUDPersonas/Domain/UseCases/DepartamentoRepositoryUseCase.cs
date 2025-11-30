using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases;
using System.Collections.Generic;

namespace Domain.UseCases
{
    /// <summary>
    /// Caso de uso que gestiona todas las operaciones de Departamento
    /// </summary>
    public class DepartamentoRepositoryUseCase : IDepartamentoRepositoryUseCase
    {
        private readonly IDepartamentoRepository _repositorioDepartamentos;

        public DepartamentoRepositoryUseCase(IDepartamentoRepository departamentoRepository)
        {
            _repositorioDepartamentos = departamentoRepository;
        }

        /// <summary>
        /// Devuelve la lista de todos los departamentos
        /// </summary>
        /// <returns>Lista de departamentos</returns>
        public List<Departamento> getListaDepartamento()
        {
            return _repositorioDepartamentos.getListaDepartamentos();
        }

        public int crearDepartamento(Departamento departamentoNuevo)
        {
            return _repositorioDepartamentos.crearDepartamento(departamentoNuevo);
        }

        public int actualizarDepartamento(int idDepartamento, Departamento departamentoActualizado)
        {
            return _repositorioDepartamentos.actualizarDepartamento(idDepartamento, departamentoActualizado);
        }

        public int eliminarDepartamento(int idDepartamento)
        {
            // Regla de negocio: no se puede borrar un departamento con personas asignadas
            int personasEnDepartamento = _repositorioDepartamentos.contarPersonasDepartamento(idDepartamento);
            if (personasEnDepartamento > 0)
            {
                return -1; // O lanzar excepción según tu diseño
            }
            return _repositorioDepartamentos.eliminarDepartamento(idDepartamento);
        }
    }
}