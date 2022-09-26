using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private float topBound = 50;
    private float lowerbound = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 50)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerbound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }
    
}
