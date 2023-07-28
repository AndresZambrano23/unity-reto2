using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public bool isLeft = false;
    public bool isRigth = false;
    public bool isJump = false;
    public bool canJump = true;
    

    public Rigidbody2D rb;
    public float jumpForce = 1000;
    public float speedForce = 2000;
    public float waitJump = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isLeft || Input.GetKey("left"))
        {
            rb.AddForce(new Vector2(-speedForce, 0) * Time.deltaTime);
        }

        if (isRigth || Input.GetKey("right"))
        {
            rb.AddForce(new Vector2(speedForce, 0) * Time.deltaTime);
        }

        if ((isJump || Input.GetKey(KeyCode.UpArrow))&& canJump)
        {
            isJump = false;
            rb.AddForce(new Vector2(0, jumpForce));
            canJump = false;
            Invoke("waitToJump",waitJump);
        }

    }

    public void clickLeft()
    {
        isLeft = true;
    }

    public void clickjump()
    {
        isJump = true;
    }

    public void clickRigth()
    {
        isRigth = true;
    }

    public void resetMov()
    {
        isLeft = false;
        isRigth = false;
    }

    public void waitToJump() 
    {
        canJump = true;
    }
}
