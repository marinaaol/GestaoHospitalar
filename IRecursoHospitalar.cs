public interface IRecursoHospitalar
{
    string Identificador {get;}
    string ObterDescricao();
    bool EstaDisponivel();
}