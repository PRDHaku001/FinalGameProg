using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Entity player;
    public AttackTrigger trigger;
    public int numberofAttack = 1;
    public int damage;
    public Menu menu;
    public trigger Triggernya;

    public Animator animator;

    public int radnumber;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject Bartrigger;

    public Defend defend; 

    public void Attack()
    {
        if(menu.phase == -1)
        if(menu.skill == 1)
        {
            damage = 7;
            Triggernya.speed = 5;
        }
        else
        {
            damage = 2;
            Triggernya.speed = 5;
        }
        if (Input.GetButtonDown("Attacking"))
        {
            if(menu.phase == -1)
            {

                {
                    radnumber = Random.Range(1, 3);
                    if (trigger.Critical == true)
                    {
                        player.HP -= damage*2;
                        animator.SetTrigger("Attacked");
                        if (radnumber == 1)
                        {
                            Triggernya.arah = 2;
                            Bartrigger.transform.position = spawn1.transform.position;
                        }
                        else
                        {
                            Triggernya.arah = 1;
                            Triggernya.transform.position = spawn2.transform.position;
                        }
                        numberofAttack -= 1;
                    }
                    else if(trigger.Attack == true)
                    {
                        player.HP -= damage;
                        animator.SetTrigger("Attacked");
                        if (radnumber == 1)
                        {
                            Triggernya.arah = 2;
                            Bartrigger.transform.position = spawn1.transform.position;
                        }
                        else
                        {
                            Triggernya.arah = 1;
                            Triggernya.transform.position = spawn2.transform.position;
                        }
                        numberofAttack -=1;
                    }
                    else if(trigger.Miss == true)
                    {
                        if (radnumber == 1)
                        {
                            Triggernya.arah = 2;
                            Bartrigger.transform.position = spawn1.transform.position;
                        }
                        else
                        {
                            Triggernya.arah = 1;
                            Triggernya.transform.position = spawn2.transform.position;
                        }
                        numberofAttack -= 1;
                    }
                }
            }
            
        }
    }

    private void Update()
    {
        Attack();
        if(numberofAttack <= 0 && menu.phase == -1)
        {
            trigger.phase = -1;
            defend.phase = 1;
            //defend.numberofdef = 2;
        }
    }
}
