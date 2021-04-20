/* 
 * John Mordi 
 * ScalingText.cs
 * Assignment 11
 * Manages text adjustment based statistics from other classes
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScalingText : MonoBehaviour
{
    public SingleUnit single;
    public SquadUnit squad;

    public ScalingText(SingleUnit single, SquadUnit squad)
    {
        this.single = single;
        this.squad = squad;
    }

    public void UpdateText(Text text)
    {
        text.text = "Single: " + single.scale + "x original size\nSquad: " + squad.scale + "x original size";
    }
}
