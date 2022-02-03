using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSwitchScene : MonoBehaviour{

    public float time = 0;

    void FixedUpdate(){
        if(PlayButton.played){
            time += Time.deltaTime;
            if(time >= 51f){
                Application.LoadLevel("Island");
            }
        }
    }
}
