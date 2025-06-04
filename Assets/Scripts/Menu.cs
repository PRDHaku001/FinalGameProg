using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject ActionMenu;public int Nactionmenu = 0;
    public GameObject AttackMenu;public int Nattackmenu = 0;
    public GameObject BagMenu;public int Nbagmenu = 0;
    public GameObject Attack;public int Nattack = 0;
    public GameObject ShadowAttack;
    public GameObject Bag;public int Nbag=0;
    public GameObject ShadowBag;
    public GameObject Run;public int Nrun=0;
    public GameObject ShadowRun;
    public GameObject BackAttack;public int Nbackattack = 0;
    public GameObject Shadowbackattack;
    public GameObject Skill1;public int Nskill1 = 0;
    public GameObject Skill2;public int Nskill2 = 0;
    public GameObject Skill3;public int Nskill3 = 0; 
    public GameObject Skill4;public int Nskill4 = 0;
    public GameObject ShadowSkill1;
    public GameObject ShadowSkill2;
    public GameObject ShadowSkill3;
    public GameObject ShadowSkill4;
    public GameObject DescSkill1;
    public GameObject DescSkill2;
    public GameObject BackBag;public int Nbackbag = 0;
    public GameObject Shadowbackbag;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject Triggernya;


    public PlayerAttack playerattack;
    public trigger trigger;
    
    public int phase = 1;
    public int skill = 0;
    public int radnumber;
    // Update is called once per frame
    private void Start()
    {
        ActionMenu.SetActive(true);
        Nactionmenu = 1;
        Nattack = 1;
        ShadowAttack.SetActive(true);
        ShadowBag.SetActive(false);
        ShadowRun.SetActive(false);
    }

    public void MenuDown()
    {
        if (Input.GetButtonDown("Down"))
        {
            if (Nactionmenu == 1)
            {
                if (Nattack == 1)
                {
                    ShadowBag.SetActive(true);
                    Nbag = 1;
                    ShadowAttack.SetActive(false);
                    Nattack = 0;
                }
            }
            else if (Nattackmenu == 1)
            {
                if(Nskill1 == 1)
                {
                    ShadowSkill2.SetActive(true);
                    Nskill2 = 1;
                    DescSkill2.SetActive(true);

                    ShadowSkill1.SetActive(false);
                    Nskill1 = 0;
                    DescSkill1.SetActive(false);

                    ShadowSkill3.SetActive(true);
                    ShadowSkill4.SetActive(true);
                }
                else if (Nskill2 == 1)
                {
                    ShadowSkill1.SetActive(true);
                    Nskill1 = 1;
                    DescSkill1.SetActive(true);

                    ShadowSkill2.SetActive(false);
                    Nskill2 = 0;
                    DescSkill2.SetActive(false);

                    ShadowSkill3.SetActive(true);
                    ShadowSkill4.SetActive(true);
                }
            }
        }
    }
    public void MenuUp()
    {
        if (Input.GetButtonDown("Up"))
        {
            if(Nactionmenu == 1)
            {
                if(Nbag == 1)
                {
                    Nbag = 0;
                    ShadowBag.SetActive(false);

                    ShadowAttack.SetActive(true);
                    Nattack = 1;
                }
                if(Nrun == 1)
                {
                    Nrun = 0;
                    ShadowRun.SetActive(false);

                    ShadowAttack.SetActive(true);
                    Nattack = 1;
                }
            }
            else if (Nattackmenu == 1)
            {
                if (Nskill1 == 1)
                {
                    ShadowSkill2.SetActive(true);
                    Nskill2 = 1;
                    DescSkill2.SetActive(true);

                    ShadowSkill1.SetActive(false);
                    Nskill1 = 0;
                    DescSkill1.SetActive(false);
                }
                else if (Nskill2 == 1)
                {
                    ShadowSkill1.SetActive(true);
                    Nskill1 = 1;
                    DescSkill1.SetActive(true);

                    ShadowSkill2.SetActive(false);
                    Nskill2 = 0;
                    DescSkill2.SetActive(false);
                }
            }
        }
    }

    public void MenuLeft()
    {
        if (Input.GetButtonDown("Left"))
        {
            if (Nactionmenu == 1)
            {
                if (Nattack == 1)
                {
                    ShadowBag.SetActive(true);
                    Nbag = 1;
                    ShadowAttack.SetActive(false);
                    Nattack = 0;
                }
                else if (Nrun == 1)
                {
                    ShadowBag.SetActive(true);
                    Nbag = 1;
                    ShadowRun.SetActive(false);
                    Nrun = 0;
                }
            }
            else if (Nattackmenu == 1)
            {
                if (Nskill1 == 1)
                {
                    Nskill1 = 0;
                    ShadowSkill1.SetActive(false);

                    Nbackattack = 1;
                    Shadowbackattack.SetActive(true);
                }
                else if (Nskill2 == 1)
                {
                    Nskill2 = 0;
                    ShadowSkill2.SetActive(false);

                    Nbackattack = 1;
                    Shadowbackattack.SetActive(true);
                }
            }
        }
    }

    public void MenuRight()
    {
        if(Input.GetButtonDown("Right"))
        {
            if(Nactionmenu == 1)
            {
                if(Nattack == 1)
                {
                    ShadowRun.SetActive(true);
                    Nrun = 1;
                    ShadowAttack.SetActive(false);
                    Nattack = 0;
                }
                else if(Nbag == 1)
                {
                    ShadowRun.SetActive(true);
                    Nrun = 1;
                    ShadowBag.SetActive(false);
                    Nbag = 0;
                }

            }
            else if(Nattackmenu == 1)
            {
                if(Nbackattack == 1)
                {
                    ShadowSkill1.SetActive(true);
                    Shadowbackattack.SetActive(false);

                    Nskill1 = 1;
                    Nbackattack = 0;
                }
            }
        }
    }

    private void MenuEnter()
    {
        if (Input.GetButtonDown("Attacking"))
        {
            if(Nactionmenu == 1)
            {
                if(Nattack == 1)
                {
                    ActionMenu.SetActive(false);
                    AttackMenu.SetActive(true);

                    Nactionmenu = 0;
                    Nattackmenu = 1;
                    Nattack = 0;
                    Nskill1 = 1;

                    ShadowSkill1.SetActive(true);
                    Shadowbackattack.SetActive(false);

                }
                else if(Nbag == 1)
                {
                    ActionMenu.SetActive(false);
                    BagMenu.SetActive(true);

                    Nactionmenu = 0;
                    Nbagmenu = 1;
                    Nbag = 0;
                    Nbackbag = 1;

                    Shadowbackbag.SetActive(true);
                }
                else if(Nrun == 1)
                {
                    //Tutup Dawg
                }
            }
            else if(Nattackmenu == 1)
            {
                radnumber = Random.Range(1, 3);

                if (Nskill1 == 1)
                {
                    phase = -1;
                    skill = 1;
                    Nattackmenu = 0;
                    Nskill1 = 0;
                    ShadowSkill1.SetActive(false);
                    playerattack.numberofAttack = 1;
                    trigger.jumpnumber = 1;
                    if (radnumber == 1)
                    {
                        trigger.arah = 2;
                        Triggernya.transform.position = spawn1.transform.position;
                    }
                    else
                    {
                        trigger.arah = 1;
                        Triggernya.transform.position = spawn2.transform.position;
                    }
                }
                else if(Nskill2 == 1)
                {
                    phase = -1;
                    skill = 2;
                    Nattackmenu = 0;
                    Nskill2 = 0;
                    ShadowSkill2.SetActive(false);
                    playerattack.numberofAttack = 3;
                    trigger.jumpnumber = 3;
                    if (radnumber == 1)
                    {
                        trigger.arah = 2;
                        Triggernya.transform.position = spawn1.transform.position;
                    }
                    else
                    {
                        trigger.arah = 1;
                        Triggernya.transform.position = spawn2.transform.position;
                    }

                }
                else if(Nbackattack == 1)
                {
                    AttackMenu.SetActive(false);
                    ActionMenu.SetActive(true);

                    Nattackmenu = 0;
                    Nbackattack = 0;
                    Nactionmenu = 1;
                    Nattack = 1;

                    ShadowAttack.SetActive(true);
                    ShadowRun.SetActive(false);
                }
            }
            else if(Nbagmenu == 1)
            {
                if(Nbackbag == 1)
                {
                    BagMenu.SetActive(false);
                    ActionMenu.SetActive(true);

                    Nbackbag = 0;
                    Nbagmenu = 0;
                    Nattack = 1;
                    Nactionmenu = 1;

                    ShadowAttack.SetActive(true);
                    ShadowBag.SetActive(false);
                }
            }
        }

    }
    void Update()
    {
        MenuDown();
        MenuLeft();
        MenuRight();
        MenuUp();
        MenuEnter();
    }
}
