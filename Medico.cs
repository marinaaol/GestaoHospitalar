using System;
using System.Collections.Generic;

public class Medico
{
    private string nome;
    private int numeroColega;
    private string especialidadeBase;

    public string Nome
    {
        get => nome;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome do médico não pode ser vazio.");
            nome = value;
        }
    }

    public int NumeroColega
    {
        get => numeroColega;
        set
        {
            if (value <= 0)
                throw new ArgumentException ("O número da ordem deve ser positivo.");
                numeroColega = value;
        }
    }
    public string EspecialidadeBase
    {
        get => especialidadeBase;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("A especialidade base não pode ser vazia.");
            especialidadeBase = value;
        }
    }
    
    public Medico(string nome, int numeroColega, string especialidadeBase)
    {
        Nome = nome;
        NumeroColega = numeroColega;
        EspecialidadeBase = especialidadeBase;
    }
    public override string ToString()
    {
        return $"Dr. {Nome} | Nº {NumeroColega} | Especialidade: {EspecialidadeBase}";
    }
}
