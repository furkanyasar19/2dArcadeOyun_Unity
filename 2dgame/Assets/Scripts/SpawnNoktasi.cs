using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNoktasi : MonoBehaviour
{
    public GameObject engel;
    void Start()
    {
        InvokeRepeating("engel_ekle", 0.0f, 0.5f);
    }

    void engel_ekle()
    {
        GameObject yeni_engel = Instantiate(engel);
    }
}
