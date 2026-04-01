using System.Diagnostics;
using BorkoMusic.Models;
using Microsoft.AspNetCore.Mvc;

namespace BorkoMusic.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Artist Galena = new Artist()
            {
                Id = 1,
                Name = "Galena",
                Honorar = 10000,
                Album = "Oficalno zapranen",
                Image = "/images/galena.jpg"



            };


            Artist Selina = new Artist()
            {
                Id = 1,
                Name = "Selina",
                Honorar = 11000,
                Album = "Mega mix",
                Image = "/images/selina.jpg"



            };
            Artist Emanyela = new Artist()
            {
                Id = 1,
                Name = "Emanyela",
                Honorar = 12000,
                Album = "Notaravno zaqven",
                Image = "/images/Emanyela.jpg"


            };

            Artist Preslava = new Artist()
            {
                Id = 1,
                Name = "Preslava",
                Honorar = 13000,
                Album = "Dyvalsko zhelanie",
                Image = "/images/preslava.jpg"


            };
            Artist Alisiq = new Artist()
            {
                Id = 1,
                Name = "Alisiq",
                Honorar = 14000,
                Album = "Tvoq totalno",
                Image = "/images/alisiq.jpg"
            };
            Artist Desita = new Artist()
            {
                Id = 1,
                Name = "Desita",
                Honorar = 15000,
                Image = "/images/desita.webp"
            };
            Artist Emiliq = new Artist()
            {
                Id = 1,
                Name = "Emiliq",
                Honorar = 16000,
                Album = "Tyrbylenciq",
                Image = "/images/emiliq.jpg"
            };
            Artist Kiara = new Artist()
            {
                Id = 1,
                Name = "Kiara",
                Honorar = 17000,
                Image = "/images/kiara.jpg"



            };
            Artist Simona = new Artist()
            {
                Id = 1,
                Name = "Simona",
                Honorar = 18000,
                Image = "/images/simona.jpeg"
            };
            Artist Mirela = new Artist()
            {
                Id = 1,
                Name = "Mirela",
                Honorar = 19000,
                Album = "Celyvka s Tequila",
                Image = "/images/mirela.jpg",
            };
            Artist Lidiа = new Artist()
            {
                Id = 1,
                Name = "Lidia",
                Honorar = 20000,
                Image = "/images/lidia.jpg",

            };
            Artist Sofi = new Artist()
            {
                Id = 1,
                Name = "Sofi",
                Honorar = 19000,
                Image = "/images/Sofi.webp",


            };
            Artist Tsvetelina = new Artist()
            {
                Id = 1,
                Name = "Tsvetelina",
                Honorar = 21000,
                Album = "Na parvo mqsto",
                Image = "/images/TvetelinaYaneva.jpg",
            };
            Artist Vanesa = new Artist()
            {
                Id = 1,
                Name = "Vanesa",
                Honorar = 22000,
                Image = "/images/Vanesa.jpg",
            };
            Artist Ivaila = new Artist()
            {
                Id = 1,
                Name = "Ivaila",
                Honorar = 23000,
                Image = "/images/Ivaila.jpg",
            };
            Artist Djena = new Artist()
            {
                Id = 1,
                Name = "Djena",
                Honorar = 24000,
                Album = "Ne e lybov",
                Image = "/images/Djena.jpg",
            };
            Artist DesiSlava = new Artist()
            {
                Id = 1,
                Name = "Desi Slava",
                Honorar = 25000,
                Album = "The best of",
                Image = "/images/Desi Slava.jpg",
            };
            Artist TeddyAlexandrova = new Artist()
            {
                Id = 1,
                Name = "Teddy Alexandrova",
                Honorar = 26000,
                Image = "/images/TedyAlexandrova.jpg",
            };
            Artist Aneliq = new Artist()
            {
                Id = 1,
                Name = "Aneliq",
                Honorar = 27000,
                Album = "Fenomanelna",
                Image = "/images/Anelia.jpg",
            };
            Artist Danna = new Artist()
            {
                Id = 1,
                Name = "Danna",
                Honorar = 28000,
                Image = "/images/Danna.jpg",
            };
            Artist Malina = new Artist()
            {
                Id = 1,
                Name = "Malina",
                Honorar = 29000,
                Image = "/images/Malina.jpg"
            };
            Artist Konstatin = new Artist()
            {
                Id = 1,
                Name = "Konstatin",
                Honorar = 30000,
                Image = "/images/konstantin.webp",

            };
            Artist IlianBoyd = new Artist()
            {
                Id = 1,
                Name = "Ilian Boyd",
                Honorar = 31000,
                Image = "/images/IlianBoyd.jpg"
            };
            Artist BorisDali = new Artist()
            {
                Id = 1,
                Name = "Boris Dali",
                Honorar = 32000,
                Album = "Zladnite hitove na Planeta Painer",
                Image = "/images/BorisDali.jpg",

            };
            Artist ToniStoraro = new Artist()
            {
                Id = 1,
                Name = "Toni Storaro",
                Honorar =33000,
                Album = "Balkansko sarce",
                Image = "/images/ToniStoraro.jpg"
            };
            Artist Fiki = new Artist()
            {
                Id = 1,
                Name = "Fiki",
                Honorar = 34000,
                Image = "/images/Fiki.jpg"
            };
            Artist Emrah = new Artist()
            {
                Id = 1,
                Name = "Emrah",
                Honorar = 35000,
                Image = "/images/Emrah.jpg"
            };




             
                    
            



            List<Artist> ArtistsList = new List<Artist>();


            ArtistsList.Add(Selina);
            ArtistsList.Add(Galena);
            ArtistsList.Add(Emanyela);
            ArtistsList.Add(Preslava);
            ArtistsList.Add(Alisiq);
            ArtistsList.Add(Desita);
            ArtistsList.Add(Emiliq);
            ArtistsList.Add(Kiara);
            ArtistsList.Add(Simona);
            ArtistsList.Add(Mirela);
            ArtistsList.Add(Lidiа);
            ArtistsList.Add(Sofi);
            ArtistsList.Add(Tsvetelina);
            ArtistsList.Add(Vanesa);
            ArtistsList.Add(Ivaila);
            ArtistsList.Add(Djena);
            ArtistsList.Add(DesiSlava);
            ArtistsList.Add(TeddyAlexandrova);
            ArtistsList.Add(Aneliq);
            ArtistsList.Add(Danna);
            ArtistsList.Add(Malina);
            ArtistsList.Add(Konstatin);
            ArtistsList.Add(IlianBoyd);
            ArtistsList.Add(BorisDali);
            ArtistsList.Add(ToniStoraro);
            ArtistsList.Add(Fiki);
            ArtistsList.Add(Emrah);


                
          
            return View(ArtistsList);
           

        }


        public IActionResult Privacy()
        {
            return View();

        }
        
        
            

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });



        }
    }
}
