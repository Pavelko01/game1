using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed =1.2f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        Enemy enemyE = other.GetComponent<Enemy>();
        Destroy(enemyE.gameObject);
        
    }

}
