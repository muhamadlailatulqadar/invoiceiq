# Product

<!-- impeccable:product-schema 1 -->

## Platform

web

## Users

AP clerks and finance team members at mid-to-large companies who process a high volume of invoices daily. Their job is to get valid invoices approved quickly and to catch errors — duplicates, wrong totals, unknown suppliers — before payment goes out. They work at a desk, in a browser, often across multiple monitors, and handle interruptions constantly.

## Product Purpose

InvoiceIQ automates invoice intake and extraction while enforcing deterministic validation rules before any approval is issued. Users upload invoices; the AI reads and extracts the data; fixed business rules then verify the maths (line items sum correctly, subtotal + tax = total, dates are valid, supplier is known, no duplicate detected). Anything that fails validation is routed to a human for review. Nothing with wrong maths is ever auto-approved. Every correction is logged. Success means fewer manual keystrokes, zero bad payments slipping through, and a complete audit trail.

## Positioning

Trust, not just extraction. Competing tools stop at AI extraction and treat the output as the answer. InvoiceIQ treats AI output as a hypothesis and runs deterministic validation rules over every result before approval is ever possible. Wrong maths cannot be auto-approved. This is a claim no product that skips the rule layer could truthfully make.

## Operating Context

- Desktop-first browser application; users work on Windows desktops with keyboard navigation expected.
- Invoice volume justifies automation but errors carry real financial and audit consequences.
- Approval decisions require confidence, not just speed; the UI must communicate validation status unambiguously.
- Deployed on MonsterASP (Windows/IIS) — Angular 22 frontend served via ASP.NET Core 10 API.

## Capabilities and Constraints

- Invoice states: Queued → Extracting → NeedsReview → Approved / Rejected / Failed.
- Validation rules are fixed and deterministic: line-item arithmetic, subtotal + tax = total, date validity, known-supplier lookup, duplicate detection.
- Every correction made by a human is audited.
- No AI chat assistant in the product.
- No auto-approval of invoices with arithmetic errors — this is a hard constraint, not a setting.

## Brand Commitments

- **Name:** InvoiceIQ
- **Typography:** IBM Plex Sans (body and UI), IBM Plex Mono (numbers, amounts, codes). Both are binding.
- **Aesthetic:** Calm and numbers-first. Flat colours only — no gradients. No decorative illustration.
- **Status communication:** Status is never conveyed by colour alone; always paired with text or icon.
- **Design tokens:** `web/src/styles/_tokens.scss` is the canonical token file.
- **Themes:** Light and dark. WCAG 2.1 AA text contrast (minimum 4.5:1) in both themes.

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
5. **No surprises in production.** Wrong maths never reaches approval. This is a floor, not a target.

## Accessibility & Inclusion

WCAG 2.1 AA required in both light and dark themes. Minimum text contrast 4.5:1. Full keyboard operability. Status communicated by text or icon in addition to colour at all times. Desktop-first; mobile is out of scope.
