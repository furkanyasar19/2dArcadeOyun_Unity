using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel : MonoBehaviour
{
    //-7.31 sil   2.84 ekle
    // -1.66   1.7
    void Start()
    {
        float rnd = Random.Range(-1.66f, 1.7f);
        transform.position = new Vector3(rnd, 2.84f, transform.position.z);
    }

    void Update()
    {
        if (transform.position.y<=-7.31f)
        {
            Destroy(gameObject);
        }
        transform.Translate(0, -5f * Time.deltaTime, 0);
    }
}
