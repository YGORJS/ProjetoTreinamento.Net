using System.Web;
using System.Web.Mvc;

namespace Treinamento.Globo.Programas.NET.WEB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
