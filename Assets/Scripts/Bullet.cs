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
    //public Transform explosionPrefab;
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
            //Destroy(collision.gameObject);
            for (int i = 0; i < 7; i++)
            {
                
                var offset = Random.insideUnitSphere;
                Instantiate(particals, transform.position + offset, transform.rotation);

            }
            collision.gameObject.GetComponent<Health>().Damage();
        }
        Destroy(gameObject);

        foreach (ContactPoint contact in collision.contacts)
        {
            print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 pos = contact.point;
            Instantiate(explode, pos, rot);
        }
    }
}
