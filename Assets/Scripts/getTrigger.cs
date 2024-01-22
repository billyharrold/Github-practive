using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getTrigger : MonoBehaviour
{
    public int Score;
    private void Start()
    {
        Score = 3;
        Debug.Log(Score);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger: " + other.gameObject.name);
        Score += 1;
        Debug.Log(Score);

    }
}
