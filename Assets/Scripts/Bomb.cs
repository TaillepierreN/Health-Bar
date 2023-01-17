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
        Character characterToHurt = other.GetComponent<Character>();
        if (characterToHurt)
        {
            characterToHurt.GetHurt(damage);
            Destroy(gameObject);
        }
    }
}
