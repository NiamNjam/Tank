using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    //public GameObject BabyRocks;
    //public GameObject Rock;
    public GameObject particals;
    public GameObject explode;
    private void Start()
    {
        //Destroy(gameObject, 2f);
    }
    // Update is called once per frame

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="Boom")
        {
            Destroy(collision.gameObject);
            for (int i = 0; i < 7; i++)
            {
                var offset = Random.insideUnitSphere;
                Instantiate(particals, transform.position + offset, transform.rotation);

            }           
        }
        Destroy(gameObject);

        if (collision.gameObject.name == "plane")
        {
            //explode.transform == ;
        }
    }
}
