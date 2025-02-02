using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class collectingbananas : MonoBehaviour
{
    private bool isCollected = false;
    public bool Collect()
    {
        Debug.Log("Collect method called.");
        if (isCollected)
        {
            ScorePoints.scoreValue +=10;
            Debug.Log("Already collected.");
            return false;
        }
        isCollected = true;
        Debug.Log("Collectible successfully collected!");
        Destroy(gameObject);
        return true;
    }
}

