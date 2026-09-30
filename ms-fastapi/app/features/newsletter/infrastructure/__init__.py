"""Capa de infraestructura de `newsletter`.

Modelos SQLAlchemy, repositorios, cliente del proveedor de email y
``container.py`` con el wiring de ``Depends``.

``container.py`` une puerto -> adaptador, de modo que ``api.py`` nunca
importe SQLAlchemy ni el cliente HTTP.
"""
