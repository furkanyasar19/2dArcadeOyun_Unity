using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ballHareket : MonoBehaviour
{
    public AudioSource sesdosyasi;
    public AudioClip altinses;

    public Text altin_text;
    public Text skor_text;
    int altin = 0;
    int skor = 0;
    void Start()
    {
        
    }
    void Update()
    {
        //transform.Translate(0, 5*Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(5 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-5 * Time.deltaTime, 0, 0);
        }

        //if (Input.GetMouseButton(0))
        //{
        //    transform.Translate(-5 * Time.deltaTime, 0, 0);
        //}
        //if (Input.GetMouseButton(1))
        //{
        //    transform.Translate(5 * Time.deltaTime, 0, 0);
        //}

    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="altin")
        {
            sesdosyasi.PlayOneShot(altinses);          
            Destroy(collision.gameObject);
            altin += 1;
            altin_text.text = altin.ToString();

            skor += 10;
            skor_text.text = skor.ToString();
        }
        else if (collision.gameObject.tag=="engel")
        {
            SceneManager.LoadScene(0);
        }
    }
}
