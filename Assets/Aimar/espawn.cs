using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject NewGameObject;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
         if (Random.Range(1,100) == 2)
        {
            espaunear();
        }
    }
    private void espaunear()
    {
      GameObject go =   Instantiate(NewGameObject, new Vector3(Random.Range(-20,20), Random.Range(-20, 20),0), Quaternion.identity);
      Mov_enemigo enemigo = go.GetComponent<Mov_enemigo>();
        enemigo.pl = player;

    }
}
