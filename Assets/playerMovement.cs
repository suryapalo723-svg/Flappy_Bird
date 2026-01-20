using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D Rb; //inisiasi
    public float jumpForce; //Jump loncat

    float score;

    public Text scoreTxt;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>(); //inialisasi   
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "" + score;

        if (Input.GetMouseButtonDown(0)) //klik mouse kiri for pc / tab untuk hp
        {
            Rb.velocity = Vector2.up * jumpForce;
        } 
    }
       private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            score++;
        }
        if (collision.gameObject.tag == "pipa")
        {
            Destroy(gameObject);
        }
    }
}
        
