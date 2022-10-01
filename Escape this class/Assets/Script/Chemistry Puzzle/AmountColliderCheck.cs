using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmountColliderCheck : MonoBehaviour
{
    //this script will attach with substance container
    public static double ZincAmount;
    public static double CopperAmount;
    public bool InsideFurnace = false;
    public bool StartMelting = false;
    public static List<GameObject> IteminContainer = new List<GameObject>();

    //melted
    public GameObject LiquidMetal;
    public GameObject PourParticle;

    //percentage
    public double ZincPercentage;
    public double CopperPercentage;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ContainerTester")
        {
            InsideFurnace = true;

        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "ContainerTester")
        {
            InsideFurnace = false;
        }
    }

    public void Update()
    {
        ZincPercentage = (ZincAmount / (ZincAmount + CopperAmount)) * 100;
        CopperPercentage = (CopperAmount / (ZincAmount + CopperAmount)) * 100;
        if (ZincPercentage <= 40 && CopperPercentage >= 60 && InsideFurnace && !StartMelting)
        {
            StartCoroutine(MeltingIEnu());
        }
    }

    public void MeltingReaction()
    {
        if (!StartMelting && InsideFurnace)
        {
            StartMelting = true;
            //Start chemical Reaction

            //destroy all substance in pot
            foreach(GameObject substance in IteminContainer)
            {
                Destroy(substance);
            }

            //SubstanceMelted
            LiquidMetal.SetActive(true);
            PourParticle.SetActive(true);
        }
    }

    IEnumerator MeltingIEnu()
    {
        yield return new WaitForSeconds(5);
        MeltingReaction();
    }

}
