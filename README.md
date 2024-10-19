# docker-kubernetes-practica

**Practice with Docker and Kubernetes**

This project demonstrates the use of **Docker** and **Kubernetes** to create, deploy, and manage a **.NET** application connected to a **MongoDB** database. It leverages container technology to solve compatibility issues across multiple platforms, optimize resource usage, and streamline deployment.

## Docker Section
Three images were created: two for the **.NET API** and one for **MongoDB**.

### Key Criteria:
- Definition and creation of Docker images.
- Execution of commands inside a container.
- Data persistence for the MongoDB database using volumes.
- Publishing images to a container registry.
- Creating new versions of an image.

### Tests
Testing details can be found in this document (in Spanish): [Docker and Kubernetes Tests](https://docs.google.com/document/d/1_exWR6R3zWzeC5EHMod3fcy7lWRHAQGxqoL8DDBqT8s/edit?usp=sharing)

## Kubernetes Section
The deployment was carried out using **Kubernetes**, with YAML files defining the **pods**, services, persistent volumes, and secrets.

## How to Run:

### Using Docker Compose:
1. Build the Docker images:
   ```bash
   docker-compose build
   ```
2. Start the services:
   ```bash
   docker-compose up
   ```

### Using Kubernetes:
1. Apply the Kubernetes manifests:
   ```bash
   kubectl apply -f k8s/
   ```

2. Verify that the pods, services, persistent volumes, and secrets are correctly configured.

## Tags:
**Docker**, **Docker Compose**, **Kubernetes**, **.NET**, **MongoDB**, **Volumes**, **Secrets**

