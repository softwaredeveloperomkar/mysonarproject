public class CSharp

{

    string Version;

    string Technology;

    public void GetDetails()

    {

        Console.WriteLine("version : " + Version);

        Console.WriteLine("Technology : " + Technology);

    }

    public void SetDetails(string version, string technology)

    {

        Version = version; Technology = technology;

    }

}