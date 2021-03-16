using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Video;

public class CoffeeWithMilk : Coffee
{
    public GameObject Star;
    public float y = 0;
    public float Score = 0;
    public float Score2 = 0;
    new private int i = 0;
    public LiquidLevel LiquidLevel;
    public LiquidLevel LiquidLevel2;
    new void Start()
    { 
        if (IsLiquid1 == true && IsLiquid2!= true)
        {
            Line1.SetActive(true);
            Line1.transform.Translate(0, 2.0f, 0);

        }
        if (IsLiquid2 == true)
        {
            Line1.SetActive(true);
            Line2.SetActive(true);
            Line2.transform.Translate(0, 2.0f, 0);

        }
    }
    private void Update()
    {
        if (FingerDown1==1)
        {
            y = CurrentLiquidLevel1.transform.position.y;
            Score = (1 / (-0.13f - y));
            if (Score < 0)
            {
                Score = -Score;
            }
            if (i == 0)
            {
                Star.transform.localScale += new Vector3(Score*7, 0.0f, Score*7);
                i = 1;
            }
        }
        if (FingerDown2 == 1)
        {
            y = CurrentLiquidLevel2.transform.position.y;
            Score2 = (1 / (1.87f - y));
            if (Score2 < 0)
            {
                Score2 = -Score2;
                //Debug.Log(Score2);
            }
            if (i == 1)
            {
                Star.transform.localScale += new Vector3(Score2*10, 0.0f, Score2*10 );
                i = 2;
            }
        }
        if (FingerDown2 == 1)
        {
            //Debug.Log(Score + Score2);
            //var a = Score + Score2;
            //Star.transform.localScale = Vector3(a, a, a);
            //Star.SetActive(true);
            //var a = Star.transform.localScale;
            //Star.transform.localScale += a * (Score + Score2);
            //Time.timeScale = 0;
        }
    }
}
