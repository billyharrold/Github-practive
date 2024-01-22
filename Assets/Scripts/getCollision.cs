using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "w")
        {
            Debug.Log("It's a hit");
        }
    }
}
