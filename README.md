# Car Auction Site

## Overview
This project constitutes a Car Auction Site developed using .NET 8, utilizing a microservices architecture. It consists of an Auction service and a Search service, with an associated class library, Contracts, to facilitate data transfer between services using RabbitMQ. The Auction service interacts with a PostgreSQL database through Entity Framework, while the Search service uses MongoDB.

## Table of Contents
- [Prerequisites](#prerequisites)
- [Installation](#installation)
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

## Installation
To set up the project locally, follow the steps below:
1. Clone the repository to your local machine.
2. Navigate to the project directory.
3. Run `docker-compose up` to start PostgreSQL, MongoDB, and RabbitMQ services.
4. Open the solution in your preferred IDE or text editor and run the projects.

## Services

### Auction Service
The Auction service manages CRUD operations for auctions, leveraging AutoMapper for object-object mapping, MassTransit for publishing messages to RabbitMQ, and Entity Framework for interaction with PostgreSQL.

### Search Service
The Search service allows users to search for items, applying various query parameters to filter and sort search results. It utilizes MongoDB as the database for storing items.

## API Endpoints

### AuctionController
- **GET `/api/auctions`:** Retrieve a list of all auctions; can filter by date.
- **GET `/api/auctions/{id}`:** Retrieve a specific auction by its ID.
- **POST `/api/auctions`:** Create a new auction.
- **PUT `/api/auctions/{id}`:** Update a specific auction by its ID.
- **DELETE `/api/auctions/{id}`:** Delete a specific auction by its ID.

### SearchController
- **GET `/api/search`:** Search for items based on several query parameters, including `SearchTerm`, `OrderBy`, `FilterBy`, `Seller`, `Winner`, `PageNumber`, and `PageSize`.

## Usage
To interact with the services, you can use the API endpoints listed above. The Auction service provides endpoints for performing CRUD operations on auctions, while the Search service provides an endpoint to search for items based on various parameters.

