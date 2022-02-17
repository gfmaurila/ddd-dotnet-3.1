# DDD .Net 3.1

# Iniciar os segredos de usuários
- dotnet user-secrets init --project .\DemoDDDDapperIoc31.csproj 

# Configurar a string de conexão ao banco de dados
- dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost,1433;Database=Demo;User=sa;Password=***;MultipleActiveResultSets=true"
- dotnet user-secrets list --project .\DemoDDDDapperIoc31.csproj

# Deletar um segredo de usuário da aplicação.
- dotnet user-secrets remove "[CHAVE]"

# Banco
- cd Infrastructure.Data
- Add-Migration InitialCreate
- Update-Database

# Estrutura
- .NET Core 3.1: Framework para desenvolvimento da Microsoft.
- AutoMapper: Biblioteca para realizar mapeamento entre objetos.
- Swagger: Documentação para a API.
- DDD: Domain Drive Design modelagem de desenvolvimento orientado a injeção de dependência.
- Entity FrameWork

