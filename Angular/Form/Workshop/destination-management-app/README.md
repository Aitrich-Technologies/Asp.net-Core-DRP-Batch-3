# Destination Management — Angular 17 Workshop 2

Standalone components, Reactive Forms, routing.

## Setup

```bash
npm install
```

> Add your own `logo.png` into `src/assets/` (used by the header and footer).

## Run

```bash
npm start
```

Open http://localhost:4200 — it redirects to `/destinations`.

## Routes

- `/destinations` — Destination List (search by Country or Destination Name)
- `/destinations/add` — Add Destination (Reactive Form)
- `/destinations/edit/:id` — Edit Destination (Reactive Form, pre-filled)
- any other path → redirects back to `/destinations`

## Structure

```
src/app/
├── core/
│   ├── header/          Header (Destinations nav link routed)
│   └── footer/           Footer
├── models/
│   └── destination.model.ts
├── services/
│   └── destination.service.ts     In-memory CRUD + simple successMessage string
├── features/
│   ├── destination-list/           View, Search, Delete
│   └── destination-form/           Add + Edit — Reactive Forms
├── app.component.ts                Header + <router-outlet> + Footer
├── app.routes.ts
└── app.config.ts                    provideRouter(routes)
```

## What each requirement demonstrates

| Requirement | Where |
|---|---|
| Header / Footer | `core/header`, `core/footer` |
| Static + param routing | `app.routes.ts` — `/destinations/edit/:id` |
| View all destinations | `destination-list.component.ts` → `destinationService.getAll()` / `search()` |
| Add / Edit / Delete | `destination.service.ts` — `add()`, `update()`, `delete()` |
| Search by Country or Name | `destination.service.ts` → `search(term)` |
| Reactive Form | `destination-form.component.ts` — `FormBuilder`, `FormGroup`, `Validators.required` |
| Form validation | `isInvalid(field)` helper + `<small class="text-danger">` messages |
| Success messages | `destinationService.successMessage` shown as a Bootstrap alert on the list page, auto-hides after 3s |

## Try it

1. Go to `/destinations` — see 3 seeded destinations.
2. Click **Add Destination** → fill the form → submit → redirected to list with a green success banner.
3. Click **Edit** on any card → form pre-fills with existing data → change something → **Update**.
4. Click **Delete** → confirm → success banner shows.
5. Type in the search box → list filters live by Country or Destination Name.
6. Try submitting the Add form empty — required-field messages appear under each blank field.
