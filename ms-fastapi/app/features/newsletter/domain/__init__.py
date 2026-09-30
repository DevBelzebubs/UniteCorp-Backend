"""Capa de dominio de `newsletter`.

Entidades y puertos. Prohibido por el contrato `newsletter-domain-pure` de
``.importlinter``: frameworks, ``app.core``, ``app.db``, las capas hermanas
y la feature ``content``.

Los DTO de Pydantic van en ``application/schemas.py``, no aca: si las
entidades fueran ``BaseModel``, el dominio dependeria de Pydantic.
"""
