using Overkill.Reader;
using Overkill.Transformer;
using Overkill.Validator;

var reader = new ConsoleReader();
var equation = reader.Read();
var equationTransformer = new SimpleEquationTransformer();
var variables = equationTransformer.Transform(equation);
var hiddenTransformer = new HiddenEquationNumberTransformer(new NumberDigitRangeHiddenValidator());
var hiddenNumber = hiddenTransformer.Transform(variables);
var hiddenRangeMatch = new NumberDigitRangeMatchValidator();
if (!hiddenRangeMatch.Validate((variables[hiddenNumber.Item1], hiddenNumber.Item2)))
{
    Console.WriteLine("-1");
}
else
{
    variables[hiddenNumber.Item1] = hiddenNumber.Item2.ToString();
    Console.WriteLine($"{variables[0]} + {variables[1]} = {variables[2]}");
}
