**Clean-Architect-Demo**
**Introduction**
Welcome to the Clean-Architect-Demo repository! This project is a demonstration of Clean Architecture principles applied to a Movie Ticket buying system. It is structured to provide developers with an initial setup that can be used as a reference or a starting point for implementing Clean Architecture in their projects.

**Architecture Overview**
The Clean Architecture is designed to maintain separation of concerns throughout the system. In this demonstration, we model the process of purchasing movie tickets and break it down into the following layers:

**1)Domain Layer**: Contains the core business logic which is independent of other layers. It includes entities such as MoviID, Name, and Cost.

**2)Application Layer:** Acts as a mediator between the presentation layer and domain, containing application-specific logic like MoviewService and interface and repository regarding it.

**3)Infrastructure Layer:** Consists of implementations for external concerns such as databases, file systems, or web services. In our case, the data is hardcoded in **MovieReposioty** in **InfratructureProject**. 
**You can connect with your database using connecion string and work on it using DataContext in this layer**

**4)Presentation Layer:** The user interface of the application where users interact with the system to purchase tickets. It includes controllers and views.

Each layer only depends on the layer immediately below it, thus following the Dependency Rule.


Diagram in this repository represents the Clean Architecture model used in this project.

**Project Structure**
The project follows the directory structure aligned with the separation of layers:

/src/Domain - Entities and domain logic
/src/Application - Application services, DTOs, and interfaces
/src/Infrastructure - Project Repository and These (Database context, migrations, and external services) can be added
/src/Presentation - Controllers and startup classes

Getting Started
To get started with the Clean-Architect-Demo, clone the repository and navigate to the root directory:

bash
Copy code
git clone https://github.com/mustafashahzadd/Clean-Architect-Demo.git
cd Clean-Architect-Demo
Prerequisites
.NET Core 3.1 or later
An IDE like Visual Studio, VSCode, or Rider
Running the Application
Execute the following command to run the application:

bash
Copy code
dotnet run --project src/Presentation/Presentation.csproj
Contribution
Contributions are welcome! If you'd like to improve the MovieTicket buying model or suggest changes to the architecture, please open an issue or submit a pull request.

License
This project is licensed under the MIT License - see the LICENSE.md file for details.
