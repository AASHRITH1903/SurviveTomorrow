using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDetectionScript : MonoBehaviour
{

    private bool collision=false;
    
    void Start()
    {

    }

    void Update()
    {
        // if(!collision){
        //     audioData.Stop();
        // }
        // collision=false;
        // if(clouds.transform.position)
    }

    void OnParticleCollision(GameObject other){
        //HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - 0.01f);
        if(!collision){
            // audioData.Play(0);
        }
        collision=true;
    }

    // void OnParticleCollisionEnd(){
        // audioData.Stop();
    // }
}
