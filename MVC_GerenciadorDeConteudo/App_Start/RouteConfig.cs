using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_GerenciadorDeConteudo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //   routes.MapRoute(
            //    "sobre",
            //    "sobre/{id}/rafael",
            //    defaults: new { controller = "Home", action = "about", id = 0 }
            //);

            routes.MapRoute(
               "paginas",
               "paginas",
               defaults: new { controller = "Paginas", action = "Index" }
           );

            routes.MapRoute(
              "paginas_novo",
              "paginas/novo",
              defaults: new { controller = "Paginas", action = "Novo" }
          );
            routes.MapRoute(
             "paginas_criar",
             "paginas/criar",
             defaults: new { controller = "Paginas", action = "Criar" }
         );

            routes.MapRoute(
            "consulta_cep",
            "consulta-cep",
            defaults: new { controller = "Cep", action = "index" }
        );
            routes.MapRoute(
            "paginas_editar",
            "paginas/{id}/editar",
            defaults: new { controller = "Paginas", action = "Editar", id = 0 }
        );
            routes.MapRoute(
           "paginas_excluir",
           "paginas/{id}/excluir",
           defaults: new { controller = "Paginas", action = "Excluir", id = 0 }
       );

            routes.MapRoute(
            "paginas_preview",
            "paginas/{id}/preview",
            defaults: new { controller = "Paginas", action = "Preview", id = 0 }
             );

            routes.MapRoute(
           "paginas_preview_dinamico",
           "paginas/{id}/preview-dinamico",
           defaults: new { controller = "Paginas", action = "PreviewDinamico", id = 0 }
            );
            routes.MapRoute(
         "paginas_preview_notema",
         "paginas/{id}/preview-dinamico-notema",
         defaults: new { controller = "Paginas", action = "PreviewDinamicoNoTema", id = 0 }
          );
            routes.MapRoute(
           "paginas_alterar",
           "paginas/{id}/alterar",
           defaults: new { controller = "Paginas", action = "Alterar", id = 0 }
       );

            routes.MapRoute(
               "sobre",
               "sobre",
               defaults: new { controller = "Home", action = "about", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                "contato",
                "contato",
                defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
