using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon1.Models
{
    public class VideoModel
    {
        public VideoModel()
        { }

        public VideoModel(VideoModel video)
        {
            this.Id = video.Id;
            this.Video = video.Video;
        }

        public string Video { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}, Video: {this.Video}";
        }
        public bool Equals(VideoModel video)
        {
            return this.Video == video.Video;
        }
    }
}
