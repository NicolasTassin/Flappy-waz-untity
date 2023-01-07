using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public float rotationAngle;
    public logicScript logic;
    public SpriteRenderer spriteR;
    public bool birdIsAlive = true;



    // Start is called before the first frame update
    void Start()
    {
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    spriteR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    if( Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
        // myRigidbody.rotation = Vector2 * rotationAngle;
        myRigidbody.velocity = Vector2.up * flapStrength;
        //Debug.Log("sprites" + spriteR);
        spriteR.sprite = Resources.Load<Sprite>("flap2");
    }
    if(transform.position.y < -18)
        {
        
        logic.gameOver();
    }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        logic.gameOver();    
        birdIsAlive =false;
    }

    
}
