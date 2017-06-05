using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommentSystemMVC5.Core;
using CommentSystemMVC5.Core.Entities;
using CommentSystemMVC5.Infrastructure;

namespace CommentSystemMVC5.Services
{
    public class CommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public Comment SubmitComment(int entryId, string comment, int parentId, int account_id)
        {
            if (comment == string.Empty)
                throw new Exception("Comment is required.");

            return  _commentRepository.Add(new Comment
            { EntryId = entryId
            , ParentCommentId = parentId
            , account_id = account_id
            , CommentText = comment
            , CreatedDate = DateTime.Now
            });            

        }
    }
}
