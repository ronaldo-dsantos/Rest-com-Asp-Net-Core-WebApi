# REST com ASP.NET Core WebAPI

Este repositório contém a implementação de uma API RESTful desenvolvida durante o curso **REST com ASP.NET Core WebAPI** da plataforma desenvolvedor.io. O projeto segue boas práticas e aplica conceitos modernos no desenvolvimento de APIs utilizando .NET.

## 🔗 Repositório no GitHub  
[Rest-com-Asp-Net-Core-WebApi](https://github.com/ronaldo-dsantos/Rest-com-Asp-Net-Core-WebApi)

---

## 📌 Tecnologias Utilizadas

- **ASP.NET Core WebAPI**
- **Entity Framework Core**
- **SQL Server**
- **ASP.NET Identity + JWT** (Autenticação e Autorização)
- **AutoMapper** (Mapeamento de objetos)
- **Swagger** (Documentação da API)
- **HealthChecks** (Monitoramento)
- **Elmah.io** (Logging)
- **CORS** (Compartilhamento de recursos entre origens)
- **Postman** (Testes e consumo da API)
- **IIS e Azure** (Deploy)

---

## 🎯 Funcionalidades Implementadas

- CRUD completo para **Fornecedores** e **Produtos**
- Upload de imagens
- Padrão de respostas padronizadas para erros de validação e negócios
- Autenticação e Autorização com **JWT** e **Claims-Based Authorization**
- Versionamento da API
- Logging com **Elmah.io**
- Monitoramento de saúde com **HealthChecks**

---

## 🚀 Como Executar o Projeto

### 1️⃣ Clonar o Repositório

Clone o repositório:

```bash
git clone https://github.com/ronaldo-dsantos/Rest-com-Asp-Net-Core-WebApi.git
```

Navegue até a pasta do projeto:

```bash
cd Rest-com-Asp-Net-Core-WebApi
```

### 2️⃣ Configurar o Banco de Dados

Certifique-se de ter o **SQL Server** instalado.

Atualize a string de conexão no arquivo `appsettings.json`:

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=SEU_BANCO;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

Execute as migrações para criar o banco de dados:

```bash
dotnet ef database update
```

### 3️⃣ Executar a API

Execute a aplicação:

```bash
dotnet run
```

### 4️⃣ Testar a API

- Acesse o **Swagger**: [https://localhost:5001/swagger](https://localhost:5001/swagger)
- Utilize o **Postman** para testar as rotas.

---

## 📄 Endpoints Principais

### 🏷 Autenticação

- `POST /api/auth/login` → Gera um token JWT  
- `POST /api/auth/register` → Registra um novo usuário  

### 🏢 Fornecedores

- `GET /api/fornecedores` → Lista todos os fornecedores  
- `POST /api/fornecedores` → Cria um novo fornecedor  
- `PUT /api/fornecedores/{id}` → Atualiza um fornecedor  
- `DELETE /api/fornecedores/{id}` → Remove um fornecedor  

### 📦 Produtos

- `GET /api/produtos` → Lista todos os produtos  
- `POST /api/produtos` → Cria um novo produto  
- `PUT /api/produtos/{id}` → Atualiza um produto  
- `DELETE /api/produtos/{id}` → Remove um produto  

---

## 🚀 Deploy

A API pode ser implantada no **IIS** ou **Azure**. O curso abordou:

- Deploy Local IIS  
- Deploy Self-Hosting  
- Deploy no Azure  

---

## 📜 Licença

Este projeto foi desenvolvido para fins educacionais durante o curso da **desenvolvedor.io**.  