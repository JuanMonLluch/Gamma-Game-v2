using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Plat_Ver : MonoBehaviour
{
    //false arr true abajo
    private bool auxSentido;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (auxSentido == false)
        {
            gameObject.transform.Translate(new Vector2(0, 4 * Time.deltaTime));
        }
        else if (auxSentido == true)
        {
            gameObject.transform.Translate(new Vector2(0, -4 * Time.deltaTime));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Limite")
        {
            if (auxSentido == false)
            {
                auxSentido = true;
            }
            else if (auxSentido == true)
            {
                auxSentido = false;
            }
        }

    }
}
