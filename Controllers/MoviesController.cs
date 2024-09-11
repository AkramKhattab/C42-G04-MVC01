using C42_G04_MVC01.Views.Movies;
using Microsoft.AspNetCore.Mvc;

namespace C42_G04_MVC01.Controllers
{
    public class MoviesController : Controller
    {

        // Actions : Public Non-Static Functions
        // Actoons has special DataTypes [Action Result]



        //public string GetMovie (string id)
        //{
        //    return $"Id: {id}";
        //}


        [HttpGet]
        [ActionName("Hamda")]
        public IActionResult GetMovie(int? id, string name, Movie movie )
        {
            //ContentResult result = new ContentResult();

            //result.Content = $"id: {id}";
            //result.ContentType = "text/html";
            //result.ContentType = "object/pdf";
            //return result;

            return Content($"Id: {id}", "text/html");
        }

        // Action Parameters Binding:
        //1. Form
        //2. Segmant
        //3. Query String / Query Params
        //4. File
        

        //public IActionResult Test(int? id)
        //{
        //    if (id is null)
        //    {
        //        //RedirectResult result = new RedirectResult("https://www.facebook.com/");
        //        //return result;

        //        return Redirect("https://www.facebook.com/");
        //    }
        //    else
        //    {
        //        //RedirectToActionResult result = new RedirectToActionResult("GetMovies", "Movies", new { id = id });
        //        //return result;

        //        return RedirectToAction("GetMovies", "Movies", new { id = id });
        //    }
        //}



       //public IActionResult Test01(int? id)
       //{

       //    RedirectResult result;
       //    if (id == 1)
       //    {
       //        result = new RedirectResult("https://www.facebook.com/");
       //    }
       //    else
       //    {
       //        result = new RedirectResult("https://www.google.com/");
       //    }
       //    return result;
       //    }



        







 
    }

}
