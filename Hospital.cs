using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Classes;

//Classe
public class Hospital
{
    private string nome = string.Empty;
    // Nomeado como _pacientes para evitar confusão com os parâmetros
    private List<Paciente> _pacientes;

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
        _pacientes = new List<Paciente>();
    }
    
    //Método com ref
    public void RegistrarPaciente(Paciente paciente, ref int totalRegistados)
    {
        if (paciente != null)
        {
            _pacientes.Add(paciente);
            totalRegistados++;
        }
    }

    //Método com Array e foreach (Parâmetro nomeado como pacientesIniciais)
    public void CarregarPacientesIniciais(Paciente[] pacientesIniciais)
    {
        if(pacientesIniciais != null)
        {
            foreach(var paciente in pacientesIniciais)
            {
                if(paciente != null)
                {
                    _pacientes.Add(paciente); // Agora adiciona corretamente à lista da classe
                }
            }
        }
    }

    //Listar Pacientes com foreach 
    public void ListarPacientes()
    {
        Console.WriteLine($"----- Lista de pacientes do Hospital {Nome} -----");
        foreach(var paciente in _pacientes)
        {
            Console.WriteLine(paciente.ToString());
        }
    }

    //Método com valor de Retorno: ProcurarPaciente
    public Paciente? ProcurarPaciente(int numeroPaciente)
    {
        foreach(var paciente in _pacientes)
        {
            if (paciente.NumeroPaciente == numeroPaciente)
            {
                return paciente;
            }
        }
        return null;
    }

    // --- Métodos LINQ ---

    //Filtrar por Prioridade
    public List<Paciente> ObterPacientesPorPrioridade(PrioridadeAtendimento prioridade)
    {
        return _pacientes.Where(paciente => paciente.Prioridade == prioridade).ToList();
    }

    //Ordenar por Idade
    public List<Paciente> PacientesOrdenadosPorIdade()
    {
        return _pacientes.OrderBy(paciente => paciente.Idade).ToList();
    }

    //Contar pacientes urgentes
    public int ContarPacientesUrgentes()
    {
        return _pacientes.Count(paciente => paciente.Prioridade == PrioridadeAtendimento.Urgente || paciente.Prioridade == PrioridadeAtendimento.MuitoUrgente);
    }

    //Verificar existência
    public bool ExistePaciente(string nomePaciente)
    {
        return _pacientes.Any(paciente => paciente.Nome.Equals(nomePaciente, StringComparison.OrdinalIgnoreCase));
    }
}