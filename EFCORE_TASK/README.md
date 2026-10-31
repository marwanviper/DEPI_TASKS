# Employee Management — Windows Forms and Entity Framework Core

> **Learning phase:** Data-driven .NET applications  
> **Exercise:** Model employee data and connect a Windows Forms application to a database through Entity Framework Core  
> **Status:** Coursework project; verify the database configuration and run instructions on a clean machine.

## Learning objectives

- Organize a C# Windows Forms application.
- Represent employee data with a model class.
- Configure an Entity Framework Core database context.
- Understand migrations and schema snapshots.
- Connect application code to a SQL Server database.
- Observe how an ORM maps C# entities to relational tables.

## Project structure

```text
EFCORE_TASK/
├── EFCORE_TASK.sln
├── EFCORE_TASK.csproj
├── Program.cs
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Models/
│   ├── Employee.cs
│   └── EMPCONTEXT.cs
└── Migrations/
    ├── ..._initEmployee.cs
    ├── ..._initEmployee2.cs
    └── EMPCONTEXTModelSnapshot.cs
```

## Key components

| Component | Responsibility |
|---|---|
| `Employee.cs` | Employee entity/model |
| `EMPCONTEXT.cs` | EF Core database context |
| `Migrations/` | Database schema changes over time |
| `Form1.cs` | Windows Forms application logic |
| `Program.cs` | Application entry point |
| `EFCORE_TASK.csproj` | Target framework and NuGet dependencies |

## Run locally

1. Install the .NET SDK and Visual Studio's .NET desktop development workload.
2. Open `EFCORE_TASK.sln`.
3. Review the EF Core packages and target framework in the project file.
4. Check the database connection configuration in the source.
5. Create or select a local development database.
6. Restore packages and build the solution.
7. Apply migrations only after checking that the connection points to your intended development database.
8. Run the Windows Forms application and verify the employee workflow.

Do not commit real database credentials. Use local user secrets or environment-specific configuration for connection strings.

## Validation checklist

- [ ] The solution restores and builds from a clean checkout.
- [ ] The database context connects to the intended local database.
- [ ] Migrations apply without errors.
- [ ] The employee table has the expected schema.
- [ ] The UI can perform the intended employee operations.
- [ ] Invalid input and database errors are handled clearly.

## Next improvements

- Add screenshots of the form and its main workflow.
- Document the entity fields and validation rules.
- Add a safe example connection configuration.
- Add a short explanation of why multiple migrations exist.
- Add tests for model validation and database operations where practical.
- Exclude `.vs/`, `bin/` and `obj/` from version control.

---
*Part of my DEPI software-development learning progression.*
