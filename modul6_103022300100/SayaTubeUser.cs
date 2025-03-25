using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300100
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;
        Random rand = new Random();

        public SayaTubeUser(string username)
        {
            this.id = rand.Next(10000, 99999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var v in uploadedVideos)
            {
                total += v.GetPlaycount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + username);
            int i = 1;
            foreach(var v in uploadedVideos)
            {
                Console.WriteLine("Video " + i + " Judul: " + v.GetTitle());
                i++;
            }
        }
    }
}
