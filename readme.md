# Aplicación de notas de React
El objetivo de este repositorio es aprender un poco como funciona ASP.NET Core por dentro.

Empezaremos con lo básico. Tipos de datos, métodos, clases y por ultimo lo que haremos es completar con un framework que queráis a llamar a la api.

Este repositorio contiene un ejemplo de cómo funciona por detrás ASP.

Como venís de un curso en el pasado, me imagino que ya conoceis los tipos de datos. Pues en .NET es parecido.

EN el archivo [chuleta.md](./chuleta.md) (Mas tarde la elaborare) tenéis algunos ejemplos de sintaxis de .NET

De momento, sentiros libres de descargar y montar el proyecto con git.

> ## Pasos para descargar el proyecto y montarlo en local
> 1. Abris Visual Studio 2022
> 2. A la derecha, hay un botón que pone "Clonar repositorio"
> 3. En "Ubicación del repositorio" poneis `https://github.com/RubenPX/NotasApp-react.net.git` y le dais a "Clonar"

Una vez tengais el proyecto ya en vuestro pc, podeis pulsar en "Iniciar". Aqui se abren varias ventanas. (Es normal, ya que esta plantilla oficial se separa en dos proyectos (.net Core y Vite))

- `Terminal`: Ventana de la aplicación de ASP .NET Core
- `Terminal`: Ventana de la aplicación del frontend
- `Web`: Pagina web de la aplicación
- `WEB`: Pagina web de Swagger

De momento solo esta definido las

## Estructura del proyecto

### reactapp1.client
  Dentro de esta carpeta, hay una plantilla de un proyecto de react (Aun no hay nada definido de interfaz)

### ReactApp.Server
  Dentro de esta carpeta, esta el proyecto del backend.

  Estructura de carpetas:
  - Controllers: Aqui se almacenaran todas las rutas que va a usar la aplicación. Lo normal aqui es que siga un patrón. Poer ejemplo: `[algo]Controller.cs` El nombre del archivo siempre terminará por Controller.cs
  - Domain: Aqui se define los tipos de datos que se van a usar en la aplicación. Puede contener algun tipo de logica, pero tiene que ser minima
  - Repository: Aqui se define todo lo que va a tocar entrada y salida de datos (I/O). Da igual que sea un acceso SQL, Sistema de archivos o en memoria.

  > [!note]
  > Ojo, no todos los proyectos siguen la misma estructura, cada proyecto tiene su propia jerga y forma de organizar las cosas. Pero lo normal es que se siga una plantilla o idea en comun

