using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CloudMovement : MonoBehaviour
{
    public Rigidbody rb;
    private float time = 0.0f;
    public PlayerCube cube;
    public AudioSource audioData;
    private bool collision = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        time = time + Time.fixedDeltaTime;
        int t = ((int)time) % 60;
        t = t / 10;

        if(t == 0 || t == 1){
            rb.velocity = new Vector3(1, 0, 0);
        }else if(t == 2){
            rb.velocity = new Vector3(0, 0, 1);
        }else if(t == 3 || t == 4){
            rb.velocity = new Vector3(-1, 0, 0);
        }else if(t == 5){
            rb.velocity = new Vector3(0, 0, -1);
        }
        if(Math.Abs(cube.transform.position.x-transform.position.x) < 5.5f && Math.Abs(cube.transform.position.z-transform.position.z)<5.5f){
            if(!collision){
                audioData.Play(0);
            }
            collision=true;
            HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - 0.001f);
        }
        else{
            collision=false;
            audioData.Stop();
        }
    }
}
