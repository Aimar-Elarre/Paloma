using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vidapl : MonoBehaviour
{
    [SerializeField] private float vidaPL;

    // Start is called before the first frame update
    public void TomarDa�o(float da�o)
    {
        vidaPL -= da�o;

        if (vidaPL <= 0)
        {
            
            Destroy(gameObject);
            SceneManager.LoadScene("SampleScene");

        }

    }

}
