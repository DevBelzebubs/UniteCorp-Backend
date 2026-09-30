"""Capa de aplicacion de `newsletter`.

Casos de uso y DTOs de Pydantic. Depende unicamente de los puertos de
``domain/ports.py``.

Prohibido por el contrato `newsletter-application-clean``: ``sqlalchemy``,
``app.db``, ``fastapi``, ``infrastructure`` y la feature ``content``.
``pydantic`` si se permite para ``schemas.py``.

A diferencia de `content`, este feature integra con un proveedor de email
externo. Ese cliente va en ``infrastructure/``, nunca aca: el caso de uso
depende del puerto, no del cliente HTTP real.
"""
