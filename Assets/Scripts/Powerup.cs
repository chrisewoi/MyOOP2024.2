using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;

// https://github.com/CapelaGames/MyOOP2024.2

[CreateAssetMenu(menuName = "Weapon/weapon")]
public abstract class Powerup : ScriptableObject
{
    public int chance = 1;
    public float cooldown = 1f;
    public float duration = 0f;
    public float power = 1f;

    public abstract void UsePowerup(Rigidbody rb);

}