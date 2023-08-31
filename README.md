
## ------ 💀🦴 skeleto base para creacion de backend 🦴💀-----

en el repositorio esta contenida la estructura basica para la creacion y consecutivamente añadir un backend de gran tamaño en .NET

### informacion detallada de paquetes en el proyecto



| paquete | Type     | ubicacion                |
| :-------- | :------- | :------------------------- |
| `entity framework core` | `extension` | **Required**. En carpeta persistencia y dominio |
| `fluent api` | `extension` | **Required**. En carpeta Dominio |
| `itext7` | `extension` | **Required**. en carpeta dominio |
| `pomelo` | `extension` | **Required**. en carpeta persistencia |
| `system model tokens` | `extension` | **Required**. en carpeta seguridad |
| `jwtbearer` | `extension` | **Required**. en carpeta API |
| `aspnetcoreRateLimiter` | `extension` | **Required**. en carpeta API |
| `Automapper` | `extension` | **Required**. en carpeta API |
| `aspnet.mvc.versioning` | `extension` | **Required**. en carpeta API |
| `aspnetcoreRateLimiter` | `extension` | **Required**. en carpeta API |
| `entityframework.core.design` | `extension` | **Required**. en carpeta API |





una vez clonado el repositorio porfavor ejectutar el comando. Para restablecer las depdendencias ya instaladas en el mismo

```c#
  dotnet restore
```
luego reemplace las credenciales ya definidas por defecto y proporcione sus credenciales propias.