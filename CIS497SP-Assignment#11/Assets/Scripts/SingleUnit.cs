/* 
 * John Mordi 
 * SingleUnit.cs
 * Assignment 11
 * Manages the scale of units with only one character model
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleUnit : MonoBehaviour
{
    public float scale = 3;

    private void Start()
    {
        gameObject.transform.localScale = new Vector3(scale, scale, scale);
    }

    public void ScaleUp()
    {
        if (scale < 5)
        {
            scale++;
            gameObject.transform.localScale = new Vector3(scale, scale, scale);
        }
    }

    public void ScaleDown()
    {
        if (scale > 1)
        {
            scale--;
            gameObject.transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}
