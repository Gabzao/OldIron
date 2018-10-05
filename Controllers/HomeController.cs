using BusinessLogicalLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OldIronWebApp.Controllers
{
    public class HomeController : Controller
    {
        PecaBLL bll = new PecaBLL();
        TagBLL tBll = new TagBLL();

        public ActionResult Index(int? page)
        {
            ViewBag.Pagina = page.HasValue ? page.Value : 1;
            ViewBag.Pecas = new PecaBLL().LerTodosAoContrario();
            return View();
        }

        public ActionResult Pesquisa(string tag)
        {
            if(string.IsNullOrWhiteSpace(tag))
            {
                return RedirectToAction("Index");
            }
            List<String> tags = tag.Split(' ').ToList();
            List<Peca> listaRetorno = tBll.LerPecasInterseccaoTags(tags);
            return View(listaRetorno); 
        }

        public ActionResult Modelo(int? id)
        {
            if(!id.HasValue)
            {
                return RedirectToAction("Index");
            }
            List<Peca> pecas = bll.LerTodosPecasDoModelo(id.Value);
            return View(pecas);
        }

        public ActionResult ShowImgPeca(int id)
        {
            byte[] imagem = bll.GetImagemPrincipalPeca(id);
            return File(imagem, "image/jpg");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}