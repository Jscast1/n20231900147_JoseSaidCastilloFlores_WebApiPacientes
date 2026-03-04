using n20231900147_JoseSaidCastilloFlores_WebApiPacientes.Entities;

namespace n20231900147_JoseSaidCastilloFlores_WebApiPacientes.Interfaces
{
	public interface IPacienteAppService
	{
		List<Paciente> GetAll();
		Paciente GetById(int id);
		Paciente Add(Paciente paciente);
		Paciente Update(int id, Paciente paciente);
		bool Delete(int id);
	}
}