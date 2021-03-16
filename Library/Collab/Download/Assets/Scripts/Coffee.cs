
using UnityEngine;

public class Coffee : MonoBehaviour
{
    public GameObject Drink;
    public GameObject LiquidAnimator;
    public LiquidAnimation LiquidAnimation;
    public LiquidAnimation LiquidAnimation2;
    public LiquidAnimation LiquidAnimation3;
    public LiquidAnimation LiquidAnimation4;
    public LiquidAnimation LiquidAnimation5;
    public GameObject Line1;
    public GameObject Line2;
    public GameObject Line3;
    public GameObject Line4;
    public GameObject Line5;
    public GameObject CurrentLiquidLevel1;
    public GameObject CurrentLiquidLevel2;
    public GameObject CurrentLiquidLevel3;
    public GameObject CurrentLiquidLevel4;
    public GameObject CurrentLiquidLevel5;
    public GameObject Liquid1;
    public GameObject Liquid2;
    public GameObject Liquid3;
    public GameObject Liquid4;
    public GameObject Liquid5;
    public LiquidLevel liquidLevel;
    public int FingerDown1 = 0;
    public int FingerDown2 = 0;
    public int FingerDown3 = 0;
    public int FingerDown4 = 0;
    public int Liquid1Started = 0;
    public int Liquid2Started = 0;
    public int Liquid3Started = 0;
    public int Liquid4Started = 0;
    public int Positioning = 0;
    public int i = 0;
    public bool IsLiquid1 = false;
    public bool IsLiquid2 = false;
    public bool IsLiquid3 = false;
    public bool IsLiquid4 = false;
    public bool IsLiquid5 = false;
    public int DrinkQuantity = 0;

    public float CoffeeMaking = 0.03f;
    public ParticleSystem LiquidParticles;
    public void MakeActive()
    {
        Drink.SetActive(true);
    }
    public void Start()
    {
        CurrentLiquidLevel1.SetActive(false);
        CurrentLiquidLevel2.SetActive(false);
        Liquid1.SetActive(false);
        Liquid2.SetActive(false);
        Liquid3.SetActive(false);
        Liquid4.SetActive(false);
        Liquid5.SetActive(false);
        if (Liquid1)
        {
            IsLiquid1 = true;
            DrinkQuantity++;
        }
        if (Liquid2)
        {
            IsLiquid2 = true;
            DrinkQuantity++;
        }
        if (Liquid3)
        {
            IsLiquid3 = true;
            DrinkQuantity++;
        }
        if (Liquid4)
        {
            IsLiquid4 = true;
            DrinkQuantity++;
        }
        if (Liquid5)
        {
            IsLiquid5 = true;
            DrinkQuantity++;
        }
    }
    public void MakeActive(GameObject x)
    {
        x.SetActive(true);
    }
    public void PouringLiquid(GameObject x, int i)
    {
        //var k = x.transform.position;
        //k.y += x.transform.localScale.y;
        //x.transform.position = k;
        //if (i == 0)
        //{


        //    LiquidAnimation.ActivateAnimation();
        //}
        //if (i == 1)
        //{


        //    LiquidAnimation2.ActivateAnimation();
        //}
        //if (i == 2)
        //{


        //    LiquidAnimation3.ActivateAnimation();
        //}
        //if (i == 3)
        //{


        //    LiquidAnimation4.ActivateAnimation();
        //}
        x.transform.localScale += new Vector3(0.0f, CoffeeMaking, 0.0f);
        LiquidParticles.Emit(10);
    }
    public void LiquidPosition(GameObject x, GameObject y)
    {
        var k = y.transform.position;
        k.y += y.transform.localScale.y;
        k.y += 0.05f;
        x.transform.position = k;
    }
    public void FixedUpdate()
    {
        if (Input.GetMouseButton(0) && i == 0 && FingerDown1 == 0 && IsLiquid1 == true)
        {
            Liquid1Started = 1;
            var x = Liquid1;
            MakeActive(x);
            PouringLiquid(x , 0);
            CurrentLiquidLevel1.SetActive(true);
            var liquidMaterial = Liquid1.GetComponentInChildren<Renderer>().material;
            var liquidParticlesMain = LiquidParticles.main;
            liquidParticlesMain.startColor = new ParticleSystem.MinMaxGradient(liquidMaterial.color);

        }
        if (Liquid1Started == 1 && !Input.GetMouseButton(0))
        {
            FingerDown1 = 1;
            LiquidAnimation.DeactivateAnimation();
            //liquidLevel.DisableLiquidLevel(CurrentLiquidLevel1);
            // здесь будем убирать линию
        }
        if (FingerDown1 == 1)
        {
            i = 1;
        }
        if (Input.GetMouseButton(0) && i == 1 && FingerDown2 == 0 && IsLiquid2 == true)
        {
            LiquidPosition(Liquid2, Liquid1);
            Liquid2Started = 1;
            MakeActive(Liquid2);
            PouringLiquid(Liquid2, 1);
            CurrentLiquidLevel2.SetActive(true);
            var liquidMaterial = Liquid2.GetComponentInChildren<Renderer>().material;
            var liquidParticlesMain = LiquidParticles.main;
            liquidParticlesMain.startColor = new ParticleSystem.MinMaxGradient(liquidMaterial.color);

        }
        if (Liquid2Started == 1 && !Input.GetMouseButton(0))
        {
            FingerDown2 = 1;
            LiquidAnimation2.DeactivateAnimation();
            //liquidLevel.DisableLiquidLevel(CurrentLiquidLevel2);
            // здесь будем убирать линию
        }
        if (FingerDown2 == 1)
        {
            i = 2;
        }
        if (Input.GetMouseButton(0) && i == 2 && FingerDown3 == 0 && IsLiquid3 == true)
        {
            LiquidPosition(Liquid3, Liquid2);
            Liquid3Started = 1;
            MakeActive(Liquid3);
            PouringLiquid(Liquid3, 2);

        }
        if (Liquid3Started == 1 && !Input.GetMouseButton(0))
        {
            FingerDown3 = 1;
            LiquidAnimation3.DeactivateAnimation();
            // здесь будем убирать линию
        }
        if (FingerDown3 == 1)
        {
            i = 3;
        }
        if (Input.GetMouseButton(0) && i == 3 && FingerDown4 == 0 && IsLiquid4 == true)
        {
            LiquidPosition(Liquid4, Liquid3);
            Liquid4Started = 1;
            MakeActive(Liquid4);
            PouringLiquid(Liquid4, 3);

        }
        if (Liquid4Started == 1 && !Input.GetMouseButton(0))
        {
            FingerDown4 = 1;
            LiquidAnimation4.DeactivateAnimation();
            // здесь будем убирать линию
        }
        if (FingerDown4 == 1)
        {
            i = 4;
        }
    }
}
