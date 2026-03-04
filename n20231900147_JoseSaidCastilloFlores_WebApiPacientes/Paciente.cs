namespace n20231900147_JoseSaidCastilloFlores_WebApiPacientes.Entities
{
	public class Paciente
	{
		public int Id { get; set; }
		public string NombreCompleto { get; set; }
		public string NumeroIdentidad { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public string Telefono { get; set; }
		public bool Activo { get; set; }
	}
}