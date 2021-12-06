using System.Collections.Generic;

namespace gsync2vid
{
    public class GProject
    {
        public int PoemId { get; set; }
        public int AudioId { get; set; }
        public List<GVideoFrame> Frames { get; set; }
        public string VideoBackgroundPath { get; set; }
    }
}
