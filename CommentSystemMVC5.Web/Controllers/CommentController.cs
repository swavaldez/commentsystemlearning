using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommentSystemMVC5.Services;
using CommentSystemMVC5.Infrastructure.Repositories;


namespace CommentSystemMVC5.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly CommentService commentService;

        public CommentController()
        {
            commentService = new CommentService(new CommentRespository());
        }

        // GET: Comment
        public ActionResult Index()
        {

            var comment = commentService.SubmitComment(1, "This is a test comment", 0, 313131);
            comment.CommentText = "This is a second test.";
            

            return View();
            
        }
    }
}