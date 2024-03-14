using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class main : MonoBehaviour
{
    public CharacterInfo[] Characters;
    public GameObject pausemenu;
    public CardSetter[] CartasEnMano;

    /**************************************************** ESTE SCRIPT ES LA LOGICA DEL JUEGO, NO ESTA TERMINADO, ESTA EN PROCESO ****************************************************/

    // Start is called before the first frame update
    void Start()
    {
        //CartasEnMano[0].SetCard(1);
        for (int i = 0; i < CartasEnMano.Length; i++)
        {
            CartasEnMano[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < 5; i++)
        {
            RobarCarta(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausemenu.SetActive(!pausemenu.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.L)) {
        //Robar Carta
        }
    }
    public void DropInPosition(bool bMano)
    {
        if (bMano == true)
        {
           
        }
        else
        {
            use();
            
            
        }
    }
    public void use() { }
    public void RobarCarta(int id) {
        for (int i = 0; i < CartasEnMano.Length; i++)
        {
            
            CartasEnMano[i].gameObject.SetActive(false);
        }
    }
}
