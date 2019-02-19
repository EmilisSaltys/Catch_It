using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{

    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveRight();
        }
        

        if (Input.GetKeyDown(KeyCode.A))
        {
                MoveLeft();
        }
    }

   public void MoveRight()
    {
        rb.velocity = new Vector2(8, 0);
    }

   public void MoveLeft()
    {
        rb.velocity = new Vector2(-8, 0);
    }
}
