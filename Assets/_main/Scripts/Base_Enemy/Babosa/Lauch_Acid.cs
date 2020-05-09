using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lauch_Acid : Enemy_base
{
    public GameObject acidCoil;

    public void AcidRain()
    {
        Vector3 spawn = player.transform.position;
        Instantiate(acidCoil, spawn, Quaternion.identity);
    }
}
