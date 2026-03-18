
# Topics

- Books: https://drive.google.com/drive/folders/1-K5Tf2YWbrms2kuPxbvRL4onJItFGBwn
- Submit:  PPTx, Code (zip file), Guide / Manual (install, libraries, command), Dockerfile (packages the service together with all required dependencies so that the service can run independently inside a container)
- Deadline: week 8

## Technical Requirements

### Microservices

* Services must be independently deployable
* Each service should have its own data (or mock database)

### gRPC

* Define at least one `.proto` file
* Implement:

  * At least one **Unary RPC**
  * At least one **Streaming RPC** (any type)

### Docker

* Each service must have its own **Dockerfile**
* Use **docker-compose** to run the entire system
* Services must communicate through Docker network

---

### Optional (Bonus)

* API Gateway
* Logging & Monitoring
* Authentication
* Message Queue integration

---

---

## C#
- CS01. Messaging (C1. Introducing Microservices , C4. First Microservice, C5. Microservice Messaging)
- CS02. Decentralizing Data (C1. Introducing Microservices , C4. First Microservice, C6. Decentralizing Data)
- CS03. Containerization (C1. Introducing Microservices , C4. First Microservice, C9. Containerization)

## Java 
- J01. API Design and Modeling (C1. Fundamentals of RESTful APIs, C2. Micronaut, C4. API Design and Modeling)
- J02. API Portfolio and Framework (C1. Fundamentals of RESTful APIs, C2. Micronaut, C5. API Portfolio and Framework)
- J03. API Platform and Data Handler (C1. Fundamentals of RESTful APIs, C2. Micronaut, C6. API Platform and Data Handler)

## GOlang
- GO01. Serialization (Chapter 1: Introduction to Microservices , Chapter 2: Scaffolding a Go Microservice, Chapter 4: Serialization)
- GO02. Synchronous (Chapter 1: Introduction to Microservices, Chapter 2: Scaffolding a Go Microservice, Chapter 5: Synchronous Communication)
- GO03. Asynchronous (Chapter 1: Introduction to Microservices, Chapter 2: Scaffolding a Go Microservice, Chapter 6: Asynchronous Communication)
  
## Python
- Py01. Python FastAPI Microservices - https://www.geeksforgeeks.org/python/microservice-in-python-using-fastapi/
- Py02. Python PyMS Microservices - https://python-microservices.github.io/home/
- Py03. Python ... - https://medium.com/@bittusinghtech/building-a-simple-microservices-architecture-with-python-a-step-by-step-guide-c41da2cd4631

## Nodejs
- No01. NestJS microservices (brokers, gRPC, Load balancing, Fault tolerance, ...)
- No02. Fastify (gRPC, Service discovery, Load balancing, Fault tolerance)
- No03. Moleculer (gRPC, Service discovery, Load balancing, Fault tolerance)
