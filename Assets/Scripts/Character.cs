using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] protected int initialHealth = 100;
    [SerializeField] IntVariable health;
    public int Health { get { return health.Value; } private set { } }

    // Version propriété modifiable depuis l'extérieur
    //public int Health { 
        //get { return health; }
        //set
        //{
            //if (value <= 0f) health = 0;
            //else health = value;
        //}
    //}

    private void Awake()
    {
        // Ici on met tout ce qui est initialisation de variables interne à la classe 
        health.Value = initialHealth;
    }

    // Update is called once per frame
    public void GetHurt(int damage)
    {
        health.Value = health.Value - damage;
        if (health.Value <= 0) health.Value = 0;

    }
}
