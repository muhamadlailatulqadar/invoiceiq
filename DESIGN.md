---
name: InvoiceIQ
description: AI-assisted invoice processing with deterministic validation — calm, typographic, and numbers-first.
colors:
  bg: "#fff8ee"
  surface: "#ffffff"
  surface-soft: "#ffedd5"
  border: "#ead7c0"
  text: "#2b0a17"
  text-muted: "#6b5560"
  brand: "#470b24"
  brand-soft: "#b5bedd"
  positive: "#1e7a46"
  negative: "#b42318"
  warning: "#b45309"
typography:
  headline:
    fontFamily: "'IBM Plex Sans', system-ui, sans-serif"
    fontSize: "1.75rem"
    fontWeight: 600
    lineHeight: 1.3
  body:
    fontFamily: "'IBM Plex Sans', system-ui, sans-serif"
    fontSize: "15px"
    fontWeight: 400
    lineHeight: 1.5
  label:
    fontFamily: "'IBM Plex Sans', system-ui, sans-serif"
    fontSize: "0.875rem"
    fontWeight: 400
    lineHeight: 1.5
  mono:
    fontFamily: "'IBM Plex Mono', ui-monospace, monospace"
    fontSize: "15px"
    fontWeight: 400
    lineHeight: 1.5
    fontFeature: "tnum"
rounded:
  sm: "6px"
  pill: "999px"
spacing:
  "1": "4px"
  "2": "8px"
  "3": "12px"
  "4": "16px"
  "6": "24px"
  "8": "32px"
components:
  button-primary:
    backgroundColor: "{colors.brand}"
    textColor: "{colors.surface}"
    rounded: "{rounded.sm}"
    padding: "8px 16px"
  status-pill:
    backgroundColor: "{colors.surface}"
    textColor: "{colors.text-muted}"
    rounded: "{rounded.pill}"
    padding: "4px 12px"
---

# Design System: InvoiceIQ

## Overview

**Creative North Star: "The Examined Ledger"**

InvoiceIQ is built on the conviction that every figure deserves scrutiny before it moves. The design system embodies that conviction: unhurried, typographic, and precise. Where most finance tools reach for cold blue authority, this system uses warm parchment and deep plum — the palette of ink on paper, of an auditor working methodically through a stack. Nothing is decorative. Every colour, weight, and spacing decision earns its place by clarifying a number or a decision.

The interface operates at high density without noise. IBM Plex Sans supplies legibility at the 15px base; IBM Plex Mono makes monetary values and codes tabular, scannable, and unambiguous at a glance. The two faces work as a pair: the sans for context, the mono for fact. Status communicates through text labels and shape, never through colour alone — a rule that holds in both light and dark.

Both themes share the same spatial grammar, the same type scale, and the same flat-tonal depth model. In dark, `--brand` becomes Clouded Periwinkle (`#b5bedd`) and `--brand-soft` becomes `#5a2a40`.

**Key Characteristics:**
- Warm, parchment-grounded palette (not cold blue or sterile white)
- Ink Plum brand accent used sparingly — titles, primary actions, active navigation only
- IBM Plex Sans + IBM Plex Mono as a committed typographic pair
- Flat-tonal depth: background tiers and 1px borders, no shadows on static elements
- Status communicated by text + icon shape, never colour alone
- Single global radius (6px) with pill only for status badges

## Colors

The palette is two-voiced: warm neutrals carry the content, and a single deep-plum accent marks authority. Signal colours (green, amber, red) are reserved exclusively for validation outcomes.

### Primary
- **Ink Plum** (`#470b24`): The brand anchor. Rich, literary, authoritative without coldness. Applied to page titles, primary buttons, and active navigation items. Used on less than 10% of any screen. Dark-theme variant: Clouded Periwinkle (`#b5bedd`).

### Neutral
- **Warm Parchment** (`#fff8ee`): Page background. Warm off-white — the equivalent of invoice paper. Never used as a component surface.
- **White** (`#ffffff`): Card and form surface. Sits one tier above the background, separated by a 1px border and the implicit warmth contrast.
- **Peach Tint** (`#ffedd5`): Soft surface tier. Used for highlighted rows, hover states on list items, and subtle container fills.
- **Warm Tan** (`#ead7c0`): Border and divider colour. Separates surfaces without competing with text.
- **Near-Black Plum** (`#2b0a17`): Primary text. Dark enough for 4.5:1 contrast on `--bg`; a plum undertone keeps it warm.
- **Muted Mauve** (`#6b5560`): Secondary text, metadata, and placeholder copy. Readable at 4.5:1 on `--surface`.
- **Clouded Periwinkle** (`#b5bedd`): The light-theme `--brand-soft` — a soft periwinkle used for subtle tinted fills. In dark theme, `--brand` takes this value (`#b5bedd`) and `--brand-soft` becomes `#5a2a40` (Deep Plum Mist).

