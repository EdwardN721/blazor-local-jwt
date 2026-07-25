# 🔓 Blazor Local JWT Decoder

![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet)
![Blazor WebAssembly](https://img.shields.io/badge/Blazor-WASM-5C2D91?style=for-the-badge&logo=blazor)
![License](https://img.shields.io/badge/License-MIT-blue.svg?style=for-the-badge)

Una herramienta de desarrollo para decodificar JSON Web Tokens (JWT) construida completamente en **C# y Blazor WebAssembly**. 

A diferencia de otras herramientas en línea, este decodificador se ejecuta **en el navegador del cliente**. Ningún token, claim o información confidencial abandona tu máquina, garantizando máxima seguridad para entornos de desarrollo corporativos.

## ✨ Características

* **Zero-Server Processing:** Todo el parseo y decodificación ocurre en el cliente vía WebAssembly.
* **Decodificación en Tiempo Real:** Interfaz reactiva que formatea el Header y el Payload (JSON) conforme escribes o pegas el token.
* **Arquitectura Limpia:** Construido usando mejores prácticas de 2026 (Feature Folders, Code-Behind, Inyección de Dependencias y CSS Isolation).
* **Easter Egg 🥚:** Incluye un módulo secreto para emergencias de desarrollo. Navega a `/excusas` para descubrirlo.

## 🏗️ Arquitectura del Proyecto

El proyecto se aleja de la estructura tradicional y utiliza **Feature Folders** para maximizar la cohesión:

```text
Features/
 ├── JwtDecoder/
 │    ├── JwtDecoder.razor          # UI pura y bindings
 │    ├── JwtDecoder.razor.cs       # Code-Behind (Lógica de la vista)
 │    ├── JwtDecoder.razor.css      # Estilos aislados
 │    └── Services/                 # Lógica de negocio inyectable
 └── Excusas/                       # Módulo independiente