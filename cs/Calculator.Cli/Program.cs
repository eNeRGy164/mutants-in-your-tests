using CommandLine;
using Spectre.Console;

namespace CalculatorDemo.Cli;

public class Program
{
    static int Main(string[] args) => Parser.Default.ParseArguments<Options>(args).MapResult(RunOptions, errs => 1);

    private static int RunOptions(Options opts)
    {
        var calc = new Calculator();

        if (opts.Add is not null && opts.Add.Any())
        {
            var nums = new List<int>(opts.Add);
            AnsiConsole.WriteLine($"Result: {calc.Add(nums[0], nums[1])}");
        }
        else if (opts.Subtract is not null && opts.Subtract.Any())
        {
            var nums = new List<int>(opts.Subtract);
            AnsiConsole.WriteLine($"Result: {calc.Subtract(nums[0], nums[1])}");
        }
        else if (opts.Multiply is not null && opts.Multiply.Any())
        {
            var nums = new List<int>(opts.Multiply);
            AnsiConsole.WriteLine($"Result: {calc.Multiply(nums[0], nums[1])}");
        }
        else if (opts.Divide is not null && opts.Divide.Any())
        {
            var nums = new List<int>(opts.Divide);
            try {
                AnsiConsole.WriteLine($"Result: {calc.Divide(nums[0], nums[1])}");
            }
            catch (Exception ex)
            {
                AnsiConsole.WriteException(ex);
            }
        }
        else
        {
            AnsiConsole.WriteLine("Specify a valid option. Use --help for usage.");
        }

        AnsiConsole.WriteLine();

        return 0;
    }


    internal class Options
    {
        [Option('a', "add", HelpText = "Add two numbers.", Min = 2, Max = 2)]
        public IEnumerable<int>? Add { get; set; }

        [Option('s', "subtract", HelpText = "Subtract two numbers.", Min = 2, Max = 2)]
        public IEnumerable<int>? Subtract { get; set; }

        [Option('m', "multiply", HelpText = "Multiply two numbers.", Min = 2, Max = 2)]
        public IEnumerable<int>? Multiply { get; set; }

        [Option('d', "divide", HelpText = "Divide two numbers.", Min = 2, Max = 2)]
        public IEnumerable<int>? Divide { get; set; }
    }
}
