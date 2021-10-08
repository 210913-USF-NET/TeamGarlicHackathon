using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DL
{
    public class DBRepo : IRepo
    {
        private HackDBContext _context;
        public DBRepo(HackDBContext context)
        {
            _context = context;
        }

        public ModelVideo AddVideo(ModelVideo video)
        {
            ModelVideo vidAdd = new ModelVideo()
            {
                Vid = video.Vid
            };
            vidAdd = _context.Add(vidAdd).Entity;
            _context.SaveChanges();
            _context.ChangeTracker.Clear();

            return new ModelVideo()
            {
                Id = vidAdd.Id,
                Vid = vidAdd.Vid,
            };
        }

        public List<ModelVideo> GetVideos()
        {
            return _context.Vids.Select(
                video => new ModelVideo()
                {
                    Id = video.Id,
                    Vid = video.Vid
                }
            ).ToList();

        }


        //List<string> url = _context.Select(s => new ModelVideo()
        //{

        //}
        //    ).ToList();

        //var random = new Random();
        ////var list = new List<string>{ "one","two","three","four"};

        //int index = random.Next(GetVideos().Count);
        //Console.WriteLine(url[index]);


    }
}
