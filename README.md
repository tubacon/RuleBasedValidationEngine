# Rule-Based Validation Engine

A lightweight and extensible rule-based validation engine built with .NET.

## Purpose
This project aims to provide a clean and modular validation engine where
rules can be defined, evaluated, and extended independently from any UI or API layer.

## Design Principles
- Separation of concerns
- Rule extensibility
- Testability
- Tooling and analyzer friendly

## Solution Structure
src/
  - Core        -> Abstractions and contracts
  - Engine      -> Rule execution logic
  - Analyzers   -> Roslyn analyzers (planned)

tests/ 
-    Unit tests

## Technology
- .NET
- C#
- Roslyn (planned)

## Project Status
- **Day 0**: Initial setup  
  - Solution & project structure
  - `.editorconfig`
  - Initial README

- **Day 1**: Core abstractions  
  - Rule contracts (`IRule<T>`)
  - Validation result model (`RuleResult`)
  - Rule grouping abstractions
