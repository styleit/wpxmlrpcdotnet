using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpXmlRpc.WPEntity
{
    public class MediaItem
    {
        public string AttachmentID { get; set; }
        public DateTime DateCreatedGmt { get; set; }
        public int Parement { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public MediaItemMetadata MetaData { get; set; }
        public PostThumbnailImageMeta ImageMeta { get; set; }
        public string Thumbnail { get; set; }
    }
}
