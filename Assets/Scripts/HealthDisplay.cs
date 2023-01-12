using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text _textDisplay;
    [SerializeField] GameObject _player;
    Player _playerScript;
    // Start is called before the first frame update
    void Start()
    {
       _playerScript = _player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        _textDisplay.text = "Player HP = " + _playerScript.Health;
    }
}
