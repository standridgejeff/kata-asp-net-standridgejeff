# ASP.NET MVC with Razor

## Tasks

We're going to explore how we would use ASP.NET MVC to build an application that uses MVC:

1. We'll use a Person Model
1. We'll use a Person View and a Person List View to properly display our data
1. We'll use a Person Controller to control the interaction between our view and model

### Step 1

Add a Model called `Person`

This is just a `POCO` ([Plain Old CLR Object](https://en.wikipedia.org/wiki/Plain_old_CLR_object)), so just create a normal class called `Person`.

### Step 2

Add a Controller called `PersonController`

This will create a `PersonController.cs` file with default Controller implementation boiler plate code ready to go.

### Step 3

Add a List View for displaying your `Person`.

This gives us the default view for our Person Controller and the view we'll use for diplaying the list of people from our model.

### Step 4

Connect Everything Together

Use your controller to initialize a list of people and pass that list to your List People view.

### Step 5

Use Dapper and SQL for your Model

Do the steps above for the Product and grab that data from your localhost SQL server.

1. Add a `Product.cs` Model to your Models folder
1. Add a `ProductController` Controller to your Controllers folder.
    * Select the MVC 5 Controller with Read/Write actions from the list of templates
1. Add your Product Index View by right-clicking on `View()` that is found within your `Index` method in your `ProductController`
    * Leave the name as `Index`
    * Select the `List` template
    * Select `Product` as your Model
1. Use Dapper with a SQL statement to pull in your list of Products and pass that to the `View()` (something like this: `View(list);`)
1. Follow steps 3 and 4 for Create, Edit, Details, and Delete views for your Product. Make sure that you pass in the individual product to your `View()` in your Details view.

### Step 6

Add the final `CRUD` steps to your project:

1. Add the ability to Create a Product
    * Suggested to allow creation with just the `Name` column set (you'll need to Alter your MySQL table)
    * You'll place your code inside the `Create(FormCollection form)` method for Creating a product
    * Make sure you're using proper SQL syntax and using Dapper anonymous objects to avoid SQL injection
1. Do the same process for Update (Edit view) and Delete (Delete view)

### Step 7

This step is **VERY IMPORTANT**. You need to commit your changes so far, but you **MUST NOT** commit your connection string to git. Use Source Tree to commit just the lines and chunks of code that deserve commits.