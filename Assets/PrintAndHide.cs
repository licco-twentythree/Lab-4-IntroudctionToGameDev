using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int random;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.tag == "Red" && i > 99)
        {
            gameObject.SetActive(false);
        }        

        if (gameObject.tag == "Blue" && i == random)
        {
            rend.enabled = false;
        }

        
        if (gameObject.active)
        {
            i++;
            Debug.Log(gameObject.name + ":" + i);
        }
    }
}
