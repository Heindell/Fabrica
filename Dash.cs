using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private float dashInterval = 0.3f;
    private float nextDash;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        {
            if(dashTime <= 0){
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            }
            else if(Input.GetKeyDown(KeyCode.Tab)){
                if(Input.GetKey(KeyCode.LeftArrow)){
                    if(Time.time > nextDash){
                    rb.velocity = Vector2.left * dashSpeed;
                    nextDash = Time.time + dashInterval;
                }}
                else if(Input.GetKey(KeyCode.RightArrow)){
                    if(Time.time > nextDash){
                    rb.velocity = Vector2.right * dashSpeed;
                    nextDash = Time.time + dashInterval;
                }}
                
            }
        }
    }
}
