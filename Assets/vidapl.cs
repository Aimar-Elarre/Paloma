using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vidapl : MonoBehaviour
{
    [SerializeField] private float vidaPL;

    // Start is called before the first frame update
    public void TomarDaño(float daño)
    {
        vidaPL -= daño;

        if (vidaPL <= 0)
        {
            
            Destroy(gameObject);
            SceneManager.LoadScene("SampleScene");

        }

    }

}
