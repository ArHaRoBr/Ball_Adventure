using UnityEngine;

public class Ball : MonoBehaviour, IPooledObject
{
    public float upForce;
    public float sideForce;
    public void OnObjectSpawn()
    {
        sideForce = Random.Range(-sideForce, sideForce);
        //float xForce = Random.Range(-sideForce, sideForce);
        Vector2 force = new Vector2(sideForce, upForce);
        GetComponent<Rigidbody2D>().AddForce(force);
    }

  
}
