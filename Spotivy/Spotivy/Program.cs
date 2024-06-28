using System.Security.Cryptography.X509Certificates;

namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number song = new("OhYeah", "MJ");
            Console.WriteLine(song.Title);
            song.Play();
        }
    }
}