### Signal (Validation Outcomes Only)
- **Forest Green** (`#1e7a46`): Positive / approved. Dark-theme variant: `#4ade80`.
- **Deep Red** (`#b42318`): Negative / rejected / error. Dark-theme variant: `#f87171`.
- **Amber** (`#b45309`): Warning / needs review. Dark-theme variant: `#fbbf24`.

### Dark Theme
Values applied by `@media (prefers-color-scheme: dark)` in `web/src/styles/_tokens.scss`. Same token names, inverted palette.

| Token | Value | Light-theme counterpart |
|---|---|---|
| `--bg` | `#1c0610` | Warm Parchment `#fff8ee` |
| `--surface` | `#2a0b19` | White `#ffffff` |
| `--surface-soft` | `#3a1225` | Peach Tint `#ffedd5` |
| `--border` | `#4a1a30` | Warm Tan `#ead7c0` |
| `--text` | `#ffedd5` | Near-Black Plum `#2b0a17` |
| `--text-muted` | `#b5bedd` | Muted Mauve `#6b5560` |
| `--brand` | `#b5bedd` | Ink Plum `#470b24` |
| `--brand-soft` | `#5a2a40` | Clouded Periwinkle `#b5bedd` |
| `--positive` | `#4ade80` | Forest Green `#1e7a46` |
| `--negative` | `#f87171` | Deep Red `#b42318` |
| `--warning` | `#fbbf24` | Amber `#b45309` |

### Named Rules
**The One Voice Rule.** Ink Plum (`--brand`) is the only accent. It never signals validation status — that job belongs to Forest Green, Deep Red, and Amber exclusively. If a colour is doing two jobs, one of them is wrong.

**The Never-Colour-Alone Rule.** No validation state is communicated by colour alone. Every status badge pairs a colour dot with a text label. This holds in both themes and in print.

## Typography

**Body Font:** IBM Plex Sans (with system-ui, sans-serif fallback)
**Number / Code Font:** IBM Plex Mono (with ui-monospace, monospace fallback)

**Character:** A pairing of quiet authority and mechanical precision. The sans is legible and neutral enough to disappear into an invoice list; the mono makes every figure a fixed-width fact. The mono appears wherever a value must be compared — amounts, invoice IDs, dates used as identifiers.

### Hierarchy
- **Headline** (600, 1.75rem, 1.3): Page titles and major section headers. Set in Ink Plum, not the default text colour. Used once per screen.
- **Body** (400, 15px, 1.5): All prose, labels, and UI copy. The default; everything that is not a number or a header.
- **Label** (400, 0.875rem, 1.5): Form labels, table column headers, chip text, and status badge copy. Uppercase tracking applied sparingly and only on column headers.
- **Mono** (400, 15px, 1.5, tabular-nums): Invoice amounts, totals, IDs, dates used as sort keys, and all numeric data in tables. The `font-variant-numeric: tabular-nums` rule applies at all times; alignment in columns depends on it.

### Named Rules
**The Mono-For-Facts Rule.** Any value that will be compared, summed, or scanned in a column uses IBM Plex Mono with `tabular-nums`. This is non-negotiable: a proportional-width amount in an amount column is a typographic error.

## Layout

The layout is a single-column, centered container: `max-width: 960px`, `margin: 0 auto`. Desktop-first with no mobile breakpoint currently defined — the product targets AP clerks on desktop hardware.

Internal padding follows the 4px spacing scale: `32px` vertical / `16px` horizontal on the outer container (`--space-8` / `--space-4`). Component gaps use `8px` (`--space-2`) for tight clusters (badge icon + label) and `16px` (`--space-4`) for field groups and row separators.

Tables — the primary data surface — are expected to use full container width within the 960px bound, with column headers left-aligned, amount columns right-aligned, and 12px (`--space-3`) cell padding.

## Elevation & Depth

InvoiceIQ uses a flat-tonal depth model. No shadows appear on cards, table rows, or buttons. Depth is expressed entirely through the three background tiers and 1px border lines:

