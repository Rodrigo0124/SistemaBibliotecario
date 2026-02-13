# 📚 Sistema Bibliotecário - Console App (.NET 8)

Projeto desenvolvido em C# utilizando .NET 8 com o objetivo de praticar:

- Programação Orientada a Objetos (POO)
- Manipulação de listas
- Validação de dados
- Estruturas condicionais e loops
- Interação via Console

---

## 🚀 Funcionalidades

✔️ Cadastrar livros  
✔️ Verificar status do livro (por nome ou ID)  
✔️ Emprestar livro  
✔️ Validação de ID duplicado  
✔️ Validação de nome duplicado  
✔️ Controle de disponibilidade  

---

## 🏗️ Estrutura do Projeto

### 📁 Livro.cs
Classe responsável por representar a entidade Livro.

Atributos:
- NomeLivro
- IdLivro
- NomeAutor
- Disponibilidade

---

### 📁 CadastroLivro.cs
Classe responsável por gerenciar a lista de livros.

Métodos:
- AdicionarLivro()

---

### 📁 Program.cs
Contém:
- Menu principal
- Validações
- Lógica de empréstimo
- Controle de fluxo do sistema

---

## 🛠️ Tecnologias Utilizadas

- C#
- .NET 8
- Console Application

---

## ▶️ Como Executar

1. Clone o repositório:
git clone https://github.com/Rodrigo0124/SistemaBibliotecario.git


2. Acesse a pasta:


cd SistemaBibliotecario


3. Execute:


dotnet run


---

## 📌 Melhorias Futuras

- Implementar devolução de livro
- Persistência de dados (arquivo ou banco de dados)
- Separar responsabilidades (aplicar princípios SOLID)
- Criar interface gráfica

---

## 👨‍💻 Autor

Rodrigo da Costa  
Estudante de Análise e Desenvolvimento de Sistemas  
Focado em C# e desenvolvimento backend
