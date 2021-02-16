using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Checker : MonoBehaviour
{

    public Checker checkerAboveMe;

    //private void OnEnable()
    //{
    //    MeshRenderer m = GetComponent<MeshRenderer>();
    //    if(m != null)
    //        m.enabled = false;
    //}


    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(gameObject.name + collision.gameObject.name);

        if(collision.gameObject.GetComponent<BottomCheck>() != null)
        {
            if (collision.gameObject.GetComponent<BottomCheck>().myChecker != null)
            {
                checkerAboveMe = collision.gameObject.GetComponent<BottomCheck>().myChecker;
            }
        }        
    }


    //private void OnTriggerExit(Collider other)
    //{
    //    checkerAboveMe = null;
    //}





    //on triger enter
    // aboveme== 
}
