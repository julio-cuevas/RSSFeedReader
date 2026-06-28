# Tasks: MVP RSS reader

**Input**: Design documents from `/specs/001-rss-reader-mvp/`

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Initialize the backend/frontend project structure and basic configuration.

- [ ] T001 Create ASP.NET Core Web API backend scaffold in backend/RSSFeedReader.Api/
- [ ] T002 Create Blazor WebAssembly frontend scaffold in frontend/RSSFeedReader.UI/
- [ ] T003 [P] Add frontend configuration file in frontend/RSSFeedReader.UI/wwwroot/appsettings.json with `ApiBaseUrl` placeholder
- [ ] T004 [P] Add frontend model in frontend/RSSFeedReader.UI/Models/Subscription.cs to represent subscription data

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Build the in-memory subscription storage and API wiring required by all user stories.

- [ ] T005 Create backend model `Subscription` in backend/RSSFeedReader.Api/Models/Subscription.cs
- [ ] T006 Create in-memory subscription store service in backend/RSSFeedReader.Api/Services/SubscriptionStore.cs
- [ ] T007 Configure backend startup in backend/RSSFeedReader.Api/Program.cs to register the subscription store service, enable JSON API routing, and allow CORS for the frontend origin
- [ ] T008 Configure frontend HTTP client in frontend/RSSFeedReader.UI/Program.cs to use `ApiBaseUrl` from wwwroot/appsettings.json

---

## Phase 3: User Story 1 - Add a subscription (Priority: P1)

**Goal**: Let the user add a feed subscription URL and send it to the backend.

**Independent Test**: Submit a URL in the frontend form and verify the server accepts it as a new subscription.

- [ ] T009 [US1] Implement `POST /api/subscriptions` in backend/RSSFeedReader.Api/Controllers/SubscriptionsController.cs storing submissions in the in-memory service
- [ ] T010 [US1] Create frontend subscription input form and add button in frontend/RSSFeedReader.UI/Pages/Subscriptions.razor
- [ ] T011 [US1] Implement frontend submit logic in frontend/RSSFeedReader.UI/Pages/Subscriptions.razor to POST the new subscription and refresh local UI state

---

## Phase 4: User Story 2 - View the subscription list (Priority: P2)

**Goal**: Display the current list of subscriptions loaded from the backend.

**Independent Test**: Load the page and verify that subscriptions returned by the backend are rendered in the list.

- [ ] T012 [US2] Implement `GET /api/subscriptions` in backend/RSSFeedReader.Api/Controllers/SubscriptionsController.cs
- [ ] T013 [US2] Add frontend subscription list rendering in frontend/RSSFeedReader.UI/Pages/Subscriptions.razor
- [ ] T014 [US2] Add frontend page load logic in frontend/RSSFeedReader.UI/Pages/Subscriptions.razor to fetch subscriptions from `/api/subscriptions`

---

## Phase 5: User Story 3 - Empty state clarity (Priority: P3)

**Goal**: Show a clear empty-state message when no subscriptions exist.

**Independent Test**: Open the app with an empty backend list and verify the empty-state UI message appears.

- [ ] T015 [US3] Add empty-state markup in frontend/RSSFeedReader.UI/Pages/Subscriptions.razor
- [ ] T016 [US3] Add frontend logic in frontend/RSSFeedReader.UI/Pages/Subscriptions.razor to display the empty-state message only when the subscription list is empty

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Finalize documentation, update API contract notes, and ensure project configuration supports the implementation.

- [ ] T017 [P] Update `specs/001-rss-reader-mvp/quickstart.md` with final run and validation steps
- [ ] T018 [P] Review and update `specs/001-rss-reader-mvp/contracts/api.md` after implementation details are finalized
- [ ] T019 [P] Update `specs/001-rss-reader-mvp/plan.md` with the selected architecture, project structure, and implementation decisions

---

## Dependencies & Execution Order

- **Phase 1**: Can start immediately and completes the backend/frontend project setup.
- **Phase 2**: Depends on Phase 1 completion and blocks all user stories until the API and service wiring exist.
- **User Story phases**: Depend on Phase 2, with US1 as the MVP first increment.
- **Final polish**: Depends on the core user stories being implemented.

### User Story Dependencies

- **US1**: Depends on the backend subscription store and frontend HTTP client configuration from Phase 2.
- **US2**: Depends on the backend list endpoint and frontend API integration from Phase 2.
- **US3**: Depends on the subscription list behavior from US2 and the frontend page flow.

### Parallel Opportunities

- Phase 1 tasks `T003` and `T004` can run in parallel.
- Phase 2 task `T008` can run in parallel with `T005` and `T006` once the backend scaffold exists.
- Final polish tasks `T017`, `T018`, and `T019` can run in parallel after implementation.

### MVP Scope

- Deliver US1 first as the MVP increment: add subscription URL support with backend persistence in memory.
- Extend to US2 to confirm list rendering and backend retrieval.
- Complete US3 for user-friendly empty-state behavior.
