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

    public PlayerAttack playerattack;
    public int radnumber;
    public GameObject Triggernya;
    public GameObject spawn1;
    public GameObject spawn2;

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        radnumber = Random.Range(1, 3);
        if (collision.gameObject.name == "kiri")
        {
            if (radnumber == 1)
            {
                arah = 2;
                Triggernya.transform.position = spawn1.transform.position;
                playerattack.numberofAttack -= 1;
            }
            else
            {
                arah = 1;
                Triggernya.transform.position = spawn2.transform.position;
                playerattack.numberofAttack -= 1;
            }

            //if(jumpnumber <= 0)
            //{
            //    speed = 0;
            //}
            //else
            //{
            //    arah = 2;
            //}
            //jumpnumber =jumpnumber -1f;
        }

        if (collision.gameObject.name == "kanan")
        {
            if (radnumber == 1)
            {
                arah = 2;
                Triggernya.transform.position = spawn1.transform.position;
                playerattack.numberofAttack -= 1;
            }
            else
            {
                arah = 1;
                Triggernya.transform.position = spawn2.transform.position;
                playerattack.numberofAttack -= 1;
            }
            //if (jumpnumber <= 0)
            //{
            //    speed = 0;
            //}
            //else
            //{
            //    arah = 1;
            //}
            //jumpnumber = jumpnumber -1f;
        }
    }
    private void Update()
    {
        
    }

    
}
