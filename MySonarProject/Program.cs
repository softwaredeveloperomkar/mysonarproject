class Program

{

    static void Main(string[] args)

    {

        int myvariable = 0;

        Sonar sonar = new Sonar();

        sonar.Welcom();

        CSharp csharp = new CSharp();

        csharp.SetDetails("4.0", "Asp.Net MVC");

        csharp.GetDetails();

        Console.ReadKey();
    }

}