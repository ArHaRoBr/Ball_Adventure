using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsSpawner : MonoBehaviour
{
 ObjectPooler pooler;
    private void Start()
    {
        pooler = ObjectPooler.Instance;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        pooler.SpawnFromPool("DeathBall", transform.position, transform.rotation);   
    }
}
