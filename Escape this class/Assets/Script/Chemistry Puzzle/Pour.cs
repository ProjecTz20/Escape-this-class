using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pour : MonoBehaviour
{

    public ParticleSystem pourParticle;
    public bool isPlaying = false;

    void Start()
    {
        pourParticle = GetComponent<ParticleSystem>();
        pourParticle.Play();
    }

    void Update()
    {
        if (Vector3.Angle(Vector3.down, transform.forward) <= 90f && isPlaying == false)
        {
            pourParticle.Play();
            isPlaying = true;
        }
        else if (Vector3.Angle(Vector3.down, transform.forward) >= 90f)
        {
            pourParticle.Stop();
            isPlaying = false;
        }
    }
}
