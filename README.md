<a href="https://www.linkedin.com/in/henri-marques/">
 <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/37425086?v=4" width="100px;" alt=""/>
 <br />
 <sub><b>Henrique Marques</b></sub></a> <a href="https://www.linkedin.com/in/henri-marques/" title="Linkedin">🧑🏻‍💻
 </a>

Feito por Henrique Marques 👋🏽!

[![Twitter Badge](https://img.shields.io/badge/-@Henrimarques18-1ca0f1?style=flat-square&labelColor=1ca0f1&logo=twitter&logoColor=white&link=https://twitter.com/Henrimarques18)](https://twitter.com/Henrimarques18) [![Linkedin Badge](https://img.shields.io/badge/-Henrique_Marques-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/henri-marques/)](https://www.linkedin.com/in/henri-marques/)
[![Gmail Badge](https://img.shields.io/badge/-henmarques-c14438?style=flat-square&logo=Gmail&logoColor=white&link=mailto:henmarques2009@gmail.com)](mailto:henmarques2009@gmail.com)

---

<h1 align="center">R.O.B.O API </h1>

<h1 align="center">
    <a href="https://learn.microsoft.com/en-us/dotnet/core/compatibility/6.0">🔗 WEB API .Net 6</a>
</h1>
<p align="center">🚀 Web API Simples desenvolvida com .Net 6 utilizando DDD (Domain-Driven Design)</p>

## 🩺 Testes

Utilizado XUnit na realização dos testes

## 🏤 Arquitetura

Utilizado a arquitetura <a href="https://pt.stackoverflow.com/questions/19548/o-que-realmente-%C3%A9-ddd-e-quando-ele-se-aplica">🔗 DDD (Domain-Driven Design) </a>

## 🎲 Banco de dados

Utilizado SQLite para armazenamento e CRUD dos dados

## ✔️ Algumas dicas para utilizar a API

- `Em caso de erro: 'No such table' ao iniciar a aplicação, seguir os passos`:

```bash
  # acessar a pasta /Data do projeto
  cd {LOCAL_DIRETORIO_DO_PROJETO}/Data

  # executar o comando abaixo para gerar a migration
  dotnet ef migrations add InitialCreation -o Data\Migrations

  # executar o comando abaixo para atualizar as tabelas no SQLite
  dotnet ef database update
```

- `Buildar a aplicação`: Realizar o build/exec da aplicação (visual strudio ou vs code);
- `.Net 6`: É necessário ter o .Net 6 instalado na máquina. Caso não tenha acessar o <a href="https://learn.microsoft.com/pt-br/dotnet/core/install/windows?tabs=net70">🔗 Tutorial</a> para auxilio.

## ℹ️ Infos adicionais

[XUnit](https://learn.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-dotnet-test) <br/>
[.Net 6](https://learn.microsoft.com/en-us/dotnet/core/compatibility/6.0)<br/>
[AutoMapper](https://docs.automapper.org/en/stable/Getting-started.html)<br/>
[Moq](https://github.com/moq/moq4)<br/>
[Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore)<br/>
