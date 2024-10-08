using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float da�oPL;

    // Start is called before the first frame update
    public void TomarDa�o(float da�o)
    {
        vida -= da�o;

        if (vida <= 0)
        {

            Destroy(gameObject);


        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PL"))
        {
            Debug.Log("hola");
            other.GetComponent<vidapl>().TomarDa�o(da�oPL);
            Destroy(gameObject);
        }
    }
}
