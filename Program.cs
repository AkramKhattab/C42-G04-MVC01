namespace C42_G04_MVC01
{   
    public class Program
    {   
         public static void Main(string[] args)
         {

             var builder = WebApplication.CreateBuilder(args);
    
             // Add Any Service You need To The Container

             builder.Services.AddControllersWithViews();// Register The Built-in MVC Service in The Container
             //builder.Services.AddControllers(); // Register The Built-in APIs Service in The Container
             //builder.Services.AddRazorPages(); // Register The Built-in Razor Pages Service in The Container
             //builder.Services.AddMvc(); // Register The Built-in All Web Services in The Container


             var app = builder.Build();
            

            app.UseStaticFiles(); // MiddleWare use it for Static File "CSS"
         

             // Configure The HTTP pipeline

             //app.MapGet("/", () => "Hello World!");
             //app.MapGet("/hamada", () => "Hello hamada!");
             //app.MapGet("/signin", signin);

             // https://localhost:44371/Movies/GetMovie/1


             app.MapControllerRoute(
                     name:"Default",
                     pattern: "/{controller=Home}/{action=Index}/{id:int?}"
                     );

             app.Run();
 
              #region ASP.NET Core MVC
		
            /*## Routing

            Routing is the mechanism that maps incoming HTTP requests to the appropriate controller actions in your ASP.NET Core MVC application. It's a crucial part of the MVC framework that determines how your app responds to different URLs.
            
            ### Basic Routing Concepts:
            - Routes are defined in the `Startup.cs` file or using attribute routing in controllers.

            - The default route pattern is `{controller=Home}/{action=Index}/{id?}`.

            - This means: controller name, then action name, then an optional id parameter.
            
            
            
            
            ### Route Configuration:

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            


            ### Routing Constraints:



            Constraints allow you to restrict how routes are matched based on URL parameters.
            They're useful for ensuring that routes are only matched when parameters meet specific criteria.
            
            Common constraints include:
            - `int`: Matches integer values
            - `bool`: Matches boolean values
            - `datetime`: Matches DateTime values
            - `guid`: Matches GUID values
            - `alpha`: Matches alphabetic characters
            - `regex()`: Matches a regular expression pattern
            
            Example with constraints:

            endpoints.MapControllerRoute(
                        name: "blog",
                        pattern: "blog/{year:int}/{month:range(1,12)}/{slug}",
                        defaults: new { controller = "Blog", action = "Post" });
            




            
            ## Actions and Controllers
            
            Controllers are classes that handle incoming requests.
            Actions are methods within these classes that process requests and return responses.
            
            ### Action Return Types:


            1. `IActionResult`: The base interface for action results.

            2. `ViewResult`: Returns a view to be rendered.

            3. `JsonResult`: Returns a JSON-formatted response.

            4. `ContentResult`: Returns a plain text response.

            5. `FileResult`: Returns a file download.

            6. `RedirectResult`: Redirects to another action or URL.

            7. `StatusCodeResult`: Returns a specific HTTP status code.
            
            Example:



            public IActionResult Index()
            {
                return View();                                  // Returns a ViewResult
            }
            
            public IActionResult GetData()
            {
                var data = new { Name = "John", Age = 30 };
                return Json(data);                             // Returns a JsonResult
            }
            
            





            ### Action Parameters Binding:


            ASP.NET Core can bind action parameters from various sources:
            
            1. From Route: `[FromRoute]`

            2. From Query String: `[FromQuery]`

            3. From Request Body: `[FromBody]`

            4. From Form: `[FromForm]`

            5. From Header: `[FromHeader]`

            
            Example:
            public IActionResult User([FromRoute] int id, [FromQuery] string name)
            {
                
            }
            






            ## Views
            
            Views are responsible for presenting data to users. 
            They're typically written using Razor syntax, which combines HTML with C# code.
            


            ### View Basics:
            - Views are stored in the `Views` folder, typically organized by controller.
            - The view name usually matches the action name.
            


            ### Layout:
            Layouts provide a consistent structure across multiple views.
            
            - Stored in `Views/Shared/_Layout.cshtml` by default.
            - Define the overall HTML structure and common elements.
            - Use `@RenderBody()` to specify where page-specific content should be inserted.
            

            Example layout:
            <!DOCTYPE html>
            <html>
            <head>
                <title>@ViewData["Title"]</title>
            </head>
            <body>
                <header>
                    <!-- Common header content -->
                </header>
                
                <main>
                    @RenderBody()
                </main>
                
                <footer>
                    <!-- Common footer content -->
                </footer>
            </body>
            </html>
            



            
            ### _ViewStart:
            `_ViewStart.cshtml` contains code that runs before rendering any view in its directory or subdirectories.
            

            Typical usage (setting default layout):
            @{
                Layout = "_Layout";
            }





            
            ### Tag Helpers:

            Tag Helpers enable server-side code to participate in creating and rendering HTML elements in Razor files.
            
            Example (form tag helper):

            <form asp-controller="Account" asp-action="Login" method="post">
                <!-- Form fields -->
            </form>


            
            ### _ViewImports:
            `_ViewImports.cshtml` is used to include common namespaces and tag helpers across multiple views.
            
            Example:
            @using MyApp.Models
            @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

            This file reduces the need to include these statements in every view file.
            
           
             */
#endregion

         }


        static string signin()
        {
            return "sigin";
        }


    }
}
