"""Capa de infraestructura de `content`.

Donde se tocan los detalle reales: modelos SQLAlchemy, repositorios y el
wiring de DI. Esta capa IMPLEMENTA los puertos declarados en ``domain/ports.py``.

Archivos esperados:

- ``models.py``        modelos SQLAlchemy (``Base`` de ``app.db.base``)
- ``repositories.py``  implementaciones concretas de los puertos
- ``container.py``     funciones con ``Depends`` que unen puerto -> adaptador

``container.py`` existe por una razon concreta: en .NET el contenedor de DI
resuelve solo, asi que el endpoint no necesita saber nada. En FastAPI
``Depends`` ES el punto de composicion, y quien declara la dependencia tiene
que conocer a la vez el caso de uso y el adaptador. Por eso el wiring vive
aca y no en ``application/``, que no puede importar esta capa.
"""
