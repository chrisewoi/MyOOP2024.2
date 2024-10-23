using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : TriggerZone
{
    public Powerup[] powerup;

    public float speed = 20;
    public int totalPUChances;

    public void Start()
    {
        totalPUChances = 0;
        foreach (Powerup PU in powerup)
        {
            totalPUChances += PU.chance;
        }
    }

    public override void Activate(Collider collider)
    {
        Powerup chosenPU = null;
        int PUCountdown = Random.Range(0, totalPUChances);
        foreach (Powerup PU in powerup)
        {
            PUCountdown -= PU.chance;
            if (PUCountdown <= 0)
            {
                chosenPU = PU;
            }
        }

        if (chosenPU == null) return;
        chosenPU.UsePowerup(collider.attachedRigidbody);
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
