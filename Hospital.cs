using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Classes;

//Classe
public class Hospital
{
  private string nome;
  private List<Paciente> pacientes;

  public string Nome
    {
        get => nome;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome do hospital não pode ser vazio.");
            nome = value;
        }
    }

    public Hospital(string nome)
    {
        Nome = nome;
        pacientes = new List<Paciente>();
    }
    
    //Método com ref
    public void RegistrarPaciente(Paciente paciente, ref int totalRegistados)
    {
        if (paciente != null)
        {
            pacientes.Add(paciente);
            totalRegistados++;
        }
    }
    //étodo com Array e foreach
    public void CarregarPacientesIniciais(Paciente[] pacientes)
    {
        if(pacientes != null)
        {
            foreach(var paciente in pacientes)
            {
                if(paciente != null)
                {
                    pacientes.Add(paciente);
                }
            }
        }
    }

    //Listar Pacientes com foreach
    public void LsitarPacientes()
    {
        Console.WriteLine($"----- Lista de pacientes do Hospital {Nome} -----");
        foreach(var paciente in pacientes)
        {
            Console.WriteLine(paciente.ToString());
        }
    }
    //Método com valor de Retorno: ProcurarPaciente
    public Paciente? ProcurarPaciente(int numeroPaciente)
    {
        foreach( var paciente in pacientes)
        {
            if (paciente.NumeroPaciente == numeroPaciente)
            {
                return paciente;
            }
        }
        return null;
    }

    //Método LINQ

    //Filtrar por Prioridade
    public List<Paciente> ObterPacientesPorPrioridade(PrioridadeAtendimento prioridade)
    {
        return Paciente.Where(paciente => paciente.Prioridade == prioridade).ToList();
    }

    //Ordenar por Idade
    public List<Paciente> PacienteOrdenadosPorIdade()
    {
        return pacientes.OrderBy(paciente => paciente.Idade).ToList();
    }

    //Contar pacientes urgentes
    public int ContarPacientesUrgentes()
    {
        return pacientes.Count(paciente => paciente.Prioridade == PrioridadeAtendimento.Urgente || paciente.Prioridade = PrioridadeAtendimento.MuitoUrgente);
    }

    //Verificar existência
    public bool ExistePaciente(string nome)
    {
        return pacientes.Any(pacientes => Paciente.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
    }

    
}
