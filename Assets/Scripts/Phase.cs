//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Phase : MonoBehaviour
{
    // Start is called before the first frame update
    public AttackTrigger attacktrigger;
    public GameObject AttackBar;
    public GameObject DeffBar;
    public Menu menu;
    public trigger trigger;
    public DefendTrigger defendtrigger;
    public PlayerAttack playerattack;
    public Defend defend;
    public int readydef;

    public int radnumber;
    public Entity player;
    public Entity enemy;


    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject Bartrigger;
    public int startdef = 1;


    void Update()
    {
        if(player.HP <= 0 || enemy.HP <= 0)
        {
            string Endgame = "MainMenu";
            SceneManager.LoadScene(Endgame);
        }
        //AttackBar.transform.localScale = new Vector2(testnumber, 1);
        if (menu.phase == -1)
        {
            menu.AttackMenu.SetActive(false);
            if (menu.skill == 1)
            {
                AttackBar.SetActive(true);
                attacktrigger.AttackBar.transform.localScale = new Vector2(2, 1);
                attacktrigger.CriticalBar.transform.localScale = new Vector2(0, 0);
            }
            else if(menu.skill == 2)
            {
                AttackBar.SetActive(true);
                attacktrigger.AttackBar.transform.localScale = new Vector2(3, 1);
                attacktrigger.CriticalBar.transform.localScale = new Vector2(0.5f, 1);
            }
        }

        if(defend.phase == 1 && menu.phase == -1)
        {
            AttackBar.SetActive(false);
            if(startdef == 1)
            {
                radnumber = Random.Range(1, 3);
                if (radnumber == 1)
                {
                    defendtrigger.arah = 2;
                    Bartrigger.transform.position = spawn1.transform.position;
                    startdef = 0;
                }
                else
                {
                    defendtrigger.arah = 1;
                    Bartrigger.transform.position = spawn2.transform.position;
                    startdef = 0;
                }
            }
            DeffBar.SetActive(true);
            attacktrigger.phase = 0;
            defend.numberofdef = 1;

        }

        if(attacktrigger.phase == -1 && menu.phase == 1 && defend.phase == 0)
        {
            AttackBar.SetActive(false);
            DeffBar.SetActive(false);
            menu.ActionMenu.SetActive(true);
            attacktrigger.phase = 0;
            menu.skill = 0;
            menu.Nactionmenu = 1;
            menu.Nattack = 1;
            startdef = 1;
        }
    }
}
