using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefendTrigger : MonoBehaviour
{
    public Transform platform;
    public Transform startPoint;
    public Transform endPoint;

    public float speed = 2;
    public int arah = 2;
    public int radnumber;
    public int direction = 1;

    public Defend defend;

    public GameObject trigger;
    public GameObject spawn1;
    public GameObject spawn2;
    public Animator animator;
    public Entity Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        radnumber = Random.Range(1, 3);
        if (collision.gameObject.name == "kirideff")
        {
            animator.SetTrigger("Attack");
            Player.HP -= 5;
            defend.numberofdef = 0;
            if (radnumber == 1)
            {
                arah = 2;
                trigger.transform.position = spawn1.transform.position;
            }
            else
            {
                arah = 1;
                trigger.transform.position = spawn2.transform.position;

            }
        }
        else if(collision.gameObject.name == "kanandeff")
        {
            Player.HP -= 5;
            animator.SetTrigger("Attack");
            defend.numberofdef = 0;
            if (radnumber == 1)
            {
                arah = 2;
                trigger.transform.position = spawn1.transform.position;
            }
            else
            {
                arah = 1;
                trigger.transform.position = spawn2.transform.position;
            }
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
