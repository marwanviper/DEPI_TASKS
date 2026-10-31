# DEPI Software Development Learning Portfolio

> **Learning stage:** Software development and backend foundations  
> **Focus:** C#, .NET, Windows Forms, Entity Framework Core and relational data access  
> **Status:** Learning repository — coursework tasks are preserved as practical exercises.

This repository collects hands-on exercises completed during the Digital Egypt Pioneers Initiative (DEPI) software development track. It serves as a record of progression through programming and application-development concepts, with the code and project files remaining the source of truth for what was implemented.

## Repository contents

### Entity Framework Core task

The currently visible project is:

```text
DEPI_TASKS/
└── EFCORE_TASK/
    ├── EFCORE_TASK.sln
    ├── EFCORE_TASK.csproj
    ├── Program.cs
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Models/
    └── Migrations/
```

The project contains a Windows Forms application, an employee model, an Entity Framework Core context and migration files. The committed project targets a Windows desktop framework and includes SQL Server-related EF Core dependencies.

## Learning progression

| Area | Practical evidence in this repository | Concepts |
|---|---|---|
| C# application development | Windows Forms project | Application entry point, forms and event-driven UI |
| Object-oriented design | Employee model and context | Classes, properties and separation of concerns |
| Entity Framework Core | EF Core context and migrations | ORM concepts, database mapping and schema evolution |
| Relational database workflow | SQL Server EF Core provider | Database connections, migrations and persistence |

## Run the project

The project is a Windows desktop application. To inspect or run it:

1. Install a compatible .NET SDK and Visual Studio with the .NET desktop development workload.
2. Open `EFCORE_TASK/EFCORE_TASK.sln`.
3. Review the connection configuration in the source before running.
4. Restore NuGet packages and build the solution.
5. Apply the EF Core migrations to a development database only after confirming the connection string and database target.

The repository should not be assumed to run unchanged on every machine: database configuration and the original development environment may need to be restored.

## Suggested structure

As more DEPI exercises are added, keep each task isolated and give it a descriptive name:

```text
.
├── README.md
├── EFCORE_TASK/
│   ├── EFCORE_TASK.sln
│   ├── EFCORE_TASK/
│   │   ├── Models/
│   │   ├── Data/
│   │   ├── Migrations/
│   │   └── ...
│   └── README.md
└── [future-task-name]/
```

## Current status and next improvements

The repository contains at least one committed EF Core coursework project. The latest recorded task commit is labelled **“Task 6 done”**, but that commit message alone is not proof that the entire learning track is complete.

Recommended improvements:

- Add a task-by-task index as new exercises are added.
- Document database prerequisites and provide a safe example connection configuration.
- Keep secrets and machine-specific settings out of version control.
- Add screenshots or short demonstrations of completed UI tasks.
- Add a `.gitignore` for Visual Studio, .NET build output and IDE caches; remove generated `.vs/`, `bin/` and `obj/` artifacts from tracking where appropriate.
- Add validation steps and expected results for each task.
- Record what was learned and what remains to be improved.

## Learning outcomes

This repository is intended to demonstrate the transition from programming exercises toward building data-driven .NET applications: organizing a solution, modeling entities, connecting an ORM to a relational database and evolving a schema through migrations.

---
*Maintained as a record of my DEPI software-development learning progression.*
