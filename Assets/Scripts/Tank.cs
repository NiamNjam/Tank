using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{

    public float speed = 5;
    public float rotateSpeed = 90;
    public string verticalAxis;
    public string horizontalAxis;
    public KeyCode shootKey;
    public GameObject bullet;
    public Transform shootPoint;
    public AudioSource Bsource;
    public AudioClip bulletSound;
    //public AudioSource Tsource;
    //public AudioClip tankSound;
    // Update is called once per frame
    void Update()
    {
        var ver = Input.GetAxis(verticalAxis);
        //transform.position += transform.forward * speed * ver * Time.deltaTime;
        GetComponent<Rigidbody>().velocity = transform.forward * speed * ver;

        var hor = Input.GetAxis(horizontalAxis);
        transform.Rotate(0, rotateSpeed * Time.deltaTime * hor,0);

        if (Input.GetKeyDown(shootKey))
        {
            print("Shoot!");
            Instantiate(bullet,shootPoint.position,shootPoint.rotation);
            Bsource.clip = bulletSound;
            Bsource.Play();
            ///source.volume = 0;
        }
    }
}
