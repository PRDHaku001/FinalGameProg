using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static PlayerAttack;

public class trigger : MonoBehaviour
{
    public Transform platform;
    public Transform startPoint;
    public Transform endPoint;
    public float speed = 2;
    public int direction = 1;
    public int arah = 2;
    public float jumpnumber = 3;

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "kiri")
        {
            if(jumpnumber <= 0)
            {
                speed = 0;
            }
            else
            {
                arah = 2;
            }
            jumpnumber =jumpnumber -1f;
        }

        if (collision.gameObject.name == "kanan")
        {
            if (jumpnumber <= 0)
            {
                speed = 0;
            }
            else
            {
                arah = 1;
            }
            jumpnumber = jumpnumber -1f;
        }
    }
    private void Update()
    {
        
    }

    
}
