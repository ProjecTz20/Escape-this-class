using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardClone : MonoBehaviour
{

    public GameObject Board;
    public GameObject oldBoard;

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnBoard()
    {
        Destroy(oldBoard);
        Instantiate(Board, transform.position,Quaternion.identity);
    }
}
