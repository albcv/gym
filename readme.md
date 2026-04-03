# 🏋️‍♂️ Sistema de Gestión de Gimnasio

Aplicación de escritorio desarrollada en **C#** y **.NET Framework** (Windows Forms) para la administración integral de un gimnasio. Permite gestionar personas, registrar pagos mensuales y mantener los datos en archivos XML sin necesidad de un motor de base de datos externo.

---

## ✨ Características principales

- **Gestión de personas** con almacenamiento persistente en XML.
- **Control de pagos mensuales** 
- **Arquitectura por capas** (Modelo – Vista – Controlador) para facilitar el mantenimiento y la escalabilidad.
- **Interfaz amigable** con menús, formularios modales y recursos gráficos 

---

## 🛠️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET Framework 4.5+ (compatible con versiones posteriores)
- **Interfaz gráfica:** Windows Forms
- **Componentes externos:** AForge.NET (controles y procesamiento multimedia)
- **IDE recomendado:** Visual Studio 2012 / 2015 / 2017 / 2019 / 2022

---

## 📁 Estructura del proyecto

```
Gimnasio/
├── Controlador/ # Lógica de negocio (clase Controlador.cs)
├── Modelo/ # Clases de dominio (Persona.cs)
├── Vista/ # Formularios (Menú, Gestionar_Persona, Pagos_Día)
├── Properties/ # Configuración del proyecto (AssemblyInfo, Resources, Settings)
├── Resources/ # Imágenes y recursos gráficos 
├── App.config # Configuración de la aplicación
├── Program.cs # Punto de entrada
├── Gimnasio.csproj # Archivo de proyecto
└── ... (otros archivos .ico, .resx, .Designer.cs)

```