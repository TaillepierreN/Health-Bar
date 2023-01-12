using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text _textDisplay;
    //public IntVariable PlayerHP;
    [SerializeField] Player _playerScript;
    [SerializeField] Slider _healthSlider;
    public IntVariable PlayerHP;

    private float lastHP;

    private void Awake()
    {
        lastHP = _playerScript.Health;
    }

    private void Start()
    {
        _textDisplay.text = "Player HP = " + _playerScript.Health;
    }

    // Update is called once per frame
    void Update()
    {
        //les hp ont changé à cette frame    
        if (_playerScript.Health != lastHP)
        {
            _textDisplay.text = "Player HP = " + PlayerHP.Value;
            lastHP = _playerScript.Health;
        }
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
