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
    public void Attack()
    {
        if(menu.skill == 1)
        {
            damage = 7;
            Triggernya.speed = 7;
        }
        else
        {
            damage = 2;
            Triggernya.speed = 9;
        }
        if (Input.GetButtonDown("Attacking"))
        {
            if (trigger.Critical == true)
            {
                player.HP -= damage*2;
                numberofAttack -= 1;
                Debug.Log(player.HP);
            }
            else if(trigger.Attack == true)
            {
                player.HP -= damage;
                numberofAttack -=1;
                Debug.Log(player.HP);
            }
        }
    }

    private void Update()
    {
        Attack();
        if(numberofAttack == 0)
        {
            trigger.phase = -1;

        }
    }
}
