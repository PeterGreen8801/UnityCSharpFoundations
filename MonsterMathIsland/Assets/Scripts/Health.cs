using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int _hp;
    [SerializeField] private Transform _healthBarUI;

    public int maxHp = 150;
    public UnityEvent onDeath;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHealthBarUI();
    }

    public void TakeDamage(int damage)
    {
        _hp -= damage;

        if (_hp <= 0)
        {
            UpdateHealthBarUI();
            _hp = 0;
            onDeath.Invoke();
            return;
        }
        UpdateHealthBarUI();
    }

    public int CalculateDamage(Stats attacker, Stats defender)
    {
        return Mathf.Max(1, attacker.attack - defender.defense);
    }

    public void SetHealthBar(Transform healthBarUI)
    {
        _healthBarUI = healthBarUI;
        UpdateHealthBarUI();
    }

    private void UpdateHealthBarUI()
    {
        if (!_healthBarUI)
        {
            return;
        }

        _healthBarUI.GetChild(1).GetComponent<Image>().fillAmount = (float)_hp / maxHp;
        _healthBarUI.GetChild(2).GetComponent<TMP_Text>().text = $"{_hp} / {maxHp}";
    }


}
