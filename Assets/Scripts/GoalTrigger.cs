using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameObject userInterface;
    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "Finish") {
            userInterface.SetActive(true);
        }
    }
}
