using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
// Dit is nodig om Image te gebruiken

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public Image healthbarFill;

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }

    public void RestoreHealth(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }
    //zorgt ervoor dat er health vanaf en bij gaat

    void UpdateHealthBar()
    {
        healthbarFill.fillAmount = currentHealth / maxHealth;
    }

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();

    }

    void Update()
    {

    }

}

