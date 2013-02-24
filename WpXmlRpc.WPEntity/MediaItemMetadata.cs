using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpXmlRpc.WPEntity
{
    public class MediaItemMetadata
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string File { get; set; }
        MediaItemSizes Sizes { get; set; }
    }
}
