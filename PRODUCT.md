# Product

<!-- impeccable:product-schema 1 -->

## Platform

web

## Users

- **AP (accounts payable) clerks** at small to mid-size companies who process supplier invoices every day. Their job is to get valid invoices approved quickly and to catch errors (duplicates, wrong totals, unknown suppliers) before an invoice is approved. They work at a desk, in a browser, and handle interruptions constantly.
- **Finance managers** who check the review queue, approve or reject invoices that need a person, and watch totals and trends on the dashboard.
- **Demo visitors** (recruiters, interviewers) who open the public demo to see how the product works.

## Product Purpose

InvoiceIQ automates invoice intake and extraction while enforcing deterministic validation rules before any approval is issued. Users upload invoices; the AI reads and extracts the data; fixed business rules then verify it (line items sum to the subtotal, subtotal + tax = total, dates are valid and the due date is not before the invoice date, the supplier is known, no duplicate is detected). Anything that fails validation is routed to a person for review. Nothing with wrong amounts is ever auto-approved. Every correction is logged. Success means fewer manual keystrokes, no invoice with wrong amounts approved, and a complete audit trail.

## Positioning

Trust, not just extraction. InvoiceIQ treats AI output as a first draft, not the answer, and runs deterministic validation rules over every result before approval is possible. Wrong amounts cannot be auto-approved.

## Operating Context

- Desktop-first browser application; users work on Windows desktops with keyboard navigation expected.
- Invoice volume justifies automation but errors carry real financial and audit consequences.
- Approval decisions require confidence, not just speed; the UI must communicate validation status unambiguously.
- Deployed on MonsterASP (Windows/IIS) — Angular 22 frontend served via ASP.NET Core 10 API.

## Capabilities and Constraints

- Features: upload several invoices at once (PDF or image), live status updates while invoices are processed, the original invoice shown beside the extracted fields during review, a dashboard of totals and statuses, and CSV export.
- Invoice states: Queued → Extracting → Approved (all rules pass) or NeedsReview (any rule fails). A person then moves NeedsReview to Approved or Rejected. Failed is used only when extraction itself fails.
- Validation rules are fixed and deterministic: line-item arithmetic, subtotal + tax = total, date validity, known-supplier lookup, duplicate detection.
- Every correction made by a person is audited.
- No AI chat assistant in the product.
- Paying invoices is out of scope; InvoiceIQ stops at approval.
- No auto-approval of invoices with arithmetic errors — this is a hard constraint, not a setting.

## Brand Commitments

- **Name:** InvoiceIQ
- **Typography:** IBM Plex Sans (body and UI), IBM Plex Mono (numbers, amounts, codes). Both are binding.
- **Aesthetic:** Calm and numbers-first. Flat colours only — no gradients. No decorative illustration.
- **Status communication:** Status is never conveyed by colour alone; always paired with text or icon.
- **Design tokens:** `web/src/styles/_tokens.scss` is the canonical token file.
- **Themes:** Light and dark, following the operating system setting. WCAG 2.1 AA text contrast (minimum 4.5:1) in both themes.

## Evidence on Hand

- Domain model and EF Core migration in repository (Invoice entity, six-state workflow).
- IBM Plex Sans and IBM Plex Mono loaded via `@fontsource` in the Angular project.
- Design token scaffold exists at `web/src/styles/_tokens.scss`.
- No real invoice samples, testimonials, or benchmark data on hand.

## Product Principles

1. **Rules over inference.** AI reads; deterministic rules decide. The two roles are never blurred.
2. **Status must be unambiguous.** Every validation outcome is visible, legible, and keyboard-accessible.
3. **Audit by default.** Every correction and approval is logged without requiring the user to opt in.
4. **Calm density.** The interface holds a lot of data without noise — white space and typographic hierarchy do the work that colour and decoration do elsewhere.
5. **No surprises in production.** Wrong amounts never reach approval. This is a floor, not a target.

## Accessibility & Inclusion

WCAG 2.1 AA required in both light and dark themes. Minimum text contrast 4.5:1. Full keyboard operability. Status communicated by text or icon in addition to colour at all times. Desktop-first; mobile is out of scope.
