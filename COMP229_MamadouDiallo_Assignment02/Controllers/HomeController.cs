using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP229_MamadouDiallo_Assignment02.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace COMP229_MamadouDiallo_Assignment02.Controllers
{
    public class HomeController : Controller
    {

        private IRecipeRepository repository;

        public HomeController(IRecipeRepository repo)
        {
            repository = repo;
        }

        //Simple action to view the Index/Home page
        public ViewResult Index()
        {
            return View();
        }

        //This action is to view our a page to add recipes and post all the inputs
        [HttpGet] 
        public ViewResult AddRecipe()
        {
            return View();
        }

        //After adding a recipe, it gets saved in our repository
        //and takes us to thank you page to thank our chefs
        //[HttpPost] 
        //public ViewResult AddRecipe(Recipe recipe)
        //{

        //    Repository.AddingRecipe(recipe);

        //    return View("Thanks", recipe);
        //}

        //This action allows us to see our list of recipes in alphabetical order
        public ViewResult RecipeList() => View(repository.Recipes);

        public ViewResult Edit(int recipeID) =>
            View(repository
                .Recipes
                .FirstOrDefault(r => r.RecipeId == recipeID));

        [HttpPost]
        public IActionResult Edit(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipe);
                return RedirectToAction("RecipeList");
            }
            else
            {
                return View(recipe);
            }
        }

        public ViewResult Create() => View("Edit", new Recipe());
        //This action allows us to display details of a chosen recipe name that is already saved in our repository
        //It is also in accordance to our routing mechanism defined in the startup class
        public ViewResult ViewRecipe(int id) =>
            View(repository
                .Recipes
                .FirstOrDefault(r => r.RecipeId == id));

        //Simple action to view the Review page
        public ViewResult ReviewRecipe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int recipeID)
        {
            Recipe deletedRecipe = repository.DeleteRecipe(recipeID);

            //if (deletedRecipe != null)
            //{

            //}

            return RedirectToAction("RecipeList");
        }
    }
}
