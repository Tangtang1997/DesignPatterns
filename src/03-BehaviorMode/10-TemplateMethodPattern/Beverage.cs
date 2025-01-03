namespace _10_TemplateMethodPattern;

public abstract class Beverage
{
    // 模板方法
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    protected void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    protected abstract void Brew();

    protected void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    protected abstract void AddCondiments();
}