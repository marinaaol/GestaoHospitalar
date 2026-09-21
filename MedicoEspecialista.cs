using System;
using System.Collections.Generic;

public class MedicoEspecialista : Medico
{
    private string subEspecialidade = string.Empty;
    public string SubEspecialidade
    {
        get => subEspecialidade;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("A subespecialidade não pode ser vazia.");
                subEspecialidade = value;
        }
    }

    public MedicoEspecialista(string nome, int numeroColega, string especialidadeBase, string subEspecialidade)
        : base(nome, numeroColega, especialidadeBase)
    {
        SubEspecialidade = subEspecialidade;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Subespecialidade: {SubEspecialidade}";
    }
    
}
