# 💰 Cashflow API

![.NET](https://img.shields.io/badge/.NET-8.0-purple)
![Docker](https://img.shields.io/badge/docker-enabled-blue)
![PostgreSQL](https://img.shields.io/badge/database-PostgreSQL-blue)
![Architecture](https://img.shields.io/badge/architecture-clean--architecture-green)

API de controle de fluxo de caixa desenvolvida em .NET, seguindo princípios de Clean Architecture.

---

## 📌 Sobre o Projeto

Esta API permite o registro e consulta de lançamentos financeiros (entradas e saídas), com persistência em banco PostgreSQL.

O objetivo é demonstrar boas práticas de arquitetura, organização de código e uso de tecnologias modernas do ecossistema .NET.

---

## 🧩 Arquitetura (Visão Geral)

```
           ┌──────────────────────┐
           │     Swagger UI       │
           └──────────┬───────────┘
                      │
                      ▼
           ┌──────────────────────┐
           │    Cashflow.Api      │
           │   (Controllers)      │
           └──────────┬───────────┘
                      │
                      ▼
           ┌──────────────────────┐
           │ Cashflow.Application │
           │    (Services)        │
           └──────────┬───────────┘
                      │
                      ▼
           ┌──────────────────────┐
           │   Cashflow.Domain    │
           │   (Entities/Rules)   │
           └──────────┬───────────┘
                      │
                      ▼
           ┌──────────────────────────┐
           │ Cashflow.Infrastructure  │
           │   (EF Core / DB)         │
           └──────────┬──────────────┘
                      │
                      ▼
           ┌──────────────────────┐
           │     PostgreSQL       │
           └──────────────────────┘
```

### 🔎 Fluxo da Requisição

1. Cliente envia requisição (Swagger/Postman)
2. Controller recebe e valida
3. Application executa regras
4. Domain representa entidades
5. Infrastructure persiste via EF Core
6. Dados armazenados no PostgreSQL

---

## 🧠 Decisões Arquiteturais

- **Clean Architecture**  
  Separação em camadas para baixo acoplamento e alta manutenibilidade

- **Entity Framework Core**  
  ORM para acesso a dados e migrations

- **PostgreSQL**  
  Banco robusto e open source

- **Docker**  
  Padronização de ambiente

- **Swagger (OpenAPI)**  
  Documentação interativa

---

## 🏗️ Estrutura do Projeto

```
Cashflow.Api            → Controllers / API
Cashflow.Application    → Serviços / regras
Cashflow.Domain         → Entidades
Cashflow.Infrastructure → Banco / EF Core
Cashflow.Worker         → Processos futuros
```

---

## 📌 Regras de Negócio

- type:
  - income → entrada
  - expense → saída

- amount deve ser maior que zero

- Campos:
  - Id (UUID)
  - Amount
  - Date
  - Type
  - Description

---

## 🚀 Como executar

### 1. Subir ambiente
```
docker-compose up -d
```

### 2. Aplicar migrations
```
dotnet ef database update
```

### 3. Rodar API
```
dotnet run --project Cashflow.Api
```

### 4. Swagger
```
http://localhost:5075/swagger
```

---

## 📡 Endpoints

### ➕ POST /cashflow

```json
{
  "amount": 150.75,
  "date": "2026-04-24T14:00:00Z",
  "type": "income",
  "description": "Salário"
}
```

---

### 📄 GET /cashflow

Retorna todos os lançamentos.

---

## 🧪 Testes

Pode ser testado via:
- Swagger
- Postman

---

## 📷 Preview

Swagger:
http://localhost:5075/swagger

---

## 👨‍💻 Autor

Jeferson Loreto  
Solutions Architect | .NET | AWS | Azure

