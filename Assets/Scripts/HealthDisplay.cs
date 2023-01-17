using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text _textDisplay;
    //public IntVariable PlayerHP;
    [SerializeField] Slider _healthSlider;
    [SerializeField] IntVariable hp;

    private float lastHP;

    private void Awake()
    {
        lastHP = hp.Value;
    }

    private void Start()
    {
        UpdateHealthDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        //les hp ont changé à cette frame    
        if (hp.Value != lastHP)
        {
            UpdateHealthDisplay();

            // on retient la dernière valeur des hp pour détecter un changement de hp
            lastHP = hp.Value;
        }
    }

    private void UpdateHealthDisplay()
    {
        // met à jour les hp au format texte
        _textDisplay.text = hp.Value.ToString();
        // met à jour les hp dans la barre de vie
        _healthSlider.value = hp.Value;
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
