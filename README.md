# Paw Pilot
Simple API for managing recurring pet-related tasks

## Overview 🐕

Have you ever forgotten your dog's vaccination, only to realise you might have trouble travelling? Has your pooch ever scratched you with those untrimmed nails?
Unfortunately, that's happened to me more than I'd like to admit.

This project implements a basic recurring task management system. The project is containerized using Docker for easy testing.
The project is written in .NET8, using PostgreSQL for the database and Liquibase for migrations.

## Functionality ✨

The initial functionality is outlined in the user story map available [here](https://docs.google.com/spreadsheets/d/17jlI9QuypcZ2ltTPOKIwSaNhZJFI_7jqroYKI-_4VHk/edit#gid=1767904539). To sum up, the initial version will allow you to:
- create a pet;
- create a new task type (such as 'trim nails' or 'give tick vaccine');
- create a new task (such as 'trim nails for Virzis' or 'give tick medicine to Vasara');
- mark a task as 'done'. Once the task is marked as 'done', its due date is renewed based on the frequency period of the task type. It's possible to mark the task as 'done' with the current timestamp or enter a date in the past;
- it's possible to review all outstanding tasks for a given pet, and all the times each task was done in the past ('show me all of Vasara's vaccinations');
- a reminder for the task is set in Google Calendar and/or sent via email. A reminder might need to be sent a couple of days in advance;
- some tasks (like vaccination) require the dog to be dewormed a week in advance. If such a task is created, a 'deworm' task is created automatically.

## How to Run 🏃

1. Ensure you have Docker Desktop installed on your machine.
2. Build and run the Docker containers:

    ```bash
    docker-compose up
    ```

   The API will be accessible at [http://localhost:8080/swagger](http://localhost:8080/swagger) (http) and at [https://localhost:8081/swagger](https://localhost:8081/swagger) (https).

3. To stop the containers, use:

    ```bash
    docker-compose down
    ```
   Make sure to stop the containers before making changes to the configuration or when you're done using the API.

## Documentation & manual testing 🌻
The application can be tested using Visual Studio's HTTP files. <-- created on-the-go
[DB schema (draft)](https://docs.google.com/spreadsheets/d/1NS6_zQ8W5PrYO1So2FQCf8j_JhPC1q3mglkyJwMsaeM/edit#gid=0)

