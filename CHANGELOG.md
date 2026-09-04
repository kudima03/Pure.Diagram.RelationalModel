# Changelog

All notable changes to Pure.Diagram.RelationalModel are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.1.0.0] — 2026-04-19

### Changed
- **`SeriesRelationalModel`** renamed to **`DiagramSeriesRelationalModel`**
  (implementing the renamed `IDiagramSeriesRelationalModel`), matching the
  updated `Pure.Diagram.RelationalModel.Abstractions` dependency (bumped to
  `0.1.0-preview.2.0.0`). This is a breaking change — update references to
  the old type and interface names.

## [0.1.0-preview.0.1.0] — 2026-02-12

### Added
- Initial release of the relational model records for the Pure diagram
  domain, targeting `net7.0`, `net8.0`, `net9.0`, and `net10.0`:
  - **`DiagramRelationalModel`** implementing `IDiagramRelationalModel`,
    with `Id`, `Title`, `Description`, and `TypeId`.
  - **`DiagramTypeRelationalModel`** implementing `IDiagramTypeRelationalModel`,
    with `Id` and `Name`.
  - **`SeriesRelationalModel`** implementing `ISeriesRelationalModel`,
    with `Id`, `DiagramId`, `Label`, and `Source`.
