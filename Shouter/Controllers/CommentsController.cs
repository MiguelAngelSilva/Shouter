using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shouter.Models;

namespace Shouter.Controllers
{
    public class CommentsController : Controller
    {
        //
        // GET: /Comments/

        public ActionResult Index()
        {
            return View(CommentsModel.GetComments());
        }

        [HttpPost]
        public ActionResult Index(string commentText)
        {
            if (string.IsNullOrEmpty(commentText) || string.IsNullOrWhiteSpace(commentText))
            {
                ModelState.AddModelError("", "Please, insert a comment.");
                return View(CommentsModel.GetComments());
                
            }
            else
            {
                Comment newComment = new Comment();
                newComment.email = Session["email"].ToString();
                newComment.comment = commentText;
                CommentsModel.InsertComment(newComment);
            }
            
            return RedirectToAction("Index", "Comments");
        }
    }
}
