# Teste de programação FIAP

Prova de desenvolvimento C#

# Instalação

Como startar o projeto

### Requisitos

* [Node.js](https://nodejs.org/)
* [Angular CLI](https://cli.angular.io)
* [Dotnet Core](https://dotnet.microsoft.com/download)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)

Antes de executar os scripts que estão na pasta principal, necessário trocar informação de banco no appsettings.json do projeto FIAP.ParceriaAPI.

Pode ser usado o DB direto do docker, ou algum outro DB, o script de criação do banco está disponivel também na pasta principal.

Para executar o projeto basta executar os scripts que estão na pasta principal.

Abra o Windows Powershell e execute os seguintes comandos:

```sh
$ .\configDbDocker.sh (OPCIONAL)
$ .\start.sh 
$ .\configAngular.sh
```
