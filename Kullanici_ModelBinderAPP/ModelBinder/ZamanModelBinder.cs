using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kullanici_ModelBinderAPP.ModelBlinders
{
    public class ZamanModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase istek = controllerContext.HttpContext.Request;
            string gun = istek.Form.Get("Gun");
            string ay = istek.Form.Get("Ay");
            string yil = istek.Form.Get("Yil");
            string saat = istek.Form.Get("Saat");
            string dakika = istek.Form.Get("Dakika");
            string saniye = istek.Form.Get("Saniye");
            return new DateTime(Convert.ToInt32(yil), Convert.ToInt32(ay), Convert.ToInt32(gun), Convert.ToInt32(saat),
                Convert.ToInt32(dakika), Convert.ToInt32(saniye));
        }
    }
}