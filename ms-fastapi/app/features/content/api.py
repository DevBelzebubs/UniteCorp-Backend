"""Inbound adapter HTTP de `content`.

Este archivo esta FUERA de las 3 capas, y esa es la decision. Va en la raiz
del feature porque necesita conocer a la vez ``application`` (los casos de
uso que expone) e ``infrastructure`` (el ``container`` que hace el wiring).
Si estuviera dentro de ``application/``, el contrato de import-linter lo
rechazaria, y esa seria la senal de que esta en el lugar equivocado.

Por eso la convencion es: el router importa ``container.py`` y nunca toca
SQLAlchemy directamente.
"""
from fastapi import APIRouter

router = APIRouter()
