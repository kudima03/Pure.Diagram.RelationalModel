# Pure.Diagram.RelationalModel

Concrete relational model records for the **Pure** ecosystem — immutable implementations of diagram domain entities.

[![.NET build & test](https://github.com/kudima03/Pure.Diagram.RelationalModel/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RelationalModel/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Diagram.RelationalModel/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RelationalModel/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Diagram.RelationalModel)](https://www.nuget.org/packages/Pure.Diagram.RelationalModel)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Diagram.RelationalModel` provides sealed record implementations of the diagram domain contracts defined in `Pure.Diagram.RelationalModel.Abstractions`. Each record is immutable, holds only `IGuid` and `IString` properties, and is fully compatible with Native AOT.

## Records

| Type | Implements | Properties |
|------|-----------|------------|
| `DiagramRelationalModel` | `IDiagramRelationalModel` | `Id`, `Title`, `Description`, `TypeId` |
| `DiagramTypeRelationalModel` | `IDiagramTypeRelationalModel` | `Id`, `Name` |
| `DiagramSeriesRelationalModel` | `IDiagramSeriesRelationalModel` | `Id`, `DiagramId`, `Label`, `Source` |

All properties are constructor-assigned and exposed as read-only `get`-only members.

## Dependencies

- [`Pure.Diagram.RelationalModel.Abstractions`](https://github.com/kudima03/Pure.Diagram.RelationalModel.Abstractions) — relational diagram domain interfaces
