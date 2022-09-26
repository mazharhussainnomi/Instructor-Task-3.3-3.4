using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenFireHitsBallDestroy : MonoBehaviour
{
    public static int ScoreCounter1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        ScoreCounter1++;
        //Debug.Log(ScoreCounter1);


        Destroy(gameObject);
        Destroy(other.gameObject);
        Debug.Log(message: "Nomi " + DetectCollision.ScoreCounter1);
    }
}
