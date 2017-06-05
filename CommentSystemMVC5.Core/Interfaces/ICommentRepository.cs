using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommentSystemMVC5.Core
{
    public interface ICommentRepository
    {
        Comment Add(Comment comment);
        void Edit(Comment comment);
        void Remove(int id);
        IEnumerable<Comment> GetComments();
        Comment GetComment(int id);
    }
}
