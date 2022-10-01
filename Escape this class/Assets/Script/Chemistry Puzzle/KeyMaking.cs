using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMaking : MonoBehaviour
{
    public GameObject LiquidKey;
    public GameObject doorKey;
    public Animator Keyforming;
    public GameObject MoldNonCollider;
    public GameObject MoldCollider;

    private void OnParticleCollision(GameObject collision)
    {
        if (collision.tag == "LiquidMetal")
        {
            //keyforming
            LiquidKey.SetActive(true);
            Keyforming.SetTrigger("KeyForming");
            StartCoroutine(KeyformingCountdown());
        }
    }

    IEnumerator KeyformingCountdown()
    {
        yield return new WaitForSeconds(5f);
        MoldCollider.SetActive(false);
        MoldNonCollider.SetActive(true);
        doorKey.SetActive(true);
        LiquidKey?.SetActive(false);
    }
}
