using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Defend : MonoBehaviour
{
    // Start is called before the first frame update
    public int phase = 0;
    public int numberofdef = 0;

    public bool guard;
    public bool evade;
    public bool miss;


    public Vector2 scalechange, positionchange;

    public DefendTrigger trigger;
    public Menu menu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (phase == 1)
        {
            if (collision.gameObject.name == "Evade")
            {
                evade = true;
            }
            if (collision.gameObject.name == "Guard" && collision.gameObject.name != "Evade")
            {
                guard = true;
            }
            if (collision.gameObject.name == "Miss" && collision.gameObject.name != "Guard" && collision.gameObject.name != "Evade")
            {
                miss = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Evade")
        {
            evade = false;
        }

        if (collision.gameObject.name == "Guard")
        {
            guard = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.arah == 1)
        {
            Vector2 target = Totheright();
            trigger.platform.position = Vector2.MoveTowards(trigger.platform.position, target, trigger.speed * Time.deltaTime);
        }
        else if (trigger.arah == 2)
        {
            Vector2 target = Totheleft();
            trigger.platform.position = Vector2.MoveTowards(trigger.platform.position, target, trigger.speed * Time.deltaTime);
        }
    }


    Vector2 Totheleft()
    {
        if (trigger.direction == 1)
        {
            return trigger.endPoint.position;
        }
        else
        {
            return trigger.startPoint.position;
        }
    }

    Vector2 Totheright()
    {
        if(trigger.direction == 1)
        {
            return trigger.startPoint.position;
        }
        else
        {
            return trigger.endPoint.position;
        }
    }
    
}
