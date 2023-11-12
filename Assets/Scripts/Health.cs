using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp;
    public GameObject particle;
    public int particleCount;
    public bool autoDestroy;
    // Start is called before the first frame update
    public void Damage()
    {
        hp--;
        if (hp == 0) Die();
    }

    public void Die()
    {
        for (int i = 0; i < particleCount; i++)
        {
            var offset = Random.insideUnitSphere;
            Instantiate(particle, transform.position + offset, transform.rotation);

        }
        //Destroy(gameObject);

        if (autoDestroy) Destroy(gameObject);
    }
}
