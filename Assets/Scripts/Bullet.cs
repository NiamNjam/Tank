using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public GameObject BabyRocks;
    public GameObject Rock;
    private void Start()
    {
        ///Rock.SetActive(true);
        //BabyRocks.SetActive(false);
        //Destroy(gameObject, 2f);
    }
    // Update is called once per frame

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Rock")
        {
            print("a");
            Rock.SetActive(false);
            BabyRocks.SetActive(true);            
        }
    }
}
