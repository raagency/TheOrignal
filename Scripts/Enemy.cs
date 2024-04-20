using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private int HP = 100;
    public Slider healthbar;
    public Animator animator;

    void Update()
    {
        healthbar.value = HP;
    }
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            animator.SetTrigger("Die");
        }
        else
        {
            animator.SetTrigger("Damage");
        }
    }
}
