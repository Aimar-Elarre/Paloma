using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public int anchoescena = 15;
    public int altoescena = 20;
    public Transform PL;
    public int velocidad = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PL.position.x >= anchoescena || PL.position.x <= -anchoescena || PL.position.y >= altoescena || PL.position.y <= -altoescena)
        {

        }
        else 
        {
            transform.position = new Vector3(PL.position.x, PL.position.y, transform.position.z);
            
        }

    }
}
