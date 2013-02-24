using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpXmlRpc.WPEntity
{
    public class Post
    {
        public string PostID { get; set; }
        public string PostTitle { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime PostDateGmt { get; set; }
        public DateTime PostModified { get; set; }
        public DateTime PostModifiedGmt { get; set; }
        public string PostStatus { get; set; }
        public string PostType { get; set; }
        public string PostFormat { get; set; }
        public string PostName { get; set; }
        public string PostAuthor { get; set; }
        public string PostPassWord { get; set; }
        public string PostExcerpt { get; set; }
        public string PostContent { get; set; }
        public string PostParaent { get; set; }
        public string PostMimeType { get; set; }
        public string Link { get; set; }
        public string Guid { get; set; }
        public int MenuOrder { get; set; }
        public string CommentStatus { get; set; }
        public string PingStatus { get; set; }
        public bool Sticky { get; set; }

    }
}
