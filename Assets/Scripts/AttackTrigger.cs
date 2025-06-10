using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using static trigger;

public class AttackTrigger : MonoBehaviour
{
    public Vector2 scalechange, positionchange;
    public bool Critical;
    public bool Attack;
    public bool Miss;
    public trigger trigger;
    public PlayerAttack PlayerAttack;
    public Menu menu;
    public GameObject AttackBar;
    public GameObject CriticalBar;
    public GameObject Trigger;
    public int testnumber = 5;
    public int phase = 1;

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    //balik arah
    //    if (collision.gameObject.name == "kiri")
    //    {
    //        trigger.arah = 2;
    //    }
    //    if (collision.gameObject.name == "kanan")
    //    {
    //        trigger.arah = 1;
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(menu.phase == -1)
        {
            if (collision.gameObject.name == "Critical")
            {
                Critical = true;
            }
            if (collision.gameObject.name == "Attack" && collision.gameObject.name != "Critical")
            {
                Attack = true;
            }
            if(collision.gameObject.name == "Miss" && collision.gameObject.name != "Attack" && collision.gameObject.name != "Critical")
            {
                Miss = true;
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Critical")
        {
            Critical = false;
        }

        if (collision.gameObject.name == "Attack")
        {
            Attack = false;
        }

    }

    //private void OnEnable()
    //{
    //    if (trigger.arah == 1)
    //    {
    //        Vector2 target = LeftToRight();
    //        trigger.platform.position = Vector2.MoveTowards(trigger.platform.position, target, trigger.speed * Time.deltaTime);
    //    }
    //    else if (trigger.arah == 2)
    //    {
    //        Vector2 target = RightToLeft();
    //        trigger.platform.position = Vector2.MoveTowards(trigger.platform.position, target, trigger.speed * Time.deltaTime);
    //    }
    //}

    private void Update()
    {
        //changesize
        //AttackBar.transform.localScale = new Vector2(testnumber, 1);
        //if(trigger.jumpnumber == 0)
        //{
        //    phase = -1;
        //}

        if (trigger.arah == 1)
        {
            Vector2 target = LeftToRight();
            trigger.platform.position = Vector2.MoveTowards(trigger.platform.position, target, trigger.speed * Time.deltaTime);
        }
        else if (trigger.arah == 2)
        {
            Vector2 target = RightToLeft();
            trigger.platform.position = Vector2.MoveTowards(trigger.platform.position, target, trigger.speed * Time.deltaTime);
        }
    }

    Vector2 LeftToRight()
    {
        //LeftToRight
        if (trigger.direction == 1)
        {
            return trigger.startPoint.position;
        }
        else
        {
            return trigger.endPoint.position;
        }
    }

    Vector2 RightToLeft()
    {
        //RightToLeft
        if (trigger.direction == 1)
        {
            return trigger.endPoint.position;
        }
        else
        {
            return trigger.startPoint.position;
        }
    }


}
