using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWinCheck : MonoBehaviour
{
    //this is the burger you are meant to be making;
    public Burger recipe;
    public Checker bottomBunChecker;

    private Burger myBurger;

  
    //create a concept of the burger you have made

    public void CheckBurgerAgainstRecipe()
    {
        myBurger = TheBurgerIMade(bottomBunChecker);
        bool burgerFail = false;

        for(int i = 0; i < recipe.ingredients.Count; i++)
        {
            //this iterates forward through a list

            if (myBurger.ingredients[i] != recipe.ingredients[i])
            {
                burgerFail = true;
                Debug.Log("its not the same burger");

            }
        }

        if (!burgerFail)
        {
            Debug.Log("it IS THE RIGHT BURGER");
        }

    }

    public Burger TheBurgerIMade(Checker bottomBunchecker)
    {
        myBurger = new Burger();

        myBurger.ingredients.Add(Ingredient(bottomBunchecker));
        Debug.Log("there are " + myBurger.ingredients.Count + " ingredients in my burger");

        return myBurger;
    }

    public Ingredients Ingredient(Checker checker)
    {
        Ingredients ingredient = Ingredients.nothing;

        //this can be simplified using a switch statement
        if (checker.gameObject.tag == "BottomBun")
        {
            ingredient = Ingredients.bottomBun;
        }
        if (checker.gameObject.tag == "Patty")
        {
            ingredient = Ingredients.Patty;
        }
        if (checker.gameObject.tag == "Lettuce")
        {
            ingredient = Ingredients.Lettuce;
        }
        if (checker.gameObject.tag == "Cheese")
        {
            ingredient = Ingredients.Cheese;
        }
        if (checker.gameObject.tag == "Tomato")
        {
            ingredient = Ingredients.tomato;
        }
        if (checker.gameObject.tag == "onion")
        {
            ingredient = Ingredients.onion;
        }
        if (checker.gameObject.tag == "TopBun")
        {
            ingredient = Ingredients.TopBun;
        }

        //if (checker.checkerAboveMe != null)
        //{
        //    Ingredient(checker.checkerAboveMe);
        //}

        Debug.Log(ingredient);

        return ingredient;
    }
    


}
