# 🔄 C# Type Conversions

A quick reference guide for type conversion methods in C#.

## 📋 Index
- [A. Implicit Conversions](#a-implicit-conversions)
- [B. Explicit Conversions (Cast)](#b-explicit-conversions-cast)
- [C. Parse / TryParse](#c-parse--tryparse)
- [D. Convert.To_X](#d-convertto_x)
- [Best Practices](#best-practices)

## A. Implicit Conversions:

- **No syntax required** 🔍
- **Type safe conversions** (No data will be lost)
- **Examples:**
  - Conversions from smaller to larger integral types (int → double)
  - Conversions from derived classes to base classes

## B. Explicit Conversions (Cast):

- **Syntax required** - using parentheses: `(type)value`
- **NOT type safe** conversions (data loss might occur) ⚠️
- **Examples:** 
  - Conversions from larger to smaller integral types (double → int)
  - Conversions from base classes to derived classes

## C. Parse / TryParse:

- **Parse:** Converts strings to other data types
  - Throws exception if conversion fails (string including number(s) will fail as well)
- **TryParse:** Safer alternative 
  - Returns boolean indicating success/failure ✓/✗
  - Doesn't throw exceptions

## D. Convert.To_X:

- Methods from the `Convert` class
- Converts between different base types
- Handles null values consistently
- Available for all primitive types (ToInt32, ToDouble, ToString, etc.)

## Best Practices 🥇

- Use implicit conversions when possible (safest)
- Use TryParse for user input
- Use explicit casting when you understand the potential data loss
- Use Convert methods when dealing with potential null values