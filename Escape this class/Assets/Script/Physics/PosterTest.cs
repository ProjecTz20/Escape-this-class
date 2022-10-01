using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PosterTest : MonoBehaviour
{
    void OnCollisionExit(Collision wall)
    {
        if (wall.gameObject.name == "WallTester")
        {
            Destroy(this.gameObject);
            print("destroyed");
        }
        
    }
}
