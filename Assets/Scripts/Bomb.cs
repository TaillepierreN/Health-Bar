using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] int damage = 10;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player player = other.gameObject.GetComponent<Player>();
            player.GetHurt(damage);
            // avec propriété
            //player.Health -= damage;
            
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Ally"))
        {
            Ally ally = other.gameObject.GetComponent<Ally>();
            ally.GetHurt(damage);

            Destroy(gameObject);
        }

    }
}
