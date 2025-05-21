export class Calculator {
  add(a, b) {
    return a + b;
  }

  subtract(a, b) {
    return a - b;
  }

  multiply(a, b) {
    return a * b;
  }

  divide(a, b) {
    if (b === 0) {
      throw new Error('Divide by zero');
    }

    return Math.trunc(a / b);
  }

  noop(a) {
    // Stryker disable next-line ArithmeticOperator
    return a + 0;
  }
}
