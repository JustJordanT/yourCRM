# 👨‍💼 yourCRM 👩‍💼
CRMs increase your profitability by streamlining administrative processes in your sales, marketing, and service divisions, and letting you focus on building and maintaining the customer relationships that matter.

This project will utilize some of the current best practises as of today from a `Clean-Architecture` standpoint as well as utilizing `microservices` as well.

Some of the technologies that will be used in is stack will be as followed, you can think of this as a current roadmap. 

# :hearts: Technical stacks
- [ ] **[`.NET Core 6`](https://dotnet.microsoft.com/download)** - .NET Framework and .NET Core, including ASP.NET and ASP.NET Core
- [ ] **[`MVC Versioning API`](https://github.com/microsoft/aspnet-api-versioning)** - Set of libraries which add service API versioning to ASP.NET Web API, OData with ASP.NET Web API, and ASP.NET Core
- [ ] **[`YARP`](https://github.com/microsoft/reverse-proxy)** - A toolkit for developing high-performance HTTP reverse proxy applications
- [ ] **[`MediatR`](https://github.com/jbogard/MediatR)** - Simple, unambitious mediator implementation in .NET
- [ ] **[`EF Core`](https://github.com/dotnet/efcore)** - Modern object-database mapper for .NET. It supports LINQ queries, change tracking, updates, and schema migrations
- [ ] **[`FluentValidation`](https://github.com/FluentValidation/FluentValidation)** - Popular .NET validation library for building strongly-typed validation rules
- [ ] **[`Swagger & Swagger UI`](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)** - Swagger tools for documenting API's built on ASP.NET Core
- [ ] **[`serilog`](https://github.com/serilog/serilog)** - Simple .NET logging with fully-structured events
- [ ] **[`Dapr dotnet-sdk`](https://github.com/dapr/dotnet-sdk)** - Dapr SDK for .NET
- [ ] **[`RestEase`](https://github.com/canton7/RestEase)** - Easy-to-use typesafe REST API client library for .NET Standard 1.1 and .NET Framework 4.5 and higher, which is simple and customisable
- [ ] **[`Polly`](https://github.com/App-vNext/Polly)** - Polly is a .NET resilience and transient-fault-handling library that allows developers to express policies such as Retry, Circuit Breaker, Timeout, Bulkhead Isolation, and Fallback in a fluent and thread-safe manner
- [ ] **[`Scrutor`](https://github.com/khellang/Scrutor)** - Assembly scanning and decoration extensions for Microsoft.Extensions.DependencyInjection
- [ ] **[`opentelemetry-dotnet`](https://github.com/open-telemetry/opentelemetry-dotnet)** - The OpenTelemetry .NET Client
- [ ] **[`Blazor - WASM`](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)** - Client web apps with C#
- [ ] **[`BFF`](https://github.com/DuendeSoftware/BFF)** - Framework for ASP.NET Core to secure SPAs using the Backend-for-Frontend (BFF) pattern

# 🧰 Resources
- ✔️[`C#`](https://docs.microsoft.com/en-us/dotnet/csharp/)
- ✔️[`.NET`](https://github.com/dotnet/runtime)
  - ✔️[`.NET Docker Images`](https://github.com/dotnet/dotnet-docker)
- ✔️[`Dapr`](https://dapr.io/)
- ✔️[`Tye`](https://github.com/dotnet/tye)
- ✔️[`Docker`](https://www.docker.com/)
- ✔️[`JS`](https://www.javascript.com/)
- ✔️[`React`](https://reactjs.org/)
- ✔️`Messaging Systems`: 
  - ✔️[`RabbitMQ`](https://www.rabbitmq.com/)
  - ✔️[`Redis-PubSub`](https://redis.io/topics/pubsub)
- ✔️`DataBase`
  - ✔️[`MSSql`](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
  - ✔️[`Redis`](https://redis.io/)

# 🎇 Minimal DDD, CQRS, and Clean Architecture

1. `Domain-driven Design` (a.k.a DDD) demonstrates it can help the business tidy and organized in many years. But it is hard to approach and use, we need to make it easier to use in real projects when we get started.

2. `Command and Query Responsibility Segregation` (a.k.a CQRS) helps to separate components into command and query parts, but again it's really hard and might bloat when we get starting some of the project. We need something more lightweight, just like https://github.com/gautema/CQRSlite, but we might not need Event Sourcing in almost all projects.

3. `Clean Architecture` helps the project structure easier to refactor and evolve in medium and big projects. Especially in the Microservice world, we always want to do and try with a lot of time in the project lifetime. The thing is boilerplate code in this kind of project to make components lose coupling.

=> When we jump in and set up the project for the Microservice approach. We want to apply all the best practices from the community, and some kind of patterns and architecture above sometimes makes us feel power off when start implements the first line of code which actually solves the business requirements. So the solution is we need something minimal and enough to get starting, and then when our business gets grows by the time, then we go back to add more. That's what's the practical way to go!

`clean-architecture-dotnet` is a collection of basic building blocks and project structure to help we get starting the project with less code boilerplate and effortless. We focus on the Microservice approach of how can we organize code, the project with the monorepo approach, and you can use it for modular monolith projects as well.
![image](https://user-images.githubusercontent.com/38886930/126588300-459b31ca-cd22-4a5d-b480-6f49a436e5aa.png)
Reference to https://github.com/Sairyss/domain-driven-hexagon

# 🗺️ Git Branching 

Being able to use Git, enables us to utililze best practise for release management. This also allows us to be `Decentralized but centralized` meaning that user/contributor can change and update the source of truth with out impacting each others work. Bob can change and make updates to his current work, while Alice is able to work on other additional features with out impacting each others work.

![image](https://user-images.githubusercontent.com/38886930/126631098-393cd0e9-e3f1-40f9-b029-5e7cb7bc3413.png)



# 📰 Referances
https://github.com/thangchung/clean-architecture-dotnet
https://nvie.com/posts/a-successful-git-branching-model/
