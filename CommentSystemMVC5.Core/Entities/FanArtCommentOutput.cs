using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentSystemMVC5.Core.Entities
{
    public class FanArtCommentOutput : Output
    {
        public int CommentId { get; set; }
        public string NickName { get; set; }
    }
}
