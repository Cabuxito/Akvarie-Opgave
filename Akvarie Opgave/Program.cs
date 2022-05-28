Console.WriteLine("Rumfang Af akvarie i cm3");
double højde = Indtasting("Indtast højde i cm: ");
double længde = Indtasting("Indtast længde i cm: ");
double bredde = Indtasting("Indtast bredde i cm: ");

beregninger beregn = new beregninger();
double rumfang = beregn.Rumfang(højde, længde, bredde);
Console.WriteLine("Rumfang af akvarie er: {0} cm3", beregn.Rumfang(højde,længde,bredde));
Console.WriteLine("Rumfang af akvarie i liter: {0} l", beregn.liter(rumfang));

static double Indtasting(string text)
{
    double værdier;
    while (true)
    {
        Console.Write(text);
        try
        {
            return værdier = Convert.ToDouble(Console.ReadLine()); 
        }
        catch (Exception a)
        {
            Console.WriteLine("Prøv igen.");
        }
    }
}

class beregninger
{
    public double Rumfang (double højde, double længde, double bredde)
    {
        return (højde * længde * bredde);
    }
    public double liter (double rumfang)
    {
        return (rumfang / 1000);
    }
}