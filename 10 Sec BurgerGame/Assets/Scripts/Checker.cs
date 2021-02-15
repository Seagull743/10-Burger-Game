using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Checker : MonoBehaviour
{
    public Ingredients aboveMeIs;

    public Checker checkerAboveMe;
    
    public void This()
    {
        aboveMeIs = Ingredients.bottomBun;

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        #region aboveMeis stuff

        #endregion

        if(collision.gameObject.GetComponent<Checker>() != null)
        {
            checkerAboveMe = collision.gameObject.GetComponent<Checker>();

        }
            



    }


    private void OnTriggerExit(Collider other)
    {
        checkerAboveMe = null;
    }





    //on triger enter
    // aboveme== 
}
