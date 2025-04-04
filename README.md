# Nestin

Nestin is an online platform (similar to Airbnb) where people can rent homes or rooms for short or long stays. The platform connects **Hosts**, who want to list and rent out their properties, with **Guests**, who are looking for a place to stay whether for vacation, work, or long-term living.

## Tech Stack

- **Frontend**: Angular, TypeScript, Bootstrap, HTML, CSS
- **Backend**: ASP.NET Core, C#, Entity Framework Core.
- **Database**: SQL Server
- **Integration**: Stripe for payment processing.

## File Structure

```plaintext
Nestin
├── backend/ # (Contains the ASP.NET Core backend application (dotnet solution))
├── frontend/ # (Contains the Angular frontend application)
├── docs/ # (Contains Project Documentations)
├── .gitignore # (Git ignore file)
├── LICENSE # (Project License)
├── README.md # (Project Readme file)
```

## Setup

At first you need to clone the repository:

```bash
git clone <repo_url>
```

_Review Project File Structure [here](#file-structure)_.

### Prerequisites

- .NET SDK (version 9.0 or higher)
- Node.js (version 22 or higher)
- Angular CLI (version 19 or higher)
- SQL Server (for database)
- Visual Studio 2022 (For backend development)
- VS Code (For frontend development)

### Backend Setup

1. Navigate to the `backend` directory and find the `.sln` file.
2. Double-click the `.sln` file to open it in Visual Studio.
3. Restore the NuGet packages by right-clicking on the solution in the Solution Explorer and selecting "Restore NuGet Packages".
4. Set up necessary configurations in `appsettings.json` by filling the placeholders values with your own values. (fill `appsettings.development.json` instead of `appsettings.json` if you are using development environment)
5. Run the migrations to create the database schema. You can do this by running the following command in the Package Manager Console:

   ```bash
   Update-Database
   ```

6. Start the backend server by pressing `F5` or clicking on the "Start" button in Visual Studio.

### Frontend Setup

1. Navigate to the `frontend` directory.
2. Install the required packages by running the following command:

   ```bash
   npm install
   ```

3. Start the Angular development server by running the following command:

   ```bash
   ng serve -o
   ```

_Now your setup is ready! Enjoy Exploring the app!_

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
