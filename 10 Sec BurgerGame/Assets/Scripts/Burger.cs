using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Ingredients { nothing, bottomBun, Patty, Lettuce, Cheese, tomato, onion, TopBun }
public class Burger : MonoBehaviour
{
    public string name;
    public List<Ingredients> ingredients = new List<Ingredients>();
}
