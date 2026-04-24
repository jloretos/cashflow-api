# 💰 Cashflow API

API para controle de fluxo de caixa desenvolvida em .NET, utilizando boas práticas de arquitetura (Clean Architecture), Entity Framework Core e PostgreSQL.

---

## 🚀 Tecnologias

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- Docker
- Swagger (OpenAPI)

---

## 🧱 Arquitetura

O projeto segue princípios de **Clean Architecture**, com separação de responsabilidades:

- **Cashflow.Api** → Camada de apresentação (Controllers)
- **Cashflow.Application** → Regras de negócio (Services)
- **Cashflow.Domain** → Entidades e contratos
- **Cashflow.Infrastructure** → Acesso a dados (EF Core)
- **Cashflow.Worker** → Processos assíncronos (futuro uso)

---

## ⚙️ Como executar

### 🔹 Pré-requisitos
- .NET SDK instalado
- Docker instalado

---

### 🔹 Subir banco de dados

```bash
docker-compose up -d
```

---

### 🔹 Rodar API

```bash
dotnet run --project Cashflow.Api
```

---

### 🔹 Acessar Swagger

```
http://localhost:5075/swagger
```

---

## 📌 Endpoints

### ➕ Criar lançamento

**POST** `/cashflow`

```json
{
  "amount": 150.75,
  "date": "2026-04-24T14:00:00Z",
  "type": "income",
  "description": "Salário"
}
```

---

### 📄 Listar lançamentos

**GET** `/cashflow`

---

## 🗄️ Banco de dados

- PostgreSQL rodando via Docker
- Migrations gerenciadas via EF Core

```bash
dotnet ef database update -p Cashflow.Infrastructure -s Cashflow.Api
```

---

## 📈 Melhorias futuras

- Autenticação (JWT)
- Paginação e filtros
- Separação de comandos e queries (CQRS)
- Testes automatizados
- Mensageria (Kafka/RabbitMQ)

---

## 👨‍💻 Autor

Jeferson Loreto  
Arquiteto de Soluções | .NET | Cloud | Microsserviços
