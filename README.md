# Software Requirements Specification
## For <project name>

Version 0.1  
Prepared by J. Kruskie 

Table of Contents
=================
* [Revision History](#revision-history)
* 1 [Introduction](#1-introduction)
  * 1.1 [Document Purpose](#11-document-purpose)
  * 1.2 [Product Scope](#12-product-scope)
  * 1.3 [Definitions, Acronyms and Abbreviations](#13-definitions-acronyms-and-abbreviations)
  * 1.4 [References](#14-references)
  * 1.5 [Document Overview](#15-document-overview)
* 2 [Product Overview](#2-product-overview)
  * 2.1 [Product Perspective](#21-product-perspective)
  * 2.2 [Product Functions](#22-product-functions)
  * 2.3 [Product Constraints](#23-product-constraints)
  * 2.4 [User Characteristics](#24-user-characteristics)
  * 2.5 [Assumptions and Dependencies](#25-assumptions-and-dependencies)
  * 2.6 [Apportioning of Requirements](#26-apportioning-of-requirements)
* 3 [Requirements](#3-requirements)
  * 3.1 [External Interfaces](#31-external-interfaces)
    * 3.1.1 [User Interfaces](#311-user-interfaces)
    * 3.1.2 [Hardware Interfaces](#312-hardware-interfaces)
    * 3.1.3 [Software Interfaces](#313-software-interfaces)
  * 3.2 [Functional](#32-functional)
  * 3.3 [Quality of Service](#33-quality-of-service)
    * 3.3.1 [Performance](#331-performance)
    * 3.3.2 [Security](#332-security)
    * 3.3.3 [Reliability](#333-reliability)
    * 3.3.4 [Availability](#334-availability)
  * 3.4 [Compliance](#34-compliance)
  * 3.5 [Design and Implementation](#35-design-and-implementation)
    * 3.5.1 [Installation](#351-installation)
    * 3.5.2 [Distribution](#352-distribution)
    * 3.5.3 [Maintainability](#353-maintainability)
    * 3.5.4 [Reusability](#354-reusability)
    * 3.5.5 [Portability](#355-portability)
    * 3.5.6 [Cost](#356-cost)
    * 3.5.7 [Deadline](#357-deadline)
    * 3.5.8 [Proof of Concept](#358-proof-of-concept)
* 4 [Verification](#4-verification)
  * 4.1 [Verification Strategies](#41-verification-strategies)
  * 4.2 [Traceability Matrix (Optional for Educational Projects)](#42-traceability-matrix-optional-for-educational-projects)
* 5 [Appendices](#5-appendices)
  * 5.1 [Future Expansion Notes](#51-future-expansion-notes)
  * 5.2 [Developer Setup Notes](#52-developer-setup-notes)
  * 5.3 [API Sample Request](#53-api-sample-request)
  * 5.4 [Contact / Maintainer Info](#54-contact--maintainer-info)


## Revision History
| Name | Date    | Reason For Changes  | Version   |
| ---- | ------- | ------------------- | --------- |
| J. Kruskie | 04/30/2025 | Initial creation | 0.1 |


## 1. Introduction

This document defines the software requirements specification (SRS) for the "Relay" project — an internal platform and API service developed to support a high school computer programming classroom. It outlines the purpose, scope, definitions, references, and structure of the document to provide a comprehensive overview for stakeholders, developers, and future contributors.

### 1.1 Document Purpose

The purpose of this SRS is to formally describe the functional and non-functional requirements of Relay, a centralized API-driven system for classroom data management and student development. This document is intended for:

- Software developers and system architects designing and implementing Relay
- Instructors and administrators integrating the system into classroom operations
- Students interacting with the public API endpoints
- Project reviewers and maintainers evaluating the scope and direction of the platform

This SRS serves as a reference point throughout the software development lifecycle and ensures all stakeholders have a shared understanding of the product.

### 1.2 Product Scope

Relay is a modular, extensible backend platform that replaces the legacy "Wayback Machine" archive system. It introduces a centralized API-first architecture to manage student portfolios, classroom project data, and realistic dummy datasets. Relay functions as the backbone of daily operations and educational workflows in the computer science classroom.

Key goals of the product include:

- Archiving and exposing both historical and current student project data
- Offering a reliable public API for use in student assignments and frontend development
- Hosting robust fake datasets (e.g., student records, math scores, financials) for use in coding lessons
- Enabling future expansion for features like certification tracking and device inventory management

Relay supports RESTful interaction, secure data access, and classroom-aligned data structures, helping educators simulate real-world development environments and support student learning.

### 1.3 Definitions, Acronyms and Abbreviations

| Term | Definition |
|------|------------|
| API | Application Programming Interface |
| AD ID | Active Directory Identifier |
| JWT | JSON Web Token, used for secure authentication |
| CRUD | Create, Read, Update, Delete — basic data manipulation operations |
| REST | Representational State Transfer — an architectural style for networked applications |
| JSON | JavaScript Object Notation — a lightweight data-interchange format |
| UI | User Interface |
| Relay | The name of the internal classroom platform/API described in this SRS |

### 1.4 References

- IEEE SRS Template: https://github.com/BAISD-CC/SRS-Template
- JSON Web Token (JWT) Specification: https://jwt.io/introduction/
- RESTful API Design Guidelines: https://restfulapi.net/
- OpenAPI Specification (Swagger): https://swagger.io/specification/

### 1.5 Document Overview

This SRS is structured to cover the following:

- **Section 1: Introduction** — Overview and foundational information about Relay and this document
- **Section 2: Product Overview** — Describes the system from a user and system perspective
- **Section 3: Requirements** — Detailed software requirements, including interfaces, functions, and constraints
- **Section 4: Verification** — Planned strategies for verifying compliance with the requirements
- **Section 5: Appendices** — Additional supporting information or future expansion notes

This structure follows the IEEE standard format and is intended to guide both the development and review process of the Relay project.

## 2. Product Overview

This section outlines the context, capabilities, limitations, and assumptions surrounding the development and deployment of the Relay system. Relay is positioned as a foundational component of the high school programming classroom's digital infrastructure, serving both instructional and student needs via a centralized API.

### 2.1 Product Perspective

Relay is a replacement and expansion of the previously developed "Wayback Machine" project archive. Unlike its predecessor, Relay is designed as a modular, extensible, and API-driven backend platform. It is intended to serve as the data and service layer for various frontend classroom tools, student assignments, and administrative functions.

Relay is self-contained but may interact with external systems, such as GitHub, Active Directory services, and future classroom tools that consume its public APIs.

Subsystems include:

- **Project Archive**: Core functionality for storing and managing student project metadata.
- **Public API**: Safe, read-only endpoints for use in student code and public displays.
- **Student Directory**: Internal data storage for administrative reference and future certification or device management.
- **Announcements Module**: For posting and retrieving class-wide messages.
- **Future Modules**: Certifications tracking and device inventory management are planned for future releases.

All communication is expected to occur via RESTful JSON endpoints over HTTP(S), with appropriate authentication and role-based access control for admin-only operations.

### 2.2 Product Functions

Relay provides the following high-level features:

- **Project Archive (Wayback Replacement)**
  - Add, update, delete, and list student projects
  - Store metadata: title, description, technologies, visibility, GitHub link, creation date
  - Expose project information via public API endpoints

- **Public API for Students**
  - Expose safe, read-only endpoints for use in coding assignments and frontend demos
  - Provide realistic dummy datasets (e.g., students, math scores, fake financials)
  - Support search and filtering across public data endpoints

- **Student Directory (Admin/Internal Use)**
  - Store student information: name, GitHub username, AD ID, skills, tags
  - Support future expansion for storing certifications and uploaded documents

- **Announcements**
  - Admins can create announcements
  - Endpoints for fetching the latest updates (e.g., for dashboards or widgets)

- **Certifications Module (Planned)**
  - Track certifications per student, with title, issue date, and file attachments

- **Device Inventory (Planned)**
  - Track devices assigned to students (e.g., laptops, IDs, status, condition history)

### 2.3 Product Constraints

- **Interface Constraints**
  - All interactions must occur via RESTful JSON APIs
  - Web-based UI tools that consume the API must be compatible with standard HTTP methods

- **Security Constraints**
  - Admin operations must be protected by JWT or basic authentication
  - Public endpoints must be strictly read-only with filtered/sanitized output

- **Performance Constraints**
  - Public API endpoints must respond quickly to classroom-scale traffic (≤ 100 concurrent users)
  - Admin tasks may have higher latency tolerance, but must remain stable

- **Design Constraints**
  - The system must be modular and extensible to allow addition of new modules (e.g., Certifications)
  - Must be lightweight and deployable in local or cloud environments

- **Compliance**
  - Sensitive student data must be handled in compliance with institutional data privacy policies

### 2.4 User Characteristics

Relay users can be categorized into the following groups:

- **Students**
  - Technical proficiency: Beginner to intermediate
  - Access: Public API (read-only), usage in assignments and personal projects
  - Needs: Reliable data for demos, documentation for endpoints

- **Instructor / Admin**
  - Technical proficiency: Intermediate to advanced
  - Access: Full API access including admin operations (CRUD on projects, announcements, etc.)
  - Needs: Efficient tools for project management, student tracking, and content publishing

- **Future Developers / Maintainers**
  - Technical proficiency: Intermediate to advanced (familiar with APIs and backend architecture)
  - Needs: Clean, documented codebase; modular design for extending the system

### 2.5 Assumptions and Dependencies

- The system will be hosted within a school-controlled environment (local server or managed cloud)
- GitHub will remain the primary platform for hosting student projects
- Students will have network access and permissions to consume public APIs
- Admins will have credentials and secure access to protected endpoints
- Project maintainers will have access to the full source code and deployment environment

### 2.6 Apportioning of Requirements

Some features are expected to be implemented in stages:

| Feature / Function           | Status        | Module             |
|-----------------------------|---------------|--------------------|
| Project Archive             | Core          | Project Archive    |
| Public API                  | Core          | API Layer          |
| Dummy Data Endpoints        | Core          | Public API         |
| Student Directory           | Phase 1       | Admin Module       |
| Announcements               | Phase 1       | Admin Module       |
| Certifications Module       | Future Phase  | Certifications     |
| Device Inventory            | Future Phase  | Inventory Module   |

Functions like certifications and device inventory are scoped for future development and not required in the initial release.

## 3. Requirements

This section defines the functional and non-functional software requirements for Relay, including interfaces, system behavior, quality attributes, and design considerations. Requirements are specified to support the successful implementation, verification, and maintainability of the system.

### 3.1 External Interfaces

#### 3.1.1 User Interfaces

While Relay is primarily an API service, a supporting React-based frontend may be developed for administrative use and public viewing. Key UI-related requirements include:

- The frontend shall be built using React and consume Relay's API endpoints.
- Public-facing components shall display student projects, dummy datasets, and announcements.
- Admin views (protected) shall allow:
  - Adding/editing/deleting projects
  - Posting announcements
  - Viewing the student directory
- UI design should follow accessibility best practices (WCAG 2.1) and be responsive for classroom use across different devices.

#### 3.1.2 Hardware Interfaces

Relay does not interface directly with hardware. However, the planned **Device Inventory** module will include metadata storage for issued devices. In that context:

- The system shall allow admin users to record hardware attributes (e.g., serial number, model, condition).
- There are no expectations for physical integration or control of devices.

#### 3.1.3 Software Interfaces

- **ASP.NET Core Web API**
  - Relay shall be implemented using ASP.NET Core for the backend API.
  - Endpoints shall follow RESTful conventions (`/api/resource/{id}`).
  - The system shall return JSON-formatted responses (UTF-8 encoded).
  - Middleware shall enforce security, logging, and error handling.

- **React Frontend (Optional)**
  - The frontend shall consume the Relay API via HTTP(S).
  - Axios or Fetch API may be used for data fetching.
  - Authentication tokens (if used) must be securely stored (e.g., HttpOnly cookies or secure local storage).

- **Authentication System**
  - Admin endpoints must use JWT (JSON Web Token) or basic auth.
  - Role-based access control must be enforced on the backend.

- **Third-party Integration**
  - GitHub URLs may be linked or scraped for student project metadata.
  - Future integrations (e.g., Active Directory) must remain modular and non-blocking.

### 3.2 Functional

Relay shall offer the following functional capabilities:

#### 3.2.1 Project Archive
- Admins can:
  - Create, update, delete, and retrieve student project records
- Projects include:
  - Title, description, tech stack, GitHub URL, visibility status, date created
- Public API shall only expose visible projects
- Endpoint: `GET /api/public/projects`

#### 3.2.2 Public API
- Provide read-only endpoints for:
  - Student projects
  - Dummy data sets (e.g., students, scores, transactions)
- Endpoints shall support:
  - Pagination, filtering, and search via query parameters
- Example endpoints:
  - `/api/public/dummy/students`
  - `/api/public/dummy/scores`

#### 3.2.3 Student Directory (Internal)
- Admins can:
  - Add/view student records with fields: name, GitHub username, AD ID, skills, tags
- Endpoint examples:
  - `GET /api/admin/students`
  - `POST /api/admin/students`

#### 3.2.4 Announcements
- Admins can:
  - Post announcements with title, body, and timestamp
- Public endpoint shall return latest posts
- Endpoint: `GET /api/public/announcements`

#### 3.2.5 Certifications (Planned)
- Track certifications per student
- Store: title, issue date, associated student, and optional PDF/image
- Admin-only endpoints for file upload and management

#### 3.2.6 Device Inventory (Planned)
- Track student devices: laptop ID, model, checkout/return dates, condition
- Endpoint support for:
  - Creating and updating device assignment history
  - Viewing per-student device records

### 3.3 Quality of Service

#### 3.3.1 Performance
- API endpoints must respond within:
  - ≤ 200ms for public GET requests
  - ≤ 500ms for admin operations
- Backend must use pagination on large datasets

#### 3.3.2 Security
- Use JWT for securing admin-only routes
- Sanitize inputs to prevent injection attacks (e.g., SQL, XSS)
- Ensure student data is never exposed via public endpoints
- Use HTTPS for all API communications

#### 3.3.3 Reliability
- Log errors server-side and provide consistent error responses
- Implement basic health checks (e.g., `/api/health`)
- Provide backup/export functionality for critical datasets

#### 3.3.4 Availability
- >99% uptime during school hours (Mon–Fri, 8am–4pm)
- In event of system failure, API should return meaningful error codes (e.g., `503 Service Unavailable`)

### 3.4 Compliance

- Comply with school district data policies (e.g., FERPA if applicable)
- Audit logs shall record admin activity (e.g., changes to project records)
- OpenAPI (Swagger) documentation must be auto-generated from backend code

### 3.5 Design and Implementation

#### 3.5.1 Installation
- Relay must be deployable using:
  - Docker Compose
  - .NET CLI (`dotnet publish`, `dotnet run`)
- Environment variables shall manage configuration (e.g., DB connection, JWT secret)

#### 3.5.2 Distribution
- Hosted on a school-controlled virtual machine or cloud platform (e.g., Azure, AWS)
- Static React frontend (if used) may be served from the same domain or subdomain

#### 3.5.3 Maintainability
- Backend codebase shall follow clean architecture principles
- Use controllers, services, and models in ASP.NET with separation of concerns
- Include README and inline code documentation for future contributors

#### 3.5.4 Reusability
- Dummy data generators and public API endpoints shall be designed for reuse in:
  - Other classroom APIs
  - Workshops and demos
  - Code samples and tests

#### 3.5.5 Portability
- Relay shall run on Windows, macOS, and Linux (via .NET Core cross-platform support)
- React frontend must build and run with Node.js on any OS

#### 3.5.6 Cost
- Relay is an internal educational project; hosting and development costs should be minimal or covered by school infrastructure
- Optional cloud deployments must use free-tier or school-licensed services when possible

#### 3.5.7 Deadline
- Initial release (Project Archive + Public API) targeted for: **[insert target date]**
- Certifications and Device Inventory modules are planned for future iterations

#### 3.5.8 Proof of Concept
- A working proof of concept shall demonstrate:
  - Public API delivering dummy and project data
  - Admin-only endpoint protection
  - Frontend integration consuming project or dummy dataset endpoints

## 4. Verification

Verification activities ensure that Relay meets all specified requirements and functions correctly in its intended classroom environment. Each requirement outlined in Section 3 must be testable through one or more of the following methods:

### 4.1 Verification Strategies

- **Unit Testing**
  - Backend controllers, services, and data models (e.g., ASP.NET unit tests using xUnit or NUnit)
  - Dummy data generator functions and validation logic

- **Integration Testing**
  - End-to-end testing of API endpoints and database interactions
  - Secure access to admin-only endpoints via JWT or basic auth
  - Authentication and authorization middleware coverage

- **Frontend Testing (if applicable)**
  - Component-level testing of React UI using tools such as Jest and React Testing Library
  - Manual and automated testing of API consumption and rendering logic

- **API Testing**
  - Validate endpoint responses for correctness, format (JSON), and performance
  - Use tools like Postman, Swagger UI, or automated test scripts

- **Usability and Manual Testing**
  - Instructor and student walkthroughs of API documentation and sample use cases
  - Confirm data accuracy and clarity of documentation

- **Performance and Load Testing**
  - Simulate multiple users making concurrent API calls using tools like Apache JMeter or k6
  - Measure response times for public vs. authenticated endpoints

### 4.2 Traceability Matrix (Optional for Educational Projects)

A basic requirements traceability matrix can be used to map requirements to their respective test cases to ensure full coverage. This may be maintained in a separate test plan document or as a spreadsheet artifact.

| Requirement ID | Requirement Summary              | Verification Method      |
|----------------|----------------------------------|--------------------------|
| 3.2.1           | Admin CRUD for projects          | Unit + API testing       |
| 3.2.2           | Public dummy data endpoints      | API + integration tests  |
| 3.2.4           | Announcement system              | UI + API tests           |
| 3.3.2           | JWT auth for admin               | Security + unit tests    |

## 5. Appendices

### 5.1 Future Expansion Notes

The following features are scoped for future implementation and not part of the initial system delivery:

- **Certifications Module**
  - File upload and association with student profiles
  - PDF/image support and date-based filtering

- **Device Inventory**
  - Hardware tracking and checkout/return logging
  - Historical views of device assignments

These features should be implemented as self-contained modules that integrate with the core Relay API using consistent design patterns.

### 5.2 Developer Setup Notes

- Backend:
  - Install .NET SDK (version TBD)
  - Run `dotnet restore` and `dotnet run` from the API directory
  - Use `.env` or appsettings.json for environment config

- Frontend (optional):
  - Node.js and npm required
  - Run `npm install` and `npm start` from the React frontend directory

- Local development may use SQLite or local SQL Server instance. Production environments should use a managed SQL backend.

### 5.3 API Sample Request

Example: Fetching all public projects  
`GET /api/public/projects`

```json
[
  {
    "id": 101,
    "title": "Tic Tac Toe",
    "description": "Simple game using React",
    "techStack": ["React", "CSS"],
    "githubUrl": "https://github.com/user/tictactoe",
    "visibility": "public",
    "createdAt": "2025-02-10"
  }
]

