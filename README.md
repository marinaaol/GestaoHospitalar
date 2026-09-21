# Hospital Management System in C# (`GestaoHospitalar`)

> Project developed as part of the C# Application Development course unit (CET in Information Systems Technologies and Programming - IEFP / ISLA Gaia).

## 📋 About the Project
This project consists of a C# console application that simulates a **Hospital Management System**. The main objective is not to build a production-ready enterprise system, but rather to consolidate and apply fundamental concepts of Object-Oriented Programming (OOP) and data manipulation in C#.

## 🚀 Concepts and Technologies Covered
- **Classes and Properties Creation:** Encapsulation, data validation using `getters`, `setters`, and exception handling (`ArgumentException`).
- **Enumerated Types (`enum`):** Representation of fixed states (hospital triage/urgency levels).
- **Data Structures:** Generic lists (`List<T>`) and Arrays.
- **Loops and Control Flow:** Iteration with `foreseen` (`foreach`) and exception handling (`try-catch`).
- **Passing Parameters by Reference:** Using the `ref` modifier.
- **Interfaces:** Defining contracts and implementing shared behaviors (`IRecursoHospitalar`).
- **Inheritance and Polymorphism:** Class extension (`Medico` and `MedicoEspecialista`), constructor chaining with `base(...)`, and method overriding (`ToString()`).
- **LINQ Queries:** Filtering, sorting, counting, and existence checks over collections.

## 🗂️ Project Structure
The project is organized into the following main files and classes:
- `PrioridadeAtendimento.cs`: Enum containing the hospital urgency levels.
- `Paciente.cs`: Class representing patients, including validations and a clinical notes history.
- `IRecursoHospitalar.cs`: Contract interface for hospital resources.
- `Sala.cs`: Class implementing the hospital resource interface.
- `Medico.cs` & `MedicoEspecialista.cs`: Class hierarchy representing healthcare professionals.
- `Hospital.cs`: Central management class handling the patient list and LINQ queries.
- `Program.cs`: Application entry point (`Main`) for demonstration and practical testing.

## 🛠️ How to Run the Project
Make sure you have the [.NET SDK](https://dotnet.microsoft.com/) installed on your computer.

1. Clone the repository:
   ```bash
   git clone [https://github.com/marinaaol/GestaoHospitalar.git](https://github.com/marinaaol/GestaoHospitalar.git)
   
--------------------------------------------------------------------
--------------------------------------------------------------------

# Sistema de Gestão Hospitalar em C# (`GestaoHospitalar`)

> Projeto desenvolvido no âmbito da unidade curricular de Desenvolvimento de Aplicações em C# (CET em Tecnologias e Programação de Sistemas de Informação - IEFP / ISLA Gaia).

## 📋 Sobre o Projeto
Este projeto consiste numa aplicação de consola em C# que simula um **Sistema de Gestão Hospitalar**. O objetivo principal não é criar um sistema de produção, mas sim consolidar e aplicar conceitos fundamentais de Programação Orientada a Objetos (POO) e manipulação de dados em C#.

## 🚀 Conceitos e Tecnologias Abordadas
- **Criação de Classes e Propriedades:** Encapsulamento, validação de dados com `getters`, `setters` e lançamento de exceções (`ArgumentException`).
- **Tipos Enumerados (`enum`):** Representação de estados fixos (níveis de urgência de atendimento).
- **Estruturas de Dados:** Listas genéricas (`List<T>`) e Arrays.
- **Ciclos e Controlo de Fluxo:** Iteração com `foreach` e tratamento de exceções (`try-catch`).
- **Passagem de Parâmetros por Referência:** Uso do modificador `ref`.
- **Interfaces:** Criação de contratos e implementação de comportamentos comuns (`IRecursoHospitalar`).
- **Herança e Polimorfismo:** Extensão de classes (`Medico` e `MedicoEspecialista`), utilização de construtores com `base(...)` e `override` de métodos (`ToString()`).
- **Consultas com LINQ:** Filtragem, ordenação, contagem e verificação de existência em coleções.

## 🗂️ Estrutura do Projeto
O projeto está organizado nos seguintes ficheiros e classes principais:
- `PrioridadeAtendimento.cs`: Enum com os níveis de urgência hospitalar.
- `Paciente.cs`: Classe que representa os pacientes, incluindo validações e histórico de notas clínicas.
- `IRecursoHospitalar.cs`: Interface contratual para os recursos do hospital.
- `Sala.cs`: Classe que implementa a interface de recursos hospitalares.
- `Medico.cs` & `MedicoEspecialista.cs`: Hierarquia de classes para representar os profissionais de saúde.
- `Hospital.cs`: Classe central de gestão que centraliza a lista de pacientes e as consultas LINQ.
- `Program.cs`: Ponto de entrada (`Main`) da aplicação para demonstração e testes práticos.

## 🛠️ Como Executar o Projeto
Certifica-te de que tens o [.NET SDK](https://dotnet.microsoft.com/) instalado no teu computador.

1. Clona o repositório:
   ```bash
   git clone [https://github.com/marinaaol/GestaoHospitalar.git](https://github.com/marinaaol/GestaoHospitalar.git)