using System;
using System.Collections.Generic;
using System.Linq;
using n20231900147_JoseSaidCastilloFlores_WebApiPacientes.Entities;
using n20231900147_JoseSaidCastilloFlores_WebApiPacientes.Interfaces;

namespace n20231900147_JoseSaidCastilloFlores_WebApiPacientes.AppServices
{
	public class PacienteAppService : IPacienteAppService
	{
		private readonly List<Paciente> _pacientes;

		public PacienteAppService()
		{
			_pacientes = new List<Paciente>
			{
				new Paciente
				{
					Id = 1,
					NombreCompleto = "Meredith Grey",
					NumeroIdentidad = "0801199900001",
					FechaNacimiento = new DateTime(1985, 9, 27),
					Telefono = "98765432",
					Activo = true
				},
				new Paciente
				{
					Id = 2,
					NombreCompleto = "Derek Shepherd",
					NumeroIdentidad = "0801199500002",
					FechaNacimiento = new DateTime(1980, 11, 13),
					Telefono = "91234567",
					Activo = true
				},
				new Paciente
				{
					Id = 3,
					NombreCompleto = "Cristina Yang",
					NumeroIdentidad = "0801199000003",
					FechaNacimiento = new DateTime(1983, 2, 5),
					Telefono = "99887766",
					Activo = true
				}
			};
		}

		public List<Paciente> GetAll()
		{
			return _pacientes;
		}

		public Paciente GetById(int id)
		{
			return _pacientes.FirstOrDefault(p => p.Id == id);
		}

		public Paciente Add(Paciente paciente)
		{
			paciente.Id = _pacientes.Max(p => p.Id) + 1;
			_pacientes.Add(paciente);
			return paciente;
		}

		public Paciente Update(int id, Paciente paciente)
		{
			var existente = _pacientes.FirstOrDefault(p => p.Id == id);
			if (existente == null) return null;

			existente.NombreCompleto = paciente.NombreCompleto;
			existente.NumeroIdentidad = paciente.NumeroIdentidad;
			existente.FechaNacimiento = paciente.FechaNacimiento;
			existente.Telefono = paciente.Telefono;
			existente.Activo = paciente.Activo;

			return existente;
		}

		public bool Delete(int id)
		{
			var paciente = _pacientes.FirstOrDefault(p => p.Id == id);
			if (paciente == null) return false;

			_pacientes.Remove(paciente);
			return true;
		}
	}
}