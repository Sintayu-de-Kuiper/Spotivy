using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{
    internal class Number(string songTitle, string artist)
    {
        public string Title { get; } = songTitle;
        public string Artist { get; } = artist;

        public void Play()
        {
            Console.WriteLine("Playing: " + Title + " by " + Artist);
        }
    }
}
