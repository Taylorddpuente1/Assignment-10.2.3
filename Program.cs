// find a string that starts and ends with specific characaters

using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        Console.WriteLine("Enter the starting character for the string: ");
        char startchar = Console.ReadLine().ToUpper()[0];

    Console.WriteLine("Enter the ending character for the string: ");
        char endchar = Console.ReadLine().ToUpper()[0];

    bool found = false;
        foreach (string city in cities)
        {
            if (city.StartsWith(startchar.ToString()) && city.EndsWith(endchar.ToString()))
            {
                Console.WriteLine("The city starting with {0} and ending with {1} is: {2}", startchar, endchar, city);
                found = true;
                break;
            }
        }

        if (!found)
{
    Console.WriteLine("No city found that starts with {0} and ends with {1}.", startchar, endchar);
}
    }
}