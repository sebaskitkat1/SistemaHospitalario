# Sistema Hospitalario — Plantilla WinForms

Plantilla de proyecto **.NET 8 WinForms (C#)** lista para abrir en Visual Studio 2026.
Sin lógica funcional ni conexión a base de datos — únicamente el **esqueleto visual** según el documento `HOSPITAL_UI_DESIGN.md`.

## 📁 Estructura

```
HospitalSystem/
├── HospitalSystem.sln
└── HospitalSystem/
    ├── HospitalSystem.csproj      ← .NET 8 + FontAwesome.Sharp + Oracle.ManagedDataAccess
    ├── Program.cs                 ← entry point → FrmPortal
    ├── Common/
    │   ├── AppColors.cs           ← paleta (prioridades, estados, primario, etc.)
    │   └── AppFonts.cs            ← tipografía Segoe UI
    ├── Forms/
    │   ├── Auth/
    │   │   ├── FrmPortal.cs/.Designer.cs              ← bifurcación Personal/Paciente
    │   │   ├── FrmLoginPersonal.cs/.Designer.cs       ← SplitContainer + login
    │   │   └── FrmLoginPaciente.cs/.Designer.cs       ← CURP + fecha de nac.
    │   ├── Admin/
    │   │   └── FrmAdminDashboard.cs/.Designer.cs      ← Sidebar + content host
    │   ├── SuperAdmin/
    │   │   └── FrmSuperAdminDashboard.cs/.Designer.cs ← hereda Admin + opciones avanzadas
    │   ├── Paciente/
    │   │   └── FrmPacienteDashboard.cs/.Designer.cs   ← TabControl 3 pestañas
    │   └── Shared/
    │       ├── FrmEditPaciente.cs        ← stubs de modales (sin lógica)
    │       ├── FrmEditMedico.cs
    │       ├── FrmEditCita.cs
    │       ├── FrmEditEspecialidad.cs
    │       ├── FrmEditReceta.cs
    │       ├── FrmEditRol.cs              (FrmEditRol + FrmEditPermiso)
    │       ├── FrmEditUsuario.cs          (FrmEditUsuario + FrmAsignarRol)
    │       ├── FrmConfirmacionPeligrosa.cs
    │       └── FrmModalesPaciente.cs      (Registro, Reprogramar, Éxito, VerReceta)
    └── UserControls/
        ├── Admin/
        │   ├── UcInicio.cs
        │   ├── UcPacientes.cs
        │   ├── UcMedicos.cs
        │   ├── UcCitas.cs
        │   ├── UcEspecialidades.cs
        │   └── UcRecetas.cs
        └── SuperAdmin/
            ├── UcAuditoria.cs
            ├── UcRolesPermisos.cs
            ├── UcUsuarios.cs
            ├── UcMantenimientoBD.cs
            └── UcRespaldosTriggers.cs
```

## 🚀 Cómo abrir

1. Abrir **Visual Studio 2026** (Windows).
2. `File → Open → Project/Solution…` → seleccionar `HospitalSystem.sln`.
3. Esperar a que se restauren los paquetes NuGet (`FontAwesome.Sharp`, `Oracle.ManagedDataAccess.Core`).
4. Establecer `HospitalSystem` como proyecto de inicio (clic derecho → *Set as Startup Project*).
5. `F5` para ejecutar → aparece `FrmPortal`.

## ✅ Lo que ya funciona (visualmente)

- **FrmPortal** con bifurcación clickable.
- **FrmLoginPersonal** y **FrmLoginPaciente** con campos completos (CURP enmascarado, fecha de nacimiento, etc.).
- **FrmAdminDashboard** con sidebar funcional que cambia el UserControl central.
- **FrmSuperAdminDashboard** hereda del anterior y añade los 5 botones de opciones avanzadas.
- **FrmPacienteDashboard** con TabControl de 3 pestañas.

## 🛠 Lo que queda por completar (intencional)

Cada UserControl y modal contiene un comentario `/// <summary>` y un `// TODO` listando los controles que faltan agregar — según el documento de diseño `HOSPITAL_UI_DESIGN.md`.

**Orden sugerido de implementación:**
1. `UcPacientes` (es el módulo de referencia con todas las reglas de UI)
2. `FrmEditPaciente` (modal con ComboBox de prioridad)
3. Replicar patrón en `UcMedicos`, `UcCitas`, `UcEspecialidades`, `UcRecetas`
4. Forms avanzados (`UcAuditoria` → `UcRolesPermisos` → `UcUsuarios` → resto)
5. `FrmPacienteDashboard` (wizard de agendado en 3 pasos)
6. Cuando esté toda la UI: conectar `Oracle.ManagedDataAccess.Client` (capa de datos en `Data/` — aún no creada)

## 📚 Referencias

- Documento maestro de diseño: `/app/HOSPITAL_UI_DESIGN.md`
- Esquema Oracle base: `Base de datos Hospital 2.txt`
