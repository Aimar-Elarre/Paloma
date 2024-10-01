using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_enemigo : MonoBehaviour
{
    public Transform pl;
    public int velocidad =  1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, pl.position, velocidad * Time.deltaTime);
    }
}
