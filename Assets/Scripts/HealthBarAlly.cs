using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBarAlly : MonoBehaviour
{
    [SerializeField] TMP_Text _textDisplay;
    [SerializeField] GameObject _ally, _hpBar;
    Ally _allyScript;
    Slider _healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        _allyScript = _ally.GetComponent<Ally>();
        _healthSlider = _hpBar.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        _textDisplay.text = "Ally HP = " + _allyScript.Health;
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
