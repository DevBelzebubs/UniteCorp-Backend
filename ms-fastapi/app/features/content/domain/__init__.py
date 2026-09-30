"""Capa de dominio de `content`.

Aqui van las entidades y los contratos (puertos). Es la capa mas pura del
slice: no importa NADA de fuera de este paquete salvo ``app.shared``.

Prohibido por el contrato `content-domain-pure` de ``.importlinter``:

- ``fastapi``, ``sqlalchemy``, ``pydantic``  -- nada de frameworks
- ``app.core``, ``app.db``                   -- nada de infraestructura
- ``application``, ``infrastructure``         -- el dominio no conoce a los
                                               que dependen de el
- ``app.features.newsletter``                 -- features aisladas entre si

Los DTO de Pydantic NO van aca: van en ``application/schemas.py``. Si las
entidades del dominio fueran ``BaseModel``, el dominio dependeria de Pydantic
y dejaria de ser hexagonal.
"""
