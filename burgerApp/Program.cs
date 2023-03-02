using burgerApp;

internal class Program
{
    private static void Main(string[] args)
    {

        HangBurger hangBurger = new HangBurger("cli", "beef", "white", 10);
        //double money = hangBurger.itemprice();

        hangBurger.add1("hl", 20);

        Console.WriteLine($"total! is {hangBurger.itemprice()}");
    }
}