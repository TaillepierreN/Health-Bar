using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    [SerializeField] int initialHealth = 100;
    [SerializeField] int _followDistance;
    [SerializeField] GameObject _player;
    [SerializeField]GameObject _displayHealth;
    [SerializeField] float speed = 5f;
    int health;

    public int Health { get { return health; } private set { } }

    // Start is called before the first frame update
    void Start()
    {
        health = initialHealth;
        _displayHealth.GetComponent<HealthBarAlly>().SetMaxHealth(initialHealth);

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(_player.transform);
        if (Vector3.Distance(transform.position, _player.transform.position) > _followDistance)
        {
            // Méthode 1: (besoin du LookAt) 
            //transform.position += transform.forward * speed * Time.deltaTime;
            
            // Méthode 2: pas besoin du LookAt
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, speed * Time.deltaTime);
        }
        //  else
        // {
        //     transform.position -=transform.forward * 5 * Time.deltaTime;
        // }
    }
    public void GetHurt(int damage)
    {
        health = health - damage;
        _displayHealth.GetComponent<HealthBarAlly>().SetHealth(health);

    }
}
