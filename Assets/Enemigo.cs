using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float dañoPL;

    // Start is called before the first frame update
    public void TomarDaño(float daño)
    {
        vida -= daño;

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
            other.GetComponent<vidapl>().TomarDaño(dañoPL);
            Destroy(gameObject);
        }
    }
}
