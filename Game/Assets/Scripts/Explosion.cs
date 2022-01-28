using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float delay = 3f;

    public GameObject explosionEffect;
    public GameObject flame;

    float countdown;
    bool hasExploded = false;


    void Start()
    {
        countdown = delay;
    }

    void OnTriggerStay()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    void OnTriggerExit()
    {
        countdown = delay;
        hasExploded = false;
    }

    void Explode()
    {
        GameObject exp1 = Instantiate(explosionEffect, transform.position, transform.rotation);

        Destroy(gameObject);
        Destroy(exp1, 1.5f);
        GameObject flameObject = Instantiate(flame, transform.position, transform.rotation);
    }
}