# InvestSystems.org

Social network & tools for non-professional investors.

### Architecture

![architecture](https://cloud.githubusercontent.com/assets/8171434/18032948/3d4e003a-6d17-11e6-9d21-31ea6baeddfc.png)


### Microservices

* Companies - list of stock market companies    
* Email - email templates and service to send it
* Gamification - points, badges and challanges for users
* Gateway - GraphQL and WebSockets powered gateway for clients
* Identity - OAuth/OpenID powered authorization, login/password authentication, list of users and roles
* Portfolio - companies (stock shares) owned by the given user
* RuleOne - Rule #1 analysis for companies
* Watchlist - list of potential companies to buy


### Folder structure
    .
    ├── client
    │   ├── hybrid                  # Ionic 2 based app for (iOS, Android, Windows)
    │   └── web                     # Angular 2 and Material Design based web app
    ├── docs                        # Documentation
    ├── server
    │   ├── Companies               # Companies microservice
    │   ├── Email                   # Email microservice
    │   ├── Gamification            # Gamification microservice
    │   ├── Gateway                 # Gateway microservice
    │   ├── Identity                # Identity microservice
    │   ├── InvestSystemsOrg        # Service Fabric project
    │   ├── Portfolio               # Portfolio microservice
    │   ├── RuleOne                 # Rule #1 microservice
    │   ├── Shared                  # Shared code
    │   ├── Watchlist               # Watchlist microservice
    │   └── InvestSystemsOrg.sln    # Solution with all microservices

### Technologies

* Angular 2
* Ionic 2
* Material Design for Angular 2
* ASP.NET Core
* GraphQL
* Swashbuckle
* Entity Framework Core
* xUnit.net
* Service Fabric

### FAQ

> **Q: Why Material Design for web app?**
>
> **A:** Because...