using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300100
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        Random rand = new Random();

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title.Length < 200);
            Contract.Requires(title != null);
            Contract.Requires(playCount > 0);


            this.id = rand.Next(10000,99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int counter)
        {
            Contract.Requires(counter < 25000000);
            try
            {
                checked
                {
                    this.playCount += counter;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi Oveflow");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }

        public int GetPlaycount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }
    }
}
