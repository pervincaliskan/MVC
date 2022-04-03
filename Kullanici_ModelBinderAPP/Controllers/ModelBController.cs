using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kullanici_ModelBinderAPP.ModelBlinders;           //namespace hatası almamak için tanımlamayı unutma

namespace Kullanici_ModelBinderAPP.Controllers
{
    public class ModelBController : Controller
    {
        // GET: ModelB
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ModelBOrnek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ModelBOrnek([ModelBinder(typeof(Kullanici_ModelBinderAPP.ModelBlinders.ZamanModelBinder))] DateTime tarih)
            //Hangi model bindero kullanacagınızı belirtmelisiniz. Bu nedenle modelbinder attribute'u çagırılır.
            //Attribute'un parametresinde binder'ın türü belirtilir
        {    //Controller' a ayzılan veriker, controller sınıfında HttpPost attribute'lu action metodda modelin parametre tanımlanmasıyla alınır
            //Kaydetme düzeltem işlemleri burada yapılır.
            return View();
        }
    }
}