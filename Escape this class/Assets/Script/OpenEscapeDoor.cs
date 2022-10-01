using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEscapeDoor : MonoBehaviour
{
    public GameObject MoldedKey;
    public GameObject KeyAtDoor;
    public Animator KeyinsertAnimation;
    public Animator DooropenAnimation;

    public AudioSource DoorOpenSFX;
    public void KeyInserted()
    {
        StartCoroutine(DoorOpen());
    }

    IEnumerator DoorOpen()
    {
        MoldedKey.SetActive(false);
        KeyAtDoor.SetActive(true);
        KeyinsertAnimation.SetTrigger("KeyInsert");
        yield return new WaitForSeconds(1.2f);
        DooropenAnimation.SetTrigger("DoorOpened");
        DoorOpenSFX.Play();
    }
}
