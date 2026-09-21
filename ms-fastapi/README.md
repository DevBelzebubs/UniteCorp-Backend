# UniteCorp — MS FastAPI

Microservicio **FastAPI** de UniteCorp (scaffold por defecto, sin dominio).

## Requisitos

- Python 3.13+
- PostgreSQL (o `docker compose up -d`)

## Setup

```bash
python -m venv .venv
.venv\Scripts\activate
pip install -r requirements.txt
copy .env.example .env
```

## Ejecutar

```bash
uvicorn app.main:app --reload --port 8000
```

- API docs: http://localhost:8000/docs
- Health: http://localhost:8000/health

## Tests

```bash
pytest
```

## Base de datos

`DATABASE_URL` apunta a `postgresql+asyncpg://unitecorp:unitecorp@localhost:5432/unitecorp_fastapi`
(iniciada por `docker-compose.yml` en la raíz de `UniteCorp-Back`).