import { describe, it, expect } from 'vitest';
import { Calculator } from './calculator.js';

describe('Calculator', () => {
  const calculator = new Calculator();

  it('Add returns sum', () => {
    expect(calculator.add(1, 2)).toBe(3);
  });

  it('Subtract returns remainder', () => {
    expect(calculator.subtract(5, 3)).toBe(2);
  });

  it('Multiply by zero returns zero', () => {
    expect(calculator.multiply(0, 5)).toBe(0);
  });

  it('Multiply returns product', () => {
    expect(calculator.multiply(1, 5)).toBe(5);
  });

  it('Divide by non-zero returns quotient', () => {
    expect(calculator.divide(10, 2)).toBe(5);
  });

  it('Divide by zero throws', () => {
    expect(() => calculator.divide(10, 0)).toThrowError("Divide by zero");
  });

  it('noop returns the original value', () => {
    expect(calculator.noop(4)).toBe(4);
  });
});
