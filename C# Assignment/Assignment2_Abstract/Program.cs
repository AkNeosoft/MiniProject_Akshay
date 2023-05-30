public abstract class Clothing
{
    public abstract void Sales();

    public abstract void Materials();

    public abstract void CommonWear();
}

public class TrendSetting : Clothing
{
    public override void Sales()
    {
        Console.WriteLine("Sales ");
        
    }

    public override void Materials()
    {
        Console.WriteLine("Materials");
        
    }

    public override void CommonWear()
    {
        Console.WriteLine("Common wear ");
        
    }
}

public class ClimateControl : Clothing
{
    public override void Sales()
    {
        Console.WriteLine("Sales by region for ClimateControl clothing:");
    }

    public override void Materials()
    {
        Console.WriteLine("Materials");
        
    }

    public override void CommonWear()
    {
        Console.WriteLine("Common Wear");
       
    }
}

public class Sports : Clothing
{
    public override void Sales()
    {
        Console.WriteLine("Sales");
        
    }

    public override void Materials()
    {
        Console.WriteLine("Materials");
        
    }

    public override void CommonWear()
    {
        Console.WriteLine("Common wear");
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        TrendSetting trendSetting = new TrendSetting();
        trendSetting.Sales();
        trendSetting.Materials();
        trendSetting.CommonWear();

        ClimateControl climateControl = new ClimateControl();
        climateControl.Sales();
        climateControl.Materials();
        climateControl.CommonWear();

        Sports sports = new Sports();
        sports.Sales();
        sports.Materials();
        sports.CommonWear();
    }
}