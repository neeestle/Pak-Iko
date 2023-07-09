using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour

{
    bool Boost;
    private float timerboost = 5.0f;
    private float timer = 0.0f;
    [SerializeField] float steerSpeed = 2f;
    [SerializeField] float MoveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 100f;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
        if (Boost)
        {
           
            timer += Time.deltaTime;
            if (timer > timerboost)
            {
                Boost = false;  
                timer = 0.0f;
                MoveSpeed = 70.0f;
            }
        } 
    }
    void OnCollisionTrigger2D(Collision2D other)
    {
       
        MoveSpeed = slowSpeed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            Boost = true;
            MoveSpeed = boostSpeed;
            Destroy(other.gameObject, 0.5f);
        }
    }

}

