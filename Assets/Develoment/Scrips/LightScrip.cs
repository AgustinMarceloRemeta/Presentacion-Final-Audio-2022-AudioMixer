using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScrip : MonoBehaviour
{
    Light luz;
    [SerializeField] float Cooldown, CooldownValor;
    int number;
    [SerializeField] Color[] colors;
    void Start()
    {
        luz = GetComponent<Light>();
        number = 0;
        CooldownValor = Cooldown;
    }


    void Update()
    {
        Cooldown -= Time.deltaTime;
        if(Cooldown <= 0)
        {
            luz.color = colors[number];
            number++;
            if (number >= colors.Length) number = 0;
            Cooldown = CooldownValor;
        }
    }
}
