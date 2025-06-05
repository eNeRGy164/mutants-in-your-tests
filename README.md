# There Are Mutants Living in Your Unit Tests

Welcome! 👋 

If you're here, you probably attended my session **"There Are Mutants Living in Your Unit Tests"** at a meetup or conference. This repository contains all the demo materials and code examples used during the presentation.

## About This Repository

This repository demonstrates the concepts of **mutation testing** - a testing technique that evaluates the quality of your test suite by introducing small changes (mutations) into your code and checking if your tests can detect them. If your tests fail to catch these "mutants," it indicates gaps in your test coverage.

The demos progress from basic unit testing concepts through increasingly sophisticated mutation testing scenarios, showing how to identify and fix weak tests that provide false confidence in code quality.

## Prerequisites

To run through the demos yourself, you'll need:

### Required Software
- **Visual Studio Code** with the [DemoTime extension](https://marketplace.visualstudio.com/items?itemName=eliostruyf.vscode-demo-time)
- **.NET SDK** (9.0 or later) for C# demonstrations
- **Node.js** (18.0 or later) for JavaScript demonstrations

### .NET Global Tools
Install these global tools for the C# demos:
```bash
dotnet tool install --global dotnet-stryker
dotnet tool install --global dotnet-reportgenerator-globaltool
```

### Node.js Dependencies
For the JavaScript demos, dependencies are already configured in `package.json`. Run:
```bash
cd js
npm install
```

## The Four Demos

This repository contains four progressive demonstrations of mutation testing concepts:

### Demo 1: Simple Application
**File:** `.demo/demo-01.json`  
**Focus:** Basic calculator implementation and traditional testing

- Introduces a simple Calculator class with basic arithmetic operations
- Shows how to run the calculator via CLI
- Demonstrates traditional unit testing with xUnit
- Generates code coverage reports
- **Key Learning:** Traditional coverage metrics can be misleading

### Demo 2: Mutation Testing  
**File:** `.demo/demo-02.json`  
**Focus:** Introduction to mutation testing with Stryker.NET

- Runs Stryker.NET mutation testing on the calculator
- Reveals how seemingly good tests fail to catch mutants
- Shows the process of fixing weak tests to improve mutation scores
- **Key Learning:** High code coverage ≠ good test quality

### Demo 3: Equivalent Mutants
**File:** `.demo/demo-03.json`  
**Focus:** Handling equivalent mutants and Stryker configuration

- Introduces the concept of equivalent mutants using a "no-operation" method
- Demonstrates how some mutations don't change program behavior
- Shows how to configure Stryker to handle equivalent mutants
- **Key Learning:** Not all surviving mutants indicate poor tests

### Demo 4: Regular Expressions
**File:** `.demo/demo-04.json`  
**Focus:** Mutation testing with JavaScript and complex patterns

- Switches to JavaScript environment using Vitest and Stryker
- Demonstrates mutation testing on regular expression patterns
- Shows how regex mutations can reveal test weaknesses
- **Key Learning:** Mutation testing works across languages and complex logic

## Running the Demos

### Using DemoTime (Recommended)
1. Open this repository in Visual Studio Code
2. Install the DemoTime extension if not already installed
3. Open the Command Palette (`Ctrl+Shift+P` / `Cmd+Shift+P`)
4. Run "DemoTime: Start Demo" and select one of the demo files:
   - `demo-01.json` - Simple Application
   - `demo-02.json` - Mutation Testing  
   - `demo-03.json` - Equivalent Mutants
   - `demo-04.json` - Regular Expressions

### Manual Execution
If you prefer to run commands manually:

#### C# Demos (1-3)
```bash
cd cs
dotnet build
dotnet test
dotnet stryker
```

#### JavaScript Demo (4)
```bash
cd js
npm test
npx stryker run
```

## Project Structure

```
├── .demo/                  # DemoTime configurations
│   ├── demo-01.json       # Simple Application demo
│   ├── demo-02.json       # Mutation Testing demo  
│   ├── demo-03.json       # Equivalent Mutants demo
│   ├── demo-04.json       # Regular Expressions demo
│   ├── patches/           # Code patches for demos
│   └── snapshots/         # Code snapshots for demos
├── cs/                    # C# project
│   ├── Calculator/        # Calculator library
│   ├── Calculator.Cli/    # Command-line interface
│   ├── Calculator.Specs/  # Unit tests
│   └── stryker-config.yaml # Stryker.NET configuration
└── js/                    # JavaScript project
    ├── src/               # Source code and tests
    └── stryker.config.json # Stryker configuration
```

## Key Concepts Demonstrated

- **Mutation Testing**: Automatically modifying code to test your tests
- **Mutation Score**: Percentage of mutants killed by your test suite
- **Equivalent Mutants**: Mutations that don't change program behavior
- **Weak Tests**: Tests that pass despite code mutations
- **Test Quality**: Moving beyond coverage to effectiveness

## Resources

- [Stryker.NET Documentation](https://stryker-mutator.io/docs/stryker-net/introduction/)
- [Stryker Mutator](https://stryker-mutator.io/) (JavaScript/TypeScript)
- [DemoTime Extension](https://marketplace.visualstudio.com/items?itemName=eliostruyf.vscode-demo-time)

## License

MIT License - Feel free to use this material for your own presentations and learning!

---

*Happy mutation testing! 🧬🧪*