using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YTechMovieSearchMVC.Models;

namespace YTechMovieSearchMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult Details(string id)
        {
            string apiKey = "f6ee4776";
            HttpWebRequest apiRequest = WebRequest.Create("http://www.omdbapi.com/?i=" + id + "&apikey=" + apiKey) as HttpWebRequest;

            string apiResponse = "";
            using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                apiResponse = reader.ReadToEnd();
            }

            Movies rootObject = JsonConvert.DeserializeObject<Movies>(apiResponse);//to convert json data to type of class movie
            return View(rootObject);

        }

      

        public ActionResult Contact()
        {
           

            return View();
        }
    }
}