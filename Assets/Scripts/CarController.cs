using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CarController : MonoBehaviour

{
    bool Boost;
    private float timerboost = 5.0f;
    private float timer = 0.0f;
    [SerializeField] float steerSpeed = 2f;
    [SerializeField] float MoveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 100f;

    public FixedJoystick Joystick;
    Rigidbody2D rb;
    Vector2 move;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {

        move.x = Joystick.Horizontal;
        move.y = Joystick.Vertical;

        float hAxis = move.x;
        float vAxis = move.y;
        float zAxis = Mathf.Atan2(hAxis, vAxis) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0f, 0f, -zAxis);
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
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * MoveSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            Debug.Log("gacor");
            Boost = true;
            MoveSpeed = boostSpeed;
            Destroy(other.gameObject, 0.5f);
        }
    }
}