1. **Page floor** (`--bg: Warm Parchment`): The base layer.
2. **Card / surface** (`--surface: White`): Elevated one tier by the warmth contrast and a `1px --border` outline.
3. **Soft fill** (`--surface-soft: Peach Tint`): For hover states, highlighted rows, and tinted container fills — above surface without introducing a new border.

A single `--shadow-float` token is reserved for the one class of truly floating layers: dropdowns, dialogs, and toasts. It has not been built yet; when the first floating layer is implemented, define and add it to `_tokens.scss` following the flat shadow philosophy (diffuse, low-opacity, single-direction).

### Named Rules
**The Floor-and-Border Rule.** Depth comes from background colour and border lines, not from shadows. A card is white on parchment with a tan border. That is sufficient and intentional. Shadows on cards are a regression, not an enhancement.

## Shapes

The form language is consistent and minimal: a single `--radius: 6px` governs all interactive containers — buttons, inputs, cards, and table wrappers. The 6px radius is small enough to read as controlled and precise rather than soft or playful.

The only exception is status badges and chips: `border-radius: 999px` (pill). The pill shape visually separates badge content from the grid of tabular data it annotates — it is a signal shape, not a container shape.

No clipping, no asymmetric radii, no rounded-xl anywhere.

## Components

### Buttons
- **Shape:** Gently curved corners (6px radius)
- **Primary:** Ink Plum background (`--brand`), white text (`--surface`), 8px / 16px padding, IBM Plex Sans 600 0.875rem
- **Hover:** A `--brand-hover` token will be added to `_tokens.scss` when the first button is built.
- **Focus:** Focus-visible shows a 2px `--brand` outline with 2px offset.
- **Active:** Slight opacity (0.85) acknowledges the press without animation.
- **Secondary / Ghost (not yet implemented):** Will use `--surface` background, `--brand` text, `1px --border` stroke.

### Status Badges
- **Shape:** Full pill (999px radius), inline-flex with 8px gap
- **Background / Border:** White (`--surface`) fill, Warm Tan (`--border`) 1px stroke
- **Text:** Muted Mauve (`--text-muted`), 0.875rem
- **State dot:** 8px circle `::before` pseudo-element. Colour: Forest Green for `--up`, Deep Red for `--down`, Amber for `--warning`, Muted Mauve for neutral/loading. The dot is never the sole signal — the text label always accompanies it.

### Inputs / Fields (synthesised from tokens, not yet built)
- **Style:** White (`--surface`) background, Warm Tan (`--border`) 1px border, 6px radius, 8px / 12px padding
- **Focus:** Border shifts to Ink Plum (`--brand`); a matching 2px outline at −1px offset reinforces focus without layout shift.
- **Placeholder:** Muted Mauve (`--text-muted`)
- **Error state:** Border shifts to Deep Red (`--negative`); label shows an inline error message in Deep Red.
- **Number inputs:** Font switches to IBM Plex Mono + tabular-nums automatically via the `.num` utility or explicit `font-family` on the input.

### Tables / Data Rows (synthesised, the primary display surface)
- **Container:** White (`--surface`) background, Warm Tan (`--border`) 1px outer border, 6px radius
- **Row hover:** Background shifts to Peach Tint (`--surface-soft`) — no border change, no shadow.
- **Column headers:** Label-weight (400, 0.875rem), uppercase tracking (`letter-spacing: 0.05em`), Muted Mauve text
- **Amount columns:** Right-aligned, IBM Plex Mono + tabular-nums
- **Dividers:** 1px `--border` row separators; no vertical column lines.

## Do's and Don'ts

### Do:
- **Do** use IBM Plex Mono with `font-variant-numeric: tabular-nums` for every monetary value, invoice ID, and date used as a sort key.
- **Do** pair every status colour with a text label or labelled icon — colour alone never carries meaning.
- **Do** use Ink Plum (`--brand`) only on primary actions, page titles, and active navigation — keep it rare so it retains authority.
- **Do** express depth through the `bg → surface → surface-soft` tier progression and 1px `--border` lines.
- **Do** apply WCAG 2.1 AA contrast (4.5:1 minimum) in both light and dark themes before shipping any new colour assignment.

### Don't:
- **Don't** use gradients, drop-shadows, or blurs on cards, table rows, buttons, or static containers.
- **Don't** use `--brand` to signal a validation status — Ink Plum is brand authority, not an outcome indicator.
- **Don't** introduce a new colour outside the token file. If a semantic need arises (e.g., a new validation state), add a token to `_tokens.scss` with both light and dark values.
- **Don't** let a numeric column go without `tabular-nums` — misaligned amounts in an invoice table are a trust failure.
