using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image bar;

    public float health;
    public void SetHealth(float healthValue)
    {
        health = healthValue;
        UpdateBar();
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        UpdateBar();
    }
    public void Heal(float healing)
    {
        health += healing;
        UpdateBar();
    }
    private void UpdateBar()
    {
        //pode ter animacao
        bar.fillAmount = health;
    }
}
