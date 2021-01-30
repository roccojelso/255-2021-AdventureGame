using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInventoryGUI : MonoBehaviour
{

    public Transform imgKey;
    public Transform imgBook;
    public Transform imgTorch;
    public Transform imgPGem;
    public Transform imgGGem;
    public Transform imgYGem;

    // Update is called once per frame
    void Update()
    {
        imgKey.gameObject.SetActive(Inventory.main.hasKey);
        imgBook.gameObject.SetActive(Inventory.main.hasBook);
        imgTorch.gameObject.SetActive(Inventory.main.hasTorch);
        imgPGem.gameObject.SetActive(Inventory.main.hasPGem);
        imgGGem.gameObject.SetActive(Inventory.main.hasGGem);
        imgYGem.gameObject.SetActive(Inventory.main.hasYGem);
    }
}
