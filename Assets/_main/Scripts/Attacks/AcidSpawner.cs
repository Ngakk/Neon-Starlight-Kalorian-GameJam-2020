using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidSpawner : MonoBehaviour
{
    public Transform target;
    public float spawnRate;
    public GameObject acidIndicator;
    public GameObject acidPfb;
    public Vector3 spawnOffset;
    public Vector3 startingSpeed;

    public void SpawnAcid(int _ammount)
    {
        StartCoroutine(spawnAcidSpot(_ammount));
    }

    public IEnumerator spawnAcidSpot(int _ammount)
    {
        for (int i = 0; i < _ammount; i++)
        {
            GameObject acid = Instantiate(acidIndicator, new Vector3(target.position.x, 0.01f, target.position.z), Quaternion.identity, gameObject.transform);
            StartCoroutine(spawnAcidDrop(acid.GetComponent<ParticleSystem>().main.duration, target.position));
            Destroy(acid, acid.GetComponent<ParticleSystem>().main.duration + 0.1f);
            yield return new WaitForSeconds(spawnRate);
        }
    }

    public IEnumerator spawnAcidDrop(float _delay, Vector3 _pos)
    {
        yield return new WaitForSeconds(_delay);
        GameObject drop = Instantiate(acidPfb, new Vector3(_pos.x + spawnOffset.x, _pos.y + spawnOffset.y, _pos.z + spawnOffset.z), acidPfb.transform.rotation, gameObject.transform);
        var comp = drop.GetComponent<Rigidbody>();
        if (comp)
            comp.velocity = startingSpeed;

        Destroy(drop, 2.0f);
    }
}
