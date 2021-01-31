using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public bool pickUpKey = false;
    public bool pickUpBook = false;
    public bool pickUpTorch = false;
    public bool pickUpPGem = false;
    public bool pickUpGGem = false;
    public bool pickUpYGem = false;
    public bool pickUpFlask = false;
    public bool pickUpBag = false;


    public void PlayerInteract()
    {

        // remember that the player has "picked up" the object
        if(pickUpKey == true)
            Inventory.main.hasKey = true;

        if (pickUpTorch == true)
            Inventory.main.hasTorch = true;

        if (pickUpBook == true)
            Inventory.main.hasBook = true;

        if (pickUpGGem == true)
            Inventory.main.hasGGem = true;

        if (pickUpYGem == true)
            Inventory.main.hasYGem = true;

        if (pickUpPGem == true)
            Inventory.main.hasPGem = true;

        if (pickUpFlask == true)
            Inventory.main.hasFlask = true;

        if (pickUpBag == true)
            Inventory.main.hasBag = true;


        Destroy(gameObject);

    }
}
