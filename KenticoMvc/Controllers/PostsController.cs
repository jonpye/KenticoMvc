using CMS.DocumentEngine.Types.Mvc;
using System.Web.Mvc;

namespace KenticoMvc.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts
        public ActionResult Index()
        {
            var posts = PostProvider.GetPosts();
            return View(posts);
        }
    }
}