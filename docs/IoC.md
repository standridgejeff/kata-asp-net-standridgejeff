# Inversion of Control

## Tasks

Apply the changes accomplished in your Inversion of Control project to your AspNetCoreKata.

**Note:** as you complete steps, you should make commits for the changes made, unless it doesn't make sense to do so. For example, **DO NOT** commit your connection string to Git.

### Step 1

We don't want to store the secure connection string in Git, since this is considered an insecure, bad practice. Move your connection string to your `appsettings.json` file:

#### Step A

Move your `appsettings.Development.json` file out of your working directory (perhaps move it to your Desktop temporarily)

#### Step B

Commit the "deletion" of that file from Git.

#### Step C

Open your `.gitignore` file and add this somewhere in that file:

```bash
# ignore appsettings
**/appsettings.development.json
**/appsettings.staging.json
**/appsettings.production.json
```

Now, a file matching this description will be ignored by Git.

#### Step D

Move your `appsettings.Development.json` file back into your working directory

If you run `git status`, you'll see this file doesn't show up as "added" or "modified". Because it's ignored, you don't have to worry about committing sensitive information.

#### Step E

Add your connection string to your `appsettings.Development.json` file and a corresponding "Bread Crumb" value within your `appsettings.json` file.

### Step 2

Add a class library for your Product Repository so that you can move the Model out of your Controller.

1. Create a new .NET Core class library called `AspNetCoreKata.ProductRepo`
1. Copy the `IProductRepository`, `ProductRepository`, and `Product` files from your Inversion of Control project into the `AspNetCoreKata.ProductRepo` folder, and remove them from your `AspNetCoreKata` project
1. Add these existing files to your class library
1. Navigate to the list of references in your `AspNetCoreKata` project and add a reference to your class library

### Step 3

Remove the `Product.cs` model from your main project

* There should be no reference to your `Product.cs` anywhere in your Models folder or in the `AspNetCoreKata.Models` namespace. You'll be referencing the Product class from your Class Library

### Step 4

Add inversion of control via. the `ConfigureServices` method in your `Startup.cs` file:

1. Downgrade `Unity.Mvc` to the most advanced `3` version. Something like this: `3.x.x`
1. Register your `IProductRepository` interface with your `ProductRepository` class
1. Register the `IDbConnection` interface with the `MySQLConnection` class

### Step 5

Add a constructor for your `ProductController` and a `private readonly` property to store your `IProductRepository`. Should look something like this:

```cs
private readonly IProductRepository repo;

public ProductController(IProductRepository repo)
{
    this.repo = repo;
}
```

This allows your IoC container to set the `repo` to an instance of your `ProductRepository`

### Step 6

Confirm that everything is done. By the end of the above tasks, your project should:

* Have no reference to `using Dapper` within your main project
* Have no connection strings within your source code; it should be located in your `appsettings.json` file
* Have no Product class within your `Models` folder in your main project
