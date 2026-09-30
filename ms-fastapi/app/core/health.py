"""Router de health. Cross-cutting, no es una feature.

Por eso vive en ``core/`` y no en ``app/features/``: no pertenece a ningun
bounded context y no tiene dominio, casos de uso ni repositorio.

Ojo: este endpoint devuelve un literal. No prueba la base de datos, asi que
va a seguir verde aunque Postgres este caido. Cuando agregues el chequeo real,
usá ``app.db.session`` para abrir una conexion y hacer un ``SELECT 1``.
"""
from fastapi import APIRouter

router = APIRouter()


@router.get("/health")
async def health() -> dict[str, str]:
    return {"status": "ok"}
