using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubstanceScript : MonoBehaviour
{

    private void Start()
    {
        print("amounttester");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "AmountTester")
        {
            
            if (gameObject.tag == "Zinc")
            {
                AmountColliderCheck.ZincAmount += 1;
                print("zincamount +1");
                print("total zinc " + AmountColliderCheck.ZincAmount);
            }

            else if (gameObject.tag == "Copper")
            {
                AmountColliderCheck.CopperAmount += 1;
                print("copperamount +1");
                print("total Copper " + AmountColliderCheck.CopperAmount);
            }
            AmountColliderCheck.IteminContainer.Add(gameObject);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "AmountTester")
        {
            if (gameObject.tag == "Zinc")
            {
                AmountColliderCheck.ZincAmount -= 1;
                print("zincamount -1");
                print("total zinc " + AmountColliderCheck.ZincAmount);
            }

            else if (gameObject.tag == "Copper")
            {
                AmountColliderCheck.CopperAmount -= 1;
                print("copperamount -1");
                print("total Copper " + AmountColliderCheck.CopperAmount);
            }
        }
        AmountColliderCheck.IteminContainer.Remove(gameObject);
    }
}
