using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace WpXmlRpc.WPEntity
{
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class MediaItemSizes
    {
        public MediaItemSize Thumbnail { get; set; }
        public MediaItemSize Medium { get; set; }
        public MediaItemSize Large { get; set; }
    }
}
