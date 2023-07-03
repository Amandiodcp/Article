using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quete1.Models;

namespace Quete1.Controllers
{
    public class ArticleController : Controller
    {
        private List<Article> Articles { get; set; }

        public ArticleController() {
            Articles = new List<Article>();

            Articles.Add(new Article(1, "Article 1", "Content article 1"));
            Articles.Add(new Article(2, "Article 2", "Content article 2"));
            Articles.Add(new Article(3, "Article 3", "Content article 3"));
        }


        // GET: ArticleController
        public IActionResult Index()
        {
            return View();
        }

        // GET: ArticleController/Details/5
        public ActionResult Details(int id)
        {
            Article article = Articles.First(article => article.Id == id);
            return View(article);
        }

        // GET: ArticleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // Ajout de l'article dans la base de données / la liste en haut du controller
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleController/Edit/5
        public ActionResult Edit(int id)
        {
            Article article = Articles.First(article => article.Id == id);
            return View(article);
        }

        // POST: ArticleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // mettre à jour l'article en base de données
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleController/Delete/5
        public ActionResult Delete(int id)
        {
            Article article = Articles.First(article => article.Id == id);
            return View(article);
        }

        // POST: ArticleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // supprimer en base de données
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
