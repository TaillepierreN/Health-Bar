using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int initialHealth = 100;
    [SerializeField] GameObject _displayHealth;
    int health;
    public int Health { get { return health; } private set { } }

    // Version propriété modifiable depuis l'extérieur
    //public int Health { 
        //get { return health; }
        //set
        //{
            //if (value <= 0f) health = 0;
            //else health = value;
        //}
    //}


    // exemple d'auto-propriété
    //public int AutoHealth {get;set;}

    // Awake s'exécute avant le Start
    private void Awake()
    {
        // Ici on met tout ce qui est initialisation de variables interne à la classe 
        health = initialHealth;
    }

    // Start is called before the first frame update
    void Start()
    {
        _displayHealth.GetComponent<HealthDisplay>().SetMaxHealth(initialHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GetHurt(int damage)
    {
        health = health - damage;
        if (health <= 0) health = 0;
        _displayHealth.GetComponent<HealthDisplay>().SetHealth(health);

    }

}
