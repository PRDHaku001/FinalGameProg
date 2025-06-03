using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Player player;
    public AttackTrigger trigger;
    public int numberofAttack = 1;
    public void Attack()
    {
        if (Input.GetButtonDown("Attacking"))
        {
            if (trigger.Critical == true)
            {
                player.HP -= 5;
                numberofAttack -= 1;
                Debug.Log(numberofAttack);
            }
            else if(trigger.Attack == true)
            {
                player.HP -= 3;
                numberofAttack -=1;
                Debug.Log(numberofAttack);
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
