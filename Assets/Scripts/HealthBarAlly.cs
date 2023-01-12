using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBarAlly : MonoBehaviour
{
    [SerializeField] TMP_Text _textDisplay;
    //public IntVariable PlayerHP;
    [SerializeField] Ally _allyScript;
    [SerializeField] Slider _healthSlider;

    private float lastHP;

    private void Awake()
    {
        lastHP = _allyScript.Health;
    }

    private void Start()
    {
        _textDisplay.text = "Ally HP = " + _allyScript.Health;
    }

    // Update is called once per frame
    void Update()
    {
        //les hp ont changé à cette frame    
        if (_allyScript.Health != lastHP)
        {
            _textDisplay.text = "Ally HP = " + _allyScript.Health;
            lastHP = _allyScript.Health;
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
