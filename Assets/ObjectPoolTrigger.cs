using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolTrigger : MonoBehaviour
{
    public GameObject objectPool;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(stopObjectPool());
        }
    }
    IEnumerator stopObjectPool()
    {
        objectPool.SetActive(false);
        yield return new WaitForSeconds(5f);
        objectPool.SetActive(true);
    }
}
