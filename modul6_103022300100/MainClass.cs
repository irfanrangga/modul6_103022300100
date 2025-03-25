using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300100
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SayaTubeUser user = new SayaTubeUser("irfanrangga");
            SayaTubeVideo film1 = new SayaTubeVideo("Harry Potter");
            SayaTubeVideo film2 = new SayaTubeVideo("Avengers: Endgame");
            SayaTubeVideo film3 = new SayaTubeVideo("Interstellar");
            SayaTubeVideo film4 = new SayaTubeVideo("Seven");
            SayaTubeVideo film5 = new SayaTubeVideo("Shutter Island");
            SayaTubeVideo film6 = new SayaTubeVideo("Inception");
            SayaTubeVideo film7 = new SayaTubeVideo("Good Will Hunting");
            SayaTubeVideo film8 = new SayaTubeVideo("The Substance");
            SayaTubeVideo film9 = new SayaTubeVideo("Inglourious Basterds");
            SayaTubeVideo film10 = new SayaTubeVideo("Oppenheimer");

            film1.IncreasePlayCount(120);
            film2.IncreasePlayCount(185);
            film3.IncreasePlayCount(182);
            film4.IncreasePlayCount(124);
            film5.IncreasePlayCount(150);

            film1.PrintVideoDetails();

            // Menambahkan Film ke list
            user.AddVideo(film1);
            user.AddVideo(film2);
            user.AddVideo(film3);
            user.AddVideo(film4);
            user.AddVideo(film5);
            user.AddVideo(film6);
            user.AddVideo(film7);
            user.AddVideo(film8);
            user.AddVideo(film9);
            user.AddVideo(film10);

            // Mencetak film dalam list
            user.PrintAllVideoPlaycount();
        }
    }
}
