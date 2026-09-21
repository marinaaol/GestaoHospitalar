public class Sala : IRecursoHospitalar
{
    public string Identificador {get;}
    public int Capacidade {get; set;}
    public int OcupacaoAtual {get; set;}

    public Sala(string identificador, int capacidade, int ocupacaoAtual)
    {
        Identificador = identificador;
        Capacidade = capacidade;
        OcupacaoAtual = ocupacaoAtual;
    }

    public string ObterDescricao()
    {
        return $"Sala {Identificador} - Capacidade Máxima: {Capacidade}, Ocupação atual: {OcupacaoAtual}";
    }
    
    public bool EstaDisponivel()
    {
        return OcupacaoAtual < Capacidade;
    }
}
