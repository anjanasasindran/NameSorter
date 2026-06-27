# NameSorter

## Overview

This project sorts a list of names given in the file unsorted-names-list.txt by:

1. Last name (primary sort key)
2. Given names (secondary sort key)

## Tech Stack

- .NET 8
- C#
- xUnit (unit testing)

## Project Structure

- NameSorter: Core application logic (models + services)
- NameSorter.Tests: Unit tests for sorting logic

## How to Run

dontnet build

### Run tests

dotnet test

## Design Approach

- Separated domain model (`PersonName`) from sorting logic (`NameSorter`) by implementing seperate interfaces following OCP and SRP
- Implemented service-based design for maintainability
- Covered core sorting rules using unit tests

## Testing

Unit tests verify:

- Sorting by last name
- Secondary sorting by given names
