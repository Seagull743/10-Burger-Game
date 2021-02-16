using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

        if(myBurger.ingredients.Count != recipe.ingredients.Count)
        {
            burgerFail = true;
        }

        for(int i = 0; i < recipe.ingredients.Count; i++)
        {
            //this iterates forward through a list

            if(i < myBurger.ingredients.Count)
            {
                Debug.Log("myburgers ingredient is " + myBurger.ingredients[i] + " and the recipe's ingredient is " + recipe.ingredients[i]);

                if (myBurger.ingredients[i] != recipe.ingredients[i])
                {
                    burgerFail = true;
                }
            }
            else //should happen if there are more ingredients in the burger or recipe
            {
                burgerFail = true;
            }
        }


        if (!burgerFail)
        {
            Debug.Log("it IS THE RIGHT BURGER");
            SceneManager.LoadScene("YouWin");

        }
        else
        {
            Debug.Log("its not the same burger");


        }

    }


    public Burger TheBurgerIMade(Checker bottomBunchecker)
    {
        myBurger = new Burger();
        AddIngredient(bottomBunchecker, myBurger);

        Debug.Log("there are " + myBurger.ingredients.Count + " ingredients in my burger and there are " + recipe.ingredients.Count + "in the recipe" );

        return myBurger;
    }

    public void AddIngredient(Checker checker, Burger burger)
    {
        Ingredients ingredient = Ingredients.nothing;

        //this can be simplified using a switch statement
        if (checker.gameObject.tag == "BottomBun")
        {
            ingredient = Ingredients.bottomBun;
        }
        else if (checker.gameObject.tag == "Patty")
        {
            ingredient = Ingredients.Patty;
        }
        else if (checker.gameObject.tag == "Lettuce")
        {
            ingredient = Ingredients.Lettuce;
        }
        else if (checker.gameObject.tag == "Cheese")
        {
            ingredient = Ingredients.Cheese;
        }
        else if (checker.gameObject.tag == "Tomato")
        {
            ingredient = Ingredients.tomato;
        }
        else if (checker.gameObject.tag == "onion")
        {
            ingredient = Ingredients.onion;
        }
        else if (checker.gameObject.tag == "TopBun")
        {
            ingredient = Ingredients.TopBun;
        }

        burger.ingredients.Add(ingredient);

        if (checker.checkerAboveMe != null)
        {
            AddIngredient(checker.checkerAboveMe, burger);
        }

        Debug.Log(ingredient);

    }
    


}
