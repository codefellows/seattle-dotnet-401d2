![cf](http://i.imgur.com/7v5ASc8.png) Lab 11 : MVC Core (Controllers & Views)
=====================================

### Setup
1. Walk through creating empty MVC app
2. Add Middleware

### Controller Defaults
1. When creating an empty web app in Core, you will automatically get a home page that says "Hello World"
    - This will run everytime it a controller isnt found. 
    - if you dont want this, just remove it.
    - This is through this section of code in the Startup Class:
    ```csharp
    app.Run(async (context) =>
    {
        await context.Response.WriteASync("Hello World!");
    });
    ```

2. If you want to set a default location modify your app.UseMvc():
    ```csharp
      app.UseMvc(route =>
            {
                route.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");

            });

     ```

### Routing
1. What if we want special Routing? 
2. Create an `ErrorController` class
3. add a `public string Support()` method that returns string "Error on page";
   - This will create the url /Error/Support url for us, but what if we don't wnat peole to know that our action is named "Support"?
   - Change the name of the method to "Index" and add routing:
    ```csharp
        [Route("Error")]
        public class ErrorController
        {
            [Route("Support")]
            public string Index()
            {
                return "Content not found. Contact Support";
            }
        }
    ```
4. Got to .../Error/Support and the error page will show


### Manipulate Data

1. Let's manipulate data from the browser in the controller.

2. "Actions" in Controllers can take paramters

Add this Code

  ```csharp
        public string Welcome(string name, int number)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, Number is: {number}");
        }

   ```
#### How does it know?

- the MVC Model binding system automatically maps the named parameters from the query string in the address bar to parameters in your method. 

#### How Model Binding Works:
1. When MVC receives an HTTP request, it routes it to a specific action method of a controller.
2. It determines which action method to run based on what is in the route data, then binds it to the HTTP request to that action method's parameters.

3. Let's go back to the Route Template:
   - `{controller=Home}/{action=Index}/{id?}`

4. movies/edit/2 --> 
  - rotues to the Movies Controller
  - Edit is the Action
  - accepts an ID (of 2 in this case. )
  - It defaults to whatever is after the '/' to id, unless otherwise specified

**This is all you need to know about it for now, We will cover the other details of Model Binding later on**


## Views

### What are Views?

- Views encapsulate the presentation detail of the user's interaction,
- Views are HTML templates are embedded code that generate content to send to the client
- Views use Razor Syntax - this allows code to minimally interact with the HTML
- extension is .cshtml pages
- Layout structure:
  - Each "Controller" has it's own folder in the Views that holds the different Views. 
- Partial Views and Layouts can be used to avoid repetition of code for views throughout a site. 

### Creating Views

- Views that are specific to a Controller are created in 'Views/[Controller Name] folder. 
- Views that are shared amongst multiple controllers are in /Views/Shared folder.
- Name the View in association with the Controller aciton (i.e. To create an About view for hte Home Controller, create /Views/Home/About.cshtml)


### Razor Syntax:
- Razor Code is donoted by: `@` symbol. 
- c# code is run within Razor code blocks set up by `{}` curly braces.

### Controllers & Views
- Views are returned in Controllers from as actions through `ViewResult`. 
- You action method can create and return a `ViewResult` direclty, but if your Controller inherits from `Controller`, you'll simply just use `View` helper method:

```csharp
return View();
```

1. In the above example, View Discovery is used to automatically find the matching view to the controller action.
2. The Views are search by the system in these locations first:
    - Views/<\ControllerName>/<\ViewName>.cshtml
    - Views/Shared/<\ViewName>.cshtml
3. You can explicitily tell it to go to another view by `return View("MyView") and it will look for a view named "MyView"
4. You can also explicity tell it to look in a specific location `return View("Views/Home/About.cshtml")`

### Passing Data to Views

1. The best way to pass data to your views is through a *model* type in the view (often referred to as a View Model).
	- An instance of this model type is then passed to the view from the action
	- Advantages of passing it through a view or view model is so that view can take advantage of the strong type checking. 
	- you specify a model for a view using the `@model` directive

	```csharp
	@model WebApplication1.ViewModels.Address
   <h2>Contact</h2>
   <address>
       @Model.Street<br />
       @Model.City, @Model.State @Model.PostalCode<br />
       <abbr title="Phone">P:</abbr>
       425.555.0100
   </address>
	```


	```csharp
		public IActionResult Contact()
	   {
		   ViewData["Message"] = "Your contact page.";

		   var viewModel = new Address()
		   {
			   Name = "Microsoft",
			   Street = "One Microsoft Way",
			   City = "Redmond",
			   State = "WA",
			   PostalCode = "98052-6399"
		   };
		   return View(viewModel);
	   }
	```


#### View Models
	1. Add a New folder - Name it ViewModels
	2. Add a new Class and put the name of the properties you want the ViewModel to contain in it.
	3. In your Controller, create a new viewmodel object
	4. set the values and pass that viewmodel to the View.

#### ViewData & ViewBag
	1. `ViewData` - dictionary object accessed through string keys
		- you can store and retrieve objects in it. If you need it other than a string you have to explicitly cast them. 
		- you can use `ViewData` to pass data from a controller to the views as well within views (partials or layouts)
	2. `ViewBag` - Provides dynamic access to the to the onjects stored in `ViewData`. 
		- Easier to work with since it doesn't require casting. 

		```csharp
		@ViewBag.Greeting World!

	   <address>
		   @ViewBag.Address.Name<br />
		   @ViewBag.Address.Street<br />
		   @ViewBag.Address.City, @ViewBag.Address.State @ViewBag.Address.PostalCode
	   </address>

		```


#### Dynamic Views
	1. Views that do not declare a model type but have a model instance passed to them can be referenced this instance dynamically/
	2. Example: An action passes an instance of Address, but the view doesn't declare @model, the view can still show:
		```csharp
			<address>
				@Model.Street<br />
				@Model.City, @Model.State @Model.PostalCode<br />
				<abbr title="Phone">P:</abbr>
				425.555.0100
			</address>
		``
	3. Disadvantes: No intellisense or compilation protection.


```csharp
<form method="post" action="/Home/Create">
    <div class="form-group">
        <label for="Name">Name:</label>
        <input class="form-control" name="Name" />
    </div>
    <div class="form-group">
        <label for="Country">Country:</label>
        <input class="form-control" name="Country" />
    </div>
    <div class="form-group">
        <label for="Population">Population:</label>
        <input class="form-control" name="Population" />
    </div>

    <button type="submit" bs-button-color="danger">Add</button>              
    <a class="btn btn-primary" href="/Home/Index">Cancel</a>
</form>

```

#### Sending A List</ Student>()
	1. In Controller Action, create a list of the Student Class
	2. Add a few students
	3. Return View(MyStudents.ToList())
	4. Go to View -> Modify declarative statement at top to this: `@model IList<ControllersAndRouting.ViewModels.Student>`
	5. Foreach loop can now be used to power through the list of students `@foreach(var s in Model)`


# Assignments

## Readings
1. https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller
1. https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view
1. https://docs.microsoft.com/en-us/aspnet/core/mvc/views/overview
1. https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/actions

     
## Coding Challenge
Implement a stack using Linked Lists <br />

-Using your "data-structures" repository
  - add a folder and label it `Linked Lists`
  - add the code on a branch from this challenge into this repo
  - Describe your approach in the strings folder readme document
  - Spend no more than 90 minutes on this challenge
  - Submit a link to your repo PR in canvas