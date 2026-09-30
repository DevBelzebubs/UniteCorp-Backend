"""Corre los contratos de capa de ``.importlinter`` dentro de la suite.

Es el equivalente funcional del compilador en .NET: sin esto, "hexagonal" es
solo nombres de carpeta y nada impide que un caso de uso importe sqlalchemy.
Si este test falla, alguien rompio la regla:

    domain/          -> no frameworks, no app.db, no features hermanas
    application/     -> no sqlalchemy, no fastapi, no infrastructure

Ejecutar individualmente:  pytest tests/test_architecture.py -q
"""
from importlinter.cli import lint_imports


def test_contracts_de_capa() -> None:
    assert lint_imports(config_filename=".importlinter") == 0