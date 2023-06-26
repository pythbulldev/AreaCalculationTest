/// <summary>
/// Sample of usage. Demonstrates ability to calculate area without knowing figure type on a compilation stage  
/// </summary>
IEnumerable<decimal> sides = null;
Type type = null;

try
{
    Console.WriteLine("Input sides:");
    sides = Console.ReadLine()?.Split(';').ToList().Select(x => decimal.Parse(x));

    Console.WriteLine("Input type:");
    var stringType = Console.ReadLine();
    var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes());
    types = types.Where(t => t.IsClass)
           .Where(t => t.Name == stringType);
    type = types.First();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

if (type!=null&&sides!=null)
{
    try
    {
        var area = AreaCalculator.AreaCalculation.CalculateArea(type, sides.ToArray());
        Console.WriteLine($"Area is {area}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
else
{
    Console.WriteLine("Unexpected type");
}

Console.ReadKey();