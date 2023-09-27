# Car Auction Site

## Overview
This is a Car Auction Site leveraging .NET 8 and microservices architecture. It consists of Auction, Search, Identity, and Gateway services, each serving distinct purposes within the application. The services interact using RabbitMQ and a shared class library, Contracts. The Auction and Identity services interface with a PostgreSQL database, while the Search service utilizes MongoDB. The Identity service offers Single Sign-On (SSO) capabilities via IdentityServer, implementing OpenID Connect and OAuth 2.0. Lastly, the Gateway service, employing YARP, routes requests to the corresponding service acting as a reverse proxy.




## Table of Contents
- [Prerequisites](#prerequisites)
- [Docker Integration](#Docker-Integration)
- [Running With Docker](#Running-Project-with-Docker-Compose)
- [Services](#services)
  - [Auction Service](#auction-service)
  - [Search Service](#search-service)
- [API Endpoints](#api-endpoints)
  - [AuctionController](#auctioncontroller)
  - [SearchController](#searchcontroller)
- [Usage](#usage)


## Prerequisites
- **.NET 8.0:** The project is developed using .NET 8.0, so you need to have it installed to run the project.
- **Docker:** Docker is used to run PostgreSQL, MongoDB, and RabbitMQ. Install Docker to manage these services using Docker Compose.
- **IDE/Text Editor:** An Integrated Development Environment (IDE) or a text editor for writing and managing your code, such as Visual Studio or Visual Studio Code.

## Docker Integration

Each service including Auction, Search, Identity, and Gateway has been Dockerized. This facilitates the running of each service in an isolated environment containing its specific dependencies. Dockerization of services provides several advantages including:

- **Portability:** Enables the services to run on any machine with Docker installed, mitigating system-specific configurations.
- **Consistency:** Guarantees a consistent environment across development, testing, and production.
- **Isolation:** Each service is run in its own container, avoiding interference with other services.
- **Scalability:** Facilitates scaling of services by creating multiple container instances.

### Docker Compose
Docker Compose is used for defining and running multi-container Docker applications. It is used to run all services along with the dependencies, PostgreSQL, MongoDB, and RabbitMQ, in a coherent manner, connecting all components.

### Exposed Ports
The services are exposed to the following ports:
- **Auction Service:** Accessible externally on port `7001`.
- **Search Service:** Accessible externally on port `7002`.
- **Identity Service:** Accessible externally on port `5000`.
- **Gateway Service:** Accessible externally on port `6001`.
- **PostgreSQL Database:** Accessible externally on port `5432`.
- **MongoDB Database:** Accessible externally on port `27017`.
- **RabbitMQ AMQP:** Accessible externally on port `5672`.
- **RabbitMQ Management Plugin:** Accessible externally on port `15672`.

By default, the services are accessible via HTTP on the above-mentioned ports. The ports can be changed in the Docker Compose configuration if different ports are desired.


## Running Project with Docker Compose

To set up and run the entire project with Docker Compose, follow the steps below:

- Clone the repository:
  ```shell
    git clone https://github.com/idanHur/Car-Auction-Site.git
  ```
- Navigate to the project directory:
  ```shell
    cd Car-Auction-Site
  ```
- Build and run Docker services
  ```shell
    docker-compose build
    docker-compose up
  ```
- Run services in the background
  ```shell
    docker-compose up -d
  ```
- To stop the services
  ```shell
    docker-compose down
  ```

## Services

### Auction Service
The Auction service manages CRUD operations for auctions, leveraging AutoMapper for object-object mapping, MassTransit for publishing messages to RabbitMQ, and Entity Framework for interaction with PostgreSQL.

### Search Service
The Search service allows users to search for items, applying various query parameters to filter and sort search results. It utilizes MongoDB as the database for storing items.

### Gateway Service
The Gateway service acts as a reverse proxy for routing requests to the appropriate backend service. It is configured using YARP (Yet Another Reverse Proxy) to define routes and clusters for the Auction and Search services, providing a unified entry point and addressing model for the client to interact with. It allows separate handling for read and write requests to the Auction service, applying an Authorization Policy to write requests. The Gateway service also simplifies the interaction model and consolidates the API endpoint structure for the client, reducing the need for the client to manage multiple service addresses.

### Identity Service
The Identity service is responsible for the management of user identities and provides features like Single Sign-On (SSO) using IdentityServer. It implements the OpenID Connect and OAuth 2.0 protocols to facilitate secure authentication and authorization processes. It uses PostgreSQL as its data store to maintain user-related information.

## API Endpoints

### AuctionController
- **GET `/auctions`:** Retrieve a list of all auctions; can filter by date. No authorization required.
- **GET `/auctions/{id}`:** Retrieve a specific auction by its ID. No authorization required.
- **POST `/auctions`:** Create a new auction. Requires authorization (Seller).
- **PUT `/auctions/{id}`:** Update a specific auction by its ID. Requires authorization (Seller, must match the auction's seller).
- **DELETE `/auctions/{id}`:** Delete a specific auction by its ID. Requires authorization (Seller, must match the auction's seller).

### SearchController
- **GET `/search`:** Search for items based on several query parameters, including `SearchTerm`, `OrderBy`, `FilterBy`, `Seller`, `Winner`, `PageNumber`, and `PageSize`.


## Usage
To interact with the services, you can use the API endpoints listed above. The Auction service provides endpoints for performing CRUD operations on auctions, while the Search service provides an endpoint to search for items based on various parameters.

