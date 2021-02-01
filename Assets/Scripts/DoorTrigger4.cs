using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger4 : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    bool isOpened;

    private void OnTriggerEnter(Collider col)
    {
        if (isOpened == false)
        {
            isOpened = true;
            door.transform.position += new Vector3(0, -10, 0);
        }

    }

}
