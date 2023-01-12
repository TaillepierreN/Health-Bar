using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text _textDisplay;
    [SerializeField] GameObject _player,_hpBar;
    Player _playerScript;
    Slider _healthSlider;
    // Start is called before the first frame update
    void Start()
    {
       _playerScript = _player.GetComponent<Player>();
       _healthSlider = _hpBar.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        _textDisplay.text = "Player HP = " + _playerScript.Health;
    }
    public void SetMaxHealth(int maxHealth)
    {
        _healthSlider.maxValue = maxHealth;
        _healthSlider.value = maxHealth;
    }
    public void SetHealth(int health)
    {
        _healthSlider.value = health;
    }
}
