using System;
using Classes;

class Program
{
    static void Main(string[] args)
    {
        //Operações de consulta LINQ consistem em 3 ações distintas:
        //1. obtenha a fonte de dados
        //2. crie a consulta
        //3. executar a consulta
        
        //Estrutura try-catch é usada para capturar e lidar com exceções durante a execução do código
        //Bloco try = contém o código que pode lançar uma exceção
        //Bloco catch = tratam as exceções capturadas 
        try
        {
            //Criar hospital
            Hospital hospital = new Hospital("Hospital Central");
            int totalRegistados = 0;

            //Array de pacientes iniciais
            Paciente[] pacientesIniciais = new Paciente[]
            {
                new Paciente("Ana Silva", 101, 30, PrioridadeAtendimento.PoucoUrgente),
                new Paciente("Carlos Santos", 102, 65, PrioridadeAtendimento.Urgente),
                new Paciente("Beatriz Costa", 103, 45, PrioridadeAtendimento.NaoUrgente),
                new Paciente("Daniel Oliveira", 104, 22, PrioridadeAtendimento.MuitoUrgente)
            };

            hospital.CarregarPacientesIniciais(pacientesIniciais);
            totalRegistados += pacientesIniciais.Length;

            //Registar com ref
            Paciente novoPaciente = new Paciente("Mariana Sousa", 105, 50, PrioridadeAtendimento.Urgencia);
            hospital.RegistrarPaciente(novoPaciente, ref totalRegistados);
            Console.WriteLine($"Total de pacientes registados (com ref): {totalRegistados}\n");

            //Adicionar nota clínica
            novoPaciente.AdicionarNota("Paciente apresenta febre alta.");
            Console.WriteLine("Nova clínica adicionada com sucesso.\n");

            //Criar sala, verificar disponibilidade e descrição
            Sala salaEmergencia = new Sala("Emergência 1", 3, 2);
            Console.WriteLine(salaEmergencia.ObterDescricao());
            Console.WriteLine($"A sala está disponível? {salaEmergencia.EstaDisponivel()}\n");

            //Criar médico especialista e ToString
            MedicoEspecialista medico = new MedicoEspecialista("rui Mendes", 2050, "Cardiologia", "Cardiologia Pediátrica");
            Console.WriteLine(medico.ToString() + "\n");

            //Listar pacientes
            hospital.LsitarPacientes();
            Console.WriteLine();

            //Procurar paciente
            Console.WriteLine("------ Testando ProcurarPaciente --------");
            int idExistente = 103;

            Paciente? pacienteEncontrado = hospital.ProcurarPaciente(idExistente);
            if (pacienteEncontrado != null)
                {
                    Console.WriteLine($"Encontrado: {pacienteEncontrado.Nome} (Número: {pacienteEncontrado.NumeroPaciente})");
                }
            else
                {
                    Console.WriteLine($"Paciente {idExistente} não encontrado.");
                }
            int idInexistente = 999;
            Paciente? pacienteNaoEncontrado = hospital.ProcurarPaciente(idExistente);
            if (pacienteEncontrado != null)
                {
                    Console.WriteLine($"Encontrado: {pacienteNaoEncontrado.Nome}");
                }
            else
                {
                    Console.WriteLine($"Paciente {idInexistente} não encontrado.\n");
                }
            
            //Consultas LINQ
            Console.WriteLine("------ Testando Consultas LINQ -----");
            int urgentesCount = hospital.ContarPacientesUrgentes();
            Console.WriteLine($"Número de pacientes Urgentes ou Muito Urgentes: {urgentesCount}");

            string nomeBusca = "Carlos Santos";
            bool existe = hospital.ExistePaciente(nomeBusca);
            Console.WriteLine($"O paciente '{nomeBusca}' existe no hospital? {existe}");

            Console.WriteLine("\nPacientes ordenados por idade (do mais novo para o mais velho): ");
            var ordenados = hospital.PacienteOrdenadosPorIdade();
            foreach( var paciente in ordenados)
            {
                Console.WriteLine($"- {paciente.Nome}, {paciente.Idade} anos");
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Ocorreu um erro: {exception.Message}");
        }
    }
}