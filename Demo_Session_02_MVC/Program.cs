namespace Demo_Session_02_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add To Any Server U Need To The Container

            builder.Services.AddControllersWithViews();// Register The Built-in MVC Service in The Container
         // builder.Services.AddControllers(); //  Register The Built-in APIs Service in The Container
         // builder.Services.AddRazorPages();  //  Register The Built-in AddRazorPages Service in The Container
         // builder.Services.AddMvc();         //  Register The Built-in All Web Service in The Container -->(MVC and ) بتعمل ليا كل حاجه

            var app = builder.Build();

            app.UseStaticFiles(); //Midlleware use it for Static File


             // app.MapGet("/", () => "Hello World!");
            // app.MapGet("/hamada", () => "Hello hamada!");
            // app.MapGet("/Singin", () => "Hello Singin!");

            // http://localhost:5001/Movies/GetMovie/1

            //MapGet دي بدل ما اعمل كل شويه
            app.MapControllerRoute(
                name: "Default",
                pattern: "/{Controller}/{action}/{id?}"


            //pattern: "/{Controller}/{action}/{id}"
            //pattern: "/{Controller}/{action}/{id?}"
            //pattern: "/{Controller =Movies}/{action=Test}/{id=1}"
            //pattern:"/{Controller = Movies}/{action= Test}/{id?}"
            //pattern: "/{Controller = Movies}/{action= Test}/{id:int?}"
            //pattern: "/{Controller = Movies}/{action= Test}/{id:alpha?}"
            //pattern: "/Controller /action/id"

            ); //AddControllersWithViews لي ال call تشتغل لازم اعمل (MapControllerRoute) لازم عشان ال


            app.Run();
        }
        static string Singin()
        {
            return "Sigin";
        }
    }
}
