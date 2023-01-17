using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : Character 
{
    [SerializeField] int _followDistance;
    [SerializeField] GameObject _player;
    [SerializeField] float speed = 5f;

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
}
