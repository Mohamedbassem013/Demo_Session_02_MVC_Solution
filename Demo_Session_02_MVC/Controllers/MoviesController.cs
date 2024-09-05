using Demo_Session_02_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Session_02_MVC.Controllers
{
    public class MoviesController : Controller
    {
        //Actions : Public non-Static Funcations


        public string Test()
        {
            return $" Default Path";
        }

        //=====================================================

        // Actions
        public string GetMovies(int id)
        {
            return $" ID: {id}";
        }

        ///======================================================

        //(ContentResult) ف استخدمه بدل ما اكتب مثلا زي ال interface وده IActionResult بيورث من ActionResult في قاعده عندي ان اي 
        //[HttpGet] //By Default بيتعمل 
        //[ActionName("hamada")] //(hamada)وتحط مكانه الاسم الجديد اللي اسمه (GetMovie)دي بتشيل اسم الميثود اللي اسمه
        //public IActionResult GetMovie(int? id)
        //{
        //    //var result = new ContentResult();
        //    //result.Content = $" ID : {id}";
        //    //result.ContentType = "text/html"; // بتغير شكل الكلام ولون الصفحه
        //    //                                  // result.ContentType = "object/pdf"; //pdf هيعتبر اللي راجع عباره عن 
        //    //return result;

        //    //Content() اسمها Function بدل ما اعمل كل الكلام ده في 

        //    return Content($"ID : {id}", "text/html");


        //}

        ///======================================================
        public IActionResult GetMovie(int? id , string Name , Movie movie)
        {
            //var result = new ContentResult();
            //result.Content = $" ID : {id}";
            //result.ContentType = "text/html"; // بتغير شكل الكلام ولون الصفحه
            //                                  // result.ContentType = "object/pdf"; //pdf هيعتبر اللي راجع عباره عن 
            //return result;

            //Content() اسمها Function بدل ما اعمل كل الكلام ده في 

            return Content($"ID : {id}", "text/html");


        }

        ///======================================================
        //Action Parameter Binding: اللي انا باعته في 4 اماكنParameter بيروح يشوف اسم ال

        // 1. From
        // 2. Segment
        // 3. Query String (or) Query Params
        // 4. File

        ///======================================================

        // (ContentResult) ده بيروح يغير اتجاهه ويطبع اللي في ال
        public RedirectToActionResult Test01()
        {
            RedirectToActionResult result = new RedirectToActionResult("GetMovie", "Movies", new { id = "Hamda" });
            return result;
        }

        ///======================================================

        //معين (Link) URL علي direct ده بيروح يعمل 
         public IActionResult Test02(int id)
         {
             RedirectResult result;
             if (id == 1)
             {
                 // result = new RedirectResult("https://www.facebook.com");
        
                 //---------------------------------
                 return Redirect("https://www.facebook.com");
             }
             else
             {
                 result = new RedirectResult("https://www.google.com");
        
                 //--------------------------------------
                 return Redirect("https://www.google.com");
             }
             return result;
             //غير كدا روح علي جوجل id روح علي فيس بوك ولو id = 1 لو ال Check هنا بعمل
        
        
             ///======================================================
         }
            //else روح علي فيس بوك غير كدا روح علي ال NULL هنا بقوله لو القيمه اللي راجع مش ب
         public ActionResult Test03(int? id)
         {
             if (id == null)
             {
                 //RedirectResult result = new RedirectResult("https://www.facebook.com");
                 //return result;

                 //-----------------------------
                 return Redirect("https://www.facebook.com");

             }
             else
             {
                 //RedirectToActionResult result = new RedirectToActionResult("GetMovie", "Movies", new { id = "Hamda" });
                 //return result;

                 //---------------------------------------
                 return RedirectToAction("GetMovie", "Movies", new { id = "1000" });
             }
         }
    }
}
