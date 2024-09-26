// See https://aka.ms/new-console-template for more information

Arrow ExpensiveArrow = new() { ArrowHead = ArrowHeadTypes.steel, Length = 100, Fletching = FletchingTypes.plastic };

Console.WriteLine($"This Expensive Arrow has an {ExpensiveArrow.ArrowHead} arrow head, {ExpensiveArrow.Fletching} fletching, and is {ExpensiveArrow.Length}cm long.");
Console.WriteLine($"This Expensive Arrow costs {ExpensiveArrow.Cost}");

internal class Arrow
{
    private float cost;

    public ArrowHeadTypes ArrowHead { get; init; } = ArrowHeadTypes.wood;
    public float Length { get; init; } = 60;
    public FletchingTypes Fletching { get; init; } = FletchingTypes.gooseFeathers;
    public float Cost
    {
        get => cost = CalculatePrice();
        private set => CalculatePrice();
    }

    private float CalculatePrice()
    {
        float arrowHeadCost = ArrowHead switch
        {
            ArrowHeadTypes.wood => 3,
            ArrowHeadTypes.obsidian => 5,
            ArrowHeadTypes.steel => 10
        };
        float fletchingCost = Fletching switch
        {
            FletchingTypes.gooseFeathers => 3,
            FletchingTypes.turkeyFeathers => 5,
            FletchingTypes.plastic => 10
        };
        float shaftCost = (float)(Length * 0.05);

        return arrowHeadCost + fletchingCost + shaftCost;
    }

}

enum ArrowHeadTypes
{
    steel,
    wood,
    obsidian
}

enum FletchingTypes
{
    plastic,
    turkeyFeathers,
    gooseFeathers
}