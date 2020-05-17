using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float MaxHp = 100;
    [SerializeField]
    private float CurrentHp = 100;

    public void Damage(float dmg)
    {
        CurrentHp -= dmg;
        if (CurrentHp < 0)
            CurrentHp = 0;
    }
}
