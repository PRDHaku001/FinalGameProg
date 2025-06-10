using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefend : MonoBehaviour
{
    
    public int damage;
    
    public Entity Player;
    public Menu menu;
    public DefendTrigger trigger;
    public Defend deff;

    public int radnumber;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject Bartrigger;
    
    public Animator animator;

    public void Defend()
    {
        if(deff.phase == 1)
        {
            damage = 2;
            if (Input.GetButtonDown("Attacking"))
            {
                animator.SetTrigger("Attack");
                radnumber = Random.Range(1, 3);
                if(deff.evade == true)
                {
                    if (radnumber == 1)
                    {
                        trigger.arah = 2;
                        Bartrigger.transform.position = spawn1.transform.position;
                    }
                    else
                    {
                        trigger.arah = 1;
                        Bartrigger.transform.position = spawn2.transform.position;
                    }
                    deff.numberofdef -= 1;
                }
                else if (deff.guard == true)
                {
                    Player.HP -= damage;
                    if (radnumber == 1)
                    {
                        trigger.arah = 2;
                        Bartrigger.transform.position = spawn1.transform.position;
                    }
                    else
                    {
                        trigger.arah = 1;
                        Bartrigger.transform.position = spawn2.transform.position;
                    }
                    deff.numberofdef -= 1;
                }
                else if(deff.miss == true)
                {
                    Player.HP -= damage * 2;
                    if (radnumber == 1)
                    {
                        trigger.arah = 2;
                        Bartrigger.transform.position = spawn1.transform.position;
                    }
                    else
                    {
                        trigger.arah = 1;
                        Bartrigger.transform.position = spawn2.transform.position;
                    }
                    deff.numberofdef -= 1;

                }
                Debug.Log(Player.HP);
                deff.numberofdef -= 1;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Defend();
        if(deff.numberofdef <= 0 && deff.phase == 1)
        {
            deff.phase = 0;
            menu.phase = 1;
        }
    }
}
