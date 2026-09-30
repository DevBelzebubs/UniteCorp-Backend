"""Inbound adapter HTTP de `newsletter`.

Fuera de las 3 capas a proposito: es el punto donde el router conoce a la vez
los casos de uso y el wiring. Importa ``infrastructure/container.py``, nunca
SQLAlchemy directo.
"""
from fastapi import APIRouter

router = APIRouter()
