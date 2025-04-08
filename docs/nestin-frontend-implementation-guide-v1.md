# NestIn: Frontend Implementation Guide v1

This document helps frontend developers understand how the NestIn frontend project is organized. It explains the folder structure and lists the main tools and libraries we use in the project.

## Overview

We use **Angular 19** with **standalone components**. The goal is to keep things simple, organized, and easy to scale.

## File Structure

Here’s a basic look at our project structure inside the `src/app` folder:

```txt
└───src
    └───app
        ├───components       → Shared UI components (e.g., buttons, modals)
        ├───directives       → Custom Angular directives
        ├───guards           → Route guards for auth or access control
        ├───layouts          → Layout components (e.g., main layout, auth layout)
        ├───models           → TypeScript interfaces and types
        ├───pages            → Main feature pages (e.g., Home, Login, Property Details)
        ├───pipes            → Custom Angular pipes
        ├───services         → Services for API calls and app logic
        └───validation       → Form validators and validation rules
```

**Root Files**:

- `index.html` – App's main HTML file
- `main.ts` – Entry point for the Angular app
- `style.scss` – Global styles for the app

## Third-Part Libraries

We use a few helpful libraries to improve the UI and development experience:

- **[Bootstrap (v5.3.5)](https://getbootstrap.com/docs/5.3/getting-started/introduction/)** – For basic responsive layout and styling.
- **[Lucide Icons](https://lucide.dev/guide/packages/lucide-angula)** – Icon library with modern and clean icons.
- **[ng-leaflet-universal](https://www.npmjs.com/package/ng-leaflet-universal)** – To show property locations on the map.
- **[JSON Server](https://www.npmjs.com/package/json-server)** – To mock API responses during development.
