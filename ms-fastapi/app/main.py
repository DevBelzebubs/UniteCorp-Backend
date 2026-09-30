from fastapi import FastAPI

from app.core import health
from app.core.config import settings
from app.features.content import api as content_api
from app.features.newsletter import api as newsletter_api

app = FastAPI(title=settings.app_name, version="0.1.0")

# Cross-cutting
app.include_router(health.router)

# Features. El prefix y los tags se registran aca, no en el router del feature:
# asi el feature no sabe nada de como se monta en la URL.
app.include_router(content_api.router, prefix="/api/content", tags=["content"])
app.include_router(newsletter_api.router, prefix="/api/newsletter", tags=["newsletter"])


@app.get("/")
async def root() -> dict[str, str]:
    return {"service": settings.app_name, "status": "running"}
