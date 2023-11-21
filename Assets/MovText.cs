using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovText : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    [SerializeField]private Vector2 direction;


    void Awake()
    {
       rb2d = GetComponent<Rigidbody2D>();
        StartCoroutine(Direccion());
    }

     void Update()
    {
        rb2d.velocity = speed * direction;

    }
    IEnumerator Direccion()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            direction *= -1;
        }
    }
    
}
