# Hahn-Assesment
This project is .Net Core Application with the ClientApp generated with [Angular CLI](https://github.com/angular/angular-cli) version 13.2.2.


## Project Scope
### API
* The API is a mimick of an e-commerce platform, which allows for management of inventory items.
```
* The API was built using Repository design pattern and Clean Architecture in which the solution was split into 3 different projects (API, Business, DataAccess).
* The API serving as the startup project which housed the controller and reference to the Business.
* The Business project served as the core of the Core of the project, housing various services, models and implementations utilized throughout the project.
* The DataAccess project served as the unit that managed data access processes, (Repository and Unit of Work)
```

### ClientApp
* Thougn an unrelated front end application but showcases my skills in building front end applications using Angular and Bootstrap.
* It's an application I'm currently working on for ICAN 
* The application has various modules (auth, info...) and utilizes lazy loading when routing between modules
* There is intent to implement route guards for various access rights using Guards.


## Running the Application
### API
```
* Ensure docker has been set up on your system.
* Open terminal
* Run `cd {directoryOfProject}`
* Run `docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d`
* Check docker desktop to confirm the container is running.
* Return to terminal
* Run `cd /API`
* Run `dotnet run`
```

## ClientApp
### Development server
```
* Ensure current angular-cli version on system is 13
* Open Terminal
* Run `cd {directoryOfProject}/ClientApp`
* Run `npm install`
* Run `ng serve --open` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.
```
