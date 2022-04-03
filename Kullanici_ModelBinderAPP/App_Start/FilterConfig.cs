using System.Web;
using System.Web.Mvc;

namespace Kullanici_ModelBinderAPP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
