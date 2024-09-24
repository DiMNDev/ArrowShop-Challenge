// See https://aka.ms/new-console-template for more information

Arrow arrow1 = new(ArrowHead.obsidian, Fletching.gooseFeathers, 70);
Console.WriteLine(arrow1.cost);


class Arrow
{

    public ArrowHead arrowHead;
    public float length;
    public Fletching fletching;

    public float cost;
    public Arrow(ArrowHead arrowHead, Fletching fletching, float length)
    {
        this.arrowHead = arrowHead;
        this.fletching = fletching;
        this.length = length;
        this.cost = CalculatePrice();
    }

    private float CalculatePrice()
    {
        float arrowHeadCost = this.arrowHead switch
        {
            ArrowHead.wood => 3,
            ArrowHead.obsidian => 5,
            ArrowHead.steel => 10
        };
        float fletchingCost = this.fletching switch
        {
            Fletching.gooseFeathers => 3,
            Fletching.turkeyFeathers => 5,
            Fletching.plastic => 10
        };
        float shaftCost = (float)(this.length * 0.05);

        return arrowHeadCost + fletchingCost + shaftCost;
    }

}

enum ArrowHead
{
    steel,
    wood,
    obsidian
}

enum Fletching
{
    plastic,
    turkeyFeathers,
    gooseFeathers
}