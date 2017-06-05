using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommentSystemMVC5.Core;
using CommentSystemMVC5.Infrastructure.Data;

namespace CommentSystemMVC5.Infrastructure.Repositories
{
    public class CommentRespository : ICommentRepository
    {
        CommentContext context;
        public CommentRespository()
        {
            context = new CommentContext();
        }

        public Comment Add(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return comment;
        }

        public void Edit(Comment comment)
        {
            context.Entry(comment).State = System.Data.Entity.EntityState.Modified;
        }

        public Comment GetComment(int id)
        {
            return context.Comments
                .Where(comment => comment.CommentId == id)
                .FirstOrDefault();
        }

        public IEnumerable<Comment> GetComments()
        {
            return context.Comments
                .ToList();
        }

        public void Remove(int id)
        {
            var comment = context.Comments.Find(id);
            context.Comments.Remove(comment);
            context.SaveChanges();
        }
    }
}
