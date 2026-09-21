using System;
using System.Collections.Generic;

namespace Classes;

//Classe
public class Paciente
{
   //Propriedades
   public string nome = string.Empty;
   public int numeroPaciente;
   public int idade;
   public PrioridadeAtendimento prioridade;
   public List<string> historicoNotas = new List<string>();


   // Regras de validação get/set
   public string Nome
   {
       get => nome;
       set
       {
           if(string.IsNullOrWhiteSpace(value) || value.Length < 2)
               throw new ArgumentException("O nome não pode ser nulo, vazio ou ter menos de 2 caracteres.");
           nome = value;
       }
   }

   public int NumeroPaciente
   {
       get => numeroPaciente;
       set
       {
           if (value <= 0)
               throw new ArgumentException("O número do paciente de ser um número positivo (maior que 0).");
           numeroPaciente = value;
       }
   }

   public int Idade
   {
       get => idade;
       set
       {
           if (value < 0 || value > 130)
               throw new ArgumentException("A idade deve ser entre 0 e 130 (inclusive).");
           idade = value;
       }
   }

   public PrioridadeAtendimento Prioridade
   {
       get => prioridade;
       set => prioridade = value;
   }

   public List<string> HistoricoNotas
   {
       get => historicoNotas;
       set
       {
           if (value == null)
               throw new ArgumentException("O histórico de notas não pode ser null.");
           historicoNotas = value;
       }
   }

   //Construtor
   public Paciente(string nome, int numeroPaciente, int idade, PrioridadeAtendimento prioridade)
   {
      Nome = nome;
      NumeroPaciente= numeroPaciente;
      Idade = idade;
      Prioridade = prioridade;
      HistoricoNotas = new List<string>();
   }

   //Método
   public void AdicionarNota(string nota)
   {
       if (!string.IsNullOrWhiteSpace(nota))
       {
           HistoricoNotas.Add(nota);
       }
   }

   //Override ToString()
   public override string ToString()
   {
       return $"Nome: {Nome} | Número do Paciente: {NumeroPaciente} | Idade: {Idade} | Prioridade: {Prioridade} | Notas: {HistoricoNotas.Count}";
   }
}  