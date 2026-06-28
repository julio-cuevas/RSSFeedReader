# Research: MVP RSS reader

## Decision: Minimal subscription management MVP
The MVP will implement only the subscription add/list experience. It will not fetch or parse RSS/Atom feeds, and it will treat user-entered text as a feed URL without validation.

## Rationale
- Stakeholder goals and app features emphasize a simple proof-of-concept focused on managing subscriptions.
- The TechStack documentation already defines an ASP.NET Core Web API backend with a Blazor WebAssembly frontend, which supports a clean separation of UI and API responsibilities.
- Avoiding feed fetching and URL validation keeps the MVP achievable quickly while preserving the architecture for future enhancements.

## Alternatives considered
- Implement feed fetching now: rejected because the ProjectGoals and AppFeatures documents explicitly defer content loading and parsing for MVP.
- Use persistent storage in MVP: rejected because the MVP scope calls for in-memory session storage only, avoiding database complexity.
- Build a single-page app without a backend API: rejected because the chosen TechStack and future extensibility strongly favor a backend/frontend separation.

## Resolved Clarifications
- Language/Version: ASP.NET Core (C#) backend and Blazor WebAssembly frontend
- Primary Dependencies: ASP.NET Core Web API, Blazor WebAssembly, and in-memory state storage
- Storage: In-memory session storage for subscriptions
- Testing: The project will use .NET test tooling (xUnit or similar) for simple verification once implementation begins
- Target Platform: Cross-platform desktop development on Windows/macOS/Linux via .NET and Blazor
- Project Type: Web application with separate backend and frontend projects
- Performance Goals: Minimal UI responsiveness and immediate subscription list updates; no high-throughput target
- Constraints: No feed fetching/parsing in MVP; no persistence beyond memory; no URL validation; single-user local application
- Scale/Scope: Single-user local MVP focused on subscription management only
