using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApplication1.Infrastructure
{
    //Mamy dostep do Web.config, gdzie dodalismy wlasny klucz o nazwie "AutoGrafiki"
    //w przypadku braku klasy zwracajacej adresy obrazkow, dodajemy ja (w tym przypadku nazwana jest "UrlHelpers")
    public class AppConfig
    {
        private static string postersPath = ConfigurationManager.AppSettings["AutaGrafiki"];

        public static string PostersPath { get => postersPath; set => postersPath = value; }
    }
}