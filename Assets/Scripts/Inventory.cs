using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Singleton design pattern
    private static Inventory _main;

    public static Inventory main
    {
        get { return _main; }
        private set { _main = value; }
    }

    public bool hasKey = false;
    public bool hasBook = false;
    public bool hasTorch = false;
    public bool hasPGem = false;
    public bool hasGGem = false;
    public bool hasYGem = false;
    public bool hasFlask = false;
    public bool hasBag = false;

    private void Start()
    {
        if (main == null)
        {

            _main = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }

    }
}
