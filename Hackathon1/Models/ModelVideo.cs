using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class ModelVideo
    {
        public ModelVideo()
        { }

        public ModelVideo(ModelVideo video)
        {
            this.Id = video.Id;
            this.Vid = video.Vid;
        }

        public string Vid { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}, Video: {this.Vid}";
        }
        public bool Equals(ModelVideo video)
        {
            return this.Vid == video.Vid;
        }

        //test
    }
}
