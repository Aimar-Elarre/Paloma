using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movi : MonoBehaviour
{
    public KeyCode w;
    public KeyCode a;
    public KeyCode s;
    public KeyCode d;

    public int velocidad = 2;
    private Rigidbody2D rb;
    Vector3 x;
    Vector3 y;
    // Start is called before the first frame update
    void Start()
    {
        x = new Vector3(velocidad, 0, 0);
        y = new Vector3(0, velocidad, 0);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(w))
        {
            transform.position = transform.position + y * Time.deltaTime;
        }
        if (Input.GetKey(d))
        {
            transform.position = transform.position + x * Time.deltaTime;
        }
        if (Input.GetKey(a))
        {
            transform.position = transform.position + (-x) * Time.deltaTime;
        }
        if (Input.GetKey(s))
        {
            transform.position = transform.position + (-y) * Time.deltaTime;
        }
    }
}
