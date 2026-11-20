# Booking App — Angular 17 Workshop

Workshop 3 – Booking Search: Header/Footer, Static Routing, Booking List with
Search (query params), Booking Details (route params), and Wildcard Routing.

## Setup

```bash
npm install
```

> Add your own `logo.png` into `src/assets/` (referenced by the header and footer).

## Run

```bash
npm start
```

Then open http://localhost:4200

## Routes

- `/` — Booking List (search updates `?search=` query param)
- `/booking-details/:id` — Booking Details for a given booking id
- `/**` — Wildcard → Page Not Found

## What's new in Angular 17 used here

- Standalone components (no NgModules)
- New control flow syntax: `@if`, `@for`, `@else`
- Functional router config via `provideRouter()`
- `inject`-style, signal-friendly patterns (services, ActivatedRoute)
