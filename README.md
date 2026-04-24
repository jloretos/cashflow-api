# 💰 Cashflow API

API de controle de fluxo de caixa desenvolvida em .NET, seguindo princípios de Clean Architecture.

---

## 📌 Sobre o Projeto

Esta API permite o registro e consulta de lançamentos financeiros (entradas e saídas), com persistência em banco PostgreSQL.

O objetivo é demonstrar boas práticas de arquitetura, organização de código e uso de tecnologias modernas do ecossistema .NET.

---

## 🧠 Decisões Arquiteturais

- **Clean Architecture**  
  Separação em camadas (API, Application, Domain, Infrastructure) para garantir baixo acoplamento, manutenibilidade e testabilidade.

- **Entity Framework Core**  
  Utilizado como ORM para abstração do acesso a dados e gerenciamento de migrations.

- **PostgreSQL**  
  Banco de dados relacional robusto, open source e amplamente utilizado em ambientes cloud.

- **Docker**  
  Utilizado para padronizar o ambiente e facilitar execução local.

- **Swagger (OpenAPI)**  
  Documentação interativa para testes e integração com a API.

---

## 🏗️ Estrutura do Projeto

```
Cashflow.Api            → Camada de apresentação (controllers, endpoints)
Cashflow.Application    → Regras de aplicação / serviços
Cashflow.Domain         → Entidades e regras de domínio
Cashflow.Infrastructure → Persistência e acesso a dados
Cashflow.Worker         → Processos assíncronos (futuro)
```

---

## 📌 Regras de Negócio

- O campo `type` pode ser:
  - `income` → entrada
  - `expense` → saída

- O campo `amount` deve ser maior que zero

- Cada lançamento contém:
  - Id (UUID)
  - Valor
  - Data
  - Tipo
  - Descrição

---

## 🚀 Como executar o projeto

### 1. Subir o banco com Docker
```
docker-compose up -d
```

### 2. Aplicar migrations
```
dotnet ef database update
```

### 3. Executar a API
```
dotnet run --project Cashflow.Api
```

### 4. Acessar documentação Swagger
```
http://localhost:5075/swagger
```

---

## 📡 Endpoints

### ➕ Criar lançamento
```
POST /cashflow
```

Exemplo:
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
```
GET /cashflow
```

---

## 🧪 Testes

Os testes podem ser realizados diretamente via Swagger UI ou ferramentas como Postman.

---

## 📷 API em execução

Swagger disponível em:  
http://localhost:5075/swagger

---

## 👨‍💻 Autor

Jeferson Loreto  
Solutions Architect | .NET | AWS | Azure
