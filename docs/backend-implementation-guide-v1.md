# NestIn: Backend Implementation Guide v1

This document helps backend developers understand the structure of the NestIn backend project. It explains the project architecture, file structure, key concepts, and how to add new features step-by-step.

## Architecture

We follow **Clean Architecture** using **ASP.NET**. The backend solution is split into three main projects:

- `Nestin.Api` – ASP.NET API project.
- `Nestin.Core` – Class Library for core business logic.
- `Nestin.Infrastructure` – Class Library for infrastructure logic (like database, services, etc.).

### `Nestin.Api` Project

This project handles the API logic like **Controllers**, **Filters**, and general API utilities.

#### File Structure: API

- `Controllers` – Contains all controller classes. Naming follows the pattern `ResourceController.cs` (e.g., `RegionsController.cs`). All controllers extend a shared `BaseController`.
- `Filters` – Contains custom Action and Exception filters.
- `Utils` – Contains any helper or utility classes used in the API.

#### `BaseController`

This is an abstract class used as a base for all controllers. It includes common configurations used by controllers.

### `Nestin.Core` Project

This project contains the core business logic like **Entities**, **DTOs**, **Interfaces**, and **Mappings**.

#### File Structure: Core

- `Dtos` – Contains all Data Transfer Objects (DTOs) used in the API.
- `Entities` – Contains entity classes (without data annotations). These will be configured in the `Infrastructure` project using Fluent API.
- `Interfaces` – Contains interfaces for repositories and services. These will be implemented in the `Infrastructure` project.
- `Mappings` – Contains static classes with extension methods for converting between Entities and DTOs.
- `Shared` – Contains shared code used across the core project.

### `Nestin.Infrastructure` Project

This project handles external concerns like databases and services.

#### File Structure: Infrastructure

- `Data` – Focuses on **EF Core** setup:
  - `AppDbContext` – Main database context.
  - `Migrations` – Contains EF Core migration files.
  - `Seeds` – Contains data seeding classes.
  - `Configurations` – Contains Fluent API configurations for entities.
- `Repositories` – Contains implementations for repository interfaces defined in the Core project.
- `Services` – Contains service implementations from Core interfaces.
- `Shared` – Contains shared logic for infrastructure.

## Common Design Patterns

### Generic Repository

We use the **Generic Repository Pattern** to provide reusable CRUD operations for all entities.

It uses two types:

- `TEntity` – The entity type.
- `T` – The type of the entity's ID.

This pattern helps reduce repeated code across different repositories.

### Unit of Work

We use the **Unit of Work Pattern** to group all repositories into a single class. It acts like a factory and makes it easier to manage and inject repositories.

When you add a new repository, update both:

- `IUnitOfWork` (interface)
- `UnitOfWork` (implementation)

## How to Implement New Features

### Add a New Entity

1. Add a new class in `Nestin.Core/Entities`.
2. Extend `BaseEntity` and set the correct ID type (e.g., `int`, `Guid`, etc.).
3. Create a Fluent API configuration class in `Nestin.Infrastructure/Data/Configurations`.
4. Add a `DbSet` for the entity in `AppDbContext`.
5. (Optional) Add a seed class in `Nestin.Infrastructure/Data/Seeds`.

### Add a New Repository

1. Create a repository interface in `Nestin.Core/Interfaces`. Extend [`IGenericRepository`](#generic-repository).
2. Create a repository implementation in `Nestin.Infrastructure/Repositories`. Extend `GenericRepository` and implement your interface.
3. Update the [Unit of Work](#unit-of-work) to include the new repository.

### Add Mappings

1. Create a static class in `Nestin.Core/Mappings`.
2. Add extension methods to map between Entity and DTO, and vice versa.

### Add a New Controller

1. Create a new controller class in `Nestin.Api/Controllers` using a plural resource name (e.g., `RegionsController.cs`).
2. Inherit from `BaseController`.

That’s it! This guide helps keep the backend clean, consistent, and easy to extend for all developers on the team.
