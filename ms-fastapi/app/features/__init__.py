"""Capa de negocio: un paquete por bounded context (Clean Architecture + DDD).

Bounded contexts de este ms: ``content`` y ``newsletter``.

Cada feature se arma con esta convencion::

    app/features/<feature>/
      domain/           # entidades, value objects y contratos (ABC de repositorio)
      application/      # casos de uso / logica de orquestacion
      infrastructure/   # implementaciones concretas (SQLAlchemy, HTTP, etc.)
      api.py            # APIRouter del feature

Reglas de dependencia:

- ``domain/`` no importa nada de ``application/`` ni de ``infrastructure/``,
  ni librerias externas.
- ``application/`` depende de las interfaces (puertos) definidas en ``domain/``,
  nunca de sus implementaciones.
- ``infrastructure/`` implementa los puertos de ``domain/``.
- La presentacion (``api.py``) consume casos de uso, no repositorios.

Ojo: Python exige ``__init__.py`` en cada subcarpeta para que sea importable.
A diferencia de .NET o Java, la carpeta vacia no existe: hay que crear el
archivo ``__init__.py`` primero.
"""
