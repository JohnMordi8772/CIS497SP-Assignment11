/* 
 * John Mordi 
 * SquadUnit.cs
 * Assignment 11
 * Manages the scale of units with multiple character models.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadUnit : MonoBehaviour
{
    public float scale = 2;

    private void Start()
    {
        gameObject.transform.localScale = new Vector3(scale, scale, scale);
    }

    public void ScaleUp()
    {
        if (scale < 3)
        {
            scale = scale + 0.5f;
            gameObject.transform.localScale = new Vector3(scale, scale, scale);
        }
    }

    public void ScaleDown()
    {
        if (scale > 1)
        {
            scale = scale - 0.5f;
            gameObject.transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}
