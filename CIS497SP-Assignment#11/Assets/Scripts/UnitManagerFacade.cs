/* 
 * John Mordi 
 * UnitManagerFacade.cs
 * Assignment 11
 * Brings multiple classes together to organize their method calls into similar categories
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnitManagerFacade : MonoBehaviour
{
    public SingleUnit single;
    public SquadUnit squad;
    public Text text;
    ScalingText scalingText;

    // Start is called before the first frame update
    void Start()
    {
        scalingText = new ScalingText(single, squad);
        scalingText.UpdateText(text);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            IncreaseSize();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            DecreaseSize();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void IncreaseSize()
    {
        single.ScaleUp();
        squad.ScaleUp();
        scalingText.UpdateText(text);
    }

    public void DecreaseSize()
    {
        single.ScaleDown();
        squad.ScaleDown();
        scalingText.UpdateText(text);
    }
}
