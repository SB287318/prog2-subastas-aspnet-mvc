# Ventas y subastas — Programación 2

Obligatorio 2 de **Programación 2** (Universidad ORT, segundo semestre de 2024): aplicación web **ASP.NET Core MVC (.NET 8)**. El dominio modela artículos, publicaciones de venta y de subasta, ofertas y usuarios clientes.

## Estructura

```
Implementacion/
  Obligatorio2.sln
  LogicaNegocio/   Biblioteca de clases con el dominio (Articulo, Publicacion, PublicacionVenta,
                   PublicacionSubasta, Oferta, Usuario, UsuarioCliente, Sistema)
  MVC/             Aplicación web (Controllers, Models, Views, wwwroot)
docs/              Diagrama UML (Astah) y documento de entrega
```

## Cómo correrlo

Requiere el **SDK de .NET 8**.

```bash
dotnet run --project Implementacion/MVC
```
