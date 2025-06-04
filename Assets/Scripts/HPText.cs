using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPText : MonoBehaviour
{
    public Text text;
    public Entity entity;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "HP: " + entity.HP;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "HP: " + entity.HP;
    }
}
