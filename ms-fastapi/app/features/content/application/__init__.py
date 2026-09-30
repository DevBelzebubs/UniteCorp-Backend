"""Capa de aplicacion de `content`.

Casos de uso (orquestacion) y DTOs de Pydantic. Depende UNICAMENTE del
puerto declarado en ``domain/ports.py``, nunca de su implementacion.

Prohibido por el contrato `content-application-clean` de ``.importlinter``:

- ``sqlalchemy``, ``app.db``     -- no se el como se guarda
- ``fastapi``                    -- los casos de uso son funciones/clases
                                   planas; el HTTP vive en ``api.py``
- ``infrastructure``             -- no se conoce el adaptador
- ``app.features.newsletter``    -- features aisladas entre si

Excepcion: ``pydantic`` SI se permite, porque ``schemas.py`` lo necesita.

Ojo con la transaccion: ``get_session`` no hace commit. La unidad de trabajo
(commit en exito, rollback ante excepcion) hay que resolverla explicitamente
en el caso de uso o en un ``Depends`` de ``infrastructure/container.py``.
"""
