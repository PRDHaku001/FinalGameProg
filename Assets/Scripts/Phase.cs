using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase : MonoBehaviour
{
    // Start is called before the first frame update
    public AttackTrigger attacktrigger;
    public GameObject AttackBar;
    public Menu menu;
    public trigger trigger;
    void Update()
    {

        //AttackBar.transform.localScale = new Vector2(testnumber, 1);
        if (menu.phase == -1)
        {
            menu.AttackMenu.SetActive(false);
            if (menu.skill == 1)
            {
                AttackBar.SetActive(true);
                attacktrigger.AttackBar.transform.localScale = new Vector2(5, 1);
                attacktrigger.CriticalBar.transform.localScale = new Vector2(0, 0);
            }
            else if(menu.skill == 2)
            {
                AttackBar.SetActive(true);
                attacktrigger.AttackBar.transform.localScale = new Vector2(7, 1);
                attacktrigger.CriticalBar.transform.localScale = new Vector2(2, 1);
            }
        }
        if(attacktrigger.phase == -1)
        {
            AttackBar.SetActive(false);
            menu.ActionMenu.SetActive(true);
            menu.phase = 1;
            attacktrigger.phase = 1;
            menu.skill = 0;
            
        }

        if(Input.GetButtonDown("Fire3") && attacktrigger.phase == -1)
        {
            attacktrigger.phase = 1;
            trigger.jumpnumber = 3;
            AttackBar.SetActive(true);
        }
    }
}
