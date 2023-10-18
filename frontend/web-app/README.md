# Car Auction Site

This project is a car auction platform where users can browse, bid on, and purchase cars. It's built using Next.js, and leverages several modern web technologies to provide a seamless user experience.

## Features

- **File-system Based Routing**: Utilizes Next.js' file-system based routing to organize pages and components.
- **State Management**: Employs Zustand for efficient and easy-to-use state management.
- **Real-time Updates**: Implements SignalR client to provide real-time updates when a bid is made, an auction is created, or finished. This ensures users are always viewing the latest auction status.
- **Pagination**: Implements pagination to display car listings in an organized and accessible manner.
- **Toasts**: Integrated toast notifications provide feedback to users about their interactions, especially during bidding processes.
- **Authentication**: Incorporates NextAuth for secure user authentication when interacting with the backend.


## Installation

Follow these steps to set up the project locally:

1. Clone the repository:

    ```bash
        git clone https://github.com/your-username/car-auction-site.git
    ```

2.  Navigate to the project directory:

    ```bash
        cd car-auction-site
    ```

3.  Install the dependencies:

    ```bash
        npm install
    ```

4.  Start the development server:

    ```bash
        npm run dev
    ```

Now open http://localhost:3000 in your browser to see the project running.

## Usage

### Browsing Listings

1. Navigate to the homepage to see a paginated list of all car listings.
2. Use the search bar to filter listings based on criteria such as make, model, year, price and more.
