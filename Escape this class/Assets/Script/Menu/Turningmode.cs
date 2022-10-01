using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turningmode : MonoBehaviour
{
    public bool snapTurn = false;
    public bool smoothTurn = true;
    public GameObject _snapTurn;
    public GameObject _smoothTurn;

    public void SnapTurn()
    {
        if(!snapTurn || smoothTurn)
        {
            snapTurn = true;
            smoothTurn = false;

             _snapTurn.SetActive(true);
            _smoothTurn.SetActive(false);
        }
    }

    public void SmoothTurn()
    {
        if (snapTurn || !smoothTurn)
        {
            snapTurn = false;
            smoothTurn = true;

            _snapTurn.SetActive(false);
            _smoothTurn.SetActive(true);
        }
    }
}
