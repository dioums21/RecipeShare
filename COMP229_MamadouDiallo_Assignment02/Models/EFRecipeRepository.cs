using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_MamadouDiallo_Assignment02.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private AppDbContext context;

        public EFRecipeRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Recipe> Recipes => context.Recipes;

        public void SaveRecipe(Recipe recipe)
        {
            if (recipe.RecipeId == 0)
            {
                context.Recipes.Add(recipe);
            }
            else
            {
                Recipe recipeInput = context.Recipes
                    .FirstOrDefault(p => p.RecipeId == recipe.RecipeId);

                if (recipeInput != null)
                {
                    recipeInput.Name = recipe.Name;
                    recipeInput.Description = recipe.Description;
                    recipeInput.Ingredients = recipe.Ingredients;
                    recipeInput.Chef = recipe.Chef;
                    recipeInput.PreparationTime = recipe.PreparationTime;
                }
            }
            context.SaveChanges();
        }

        public Recipe DeleteRecipe(int recipeID)
        {
            Recipe recipeInput = context.Recipes
                .FirstOrDefault(p => p.RecipeId == recipeID);

            if (recipeInput != null)
            {
                context.Recipes.Remove(recipeInput);
                context.SaveChanges();
            }

            return recipeInput;
        }
    }
}
