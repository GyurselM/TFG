using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class personaje : MonoBehaviour
{
    public int idPersonajeSeleccionado;
    public int idNombrePersonaje;
    public Image Personaje;
    public Image NombrePersonaje;
    public Sprite[] iconosPersonaje;
    public Sprite[] iconosNombre;
    public int idMazo;
    public Image Baraja;
    public Sprite[] baraja;

    public InputField metertexto;
    public Text TextoNombre;
    public GameObject botonJugar;
    // Start is called before the first frame update
    void Start()
    {
        idPersonajeSeleccionado = 0;
        idNombrePersonaje = 0;
        idMazo = 0;
    }

    // Update is called once per frame
    void Update()
    {

       //Debug.Log("IDMAZO" + idMazo);

    }

    //Los metodos sumar y restar numeroID sirven para cambiar el nombre y la imagen del personaje cuando se pulse los botones de atras y alante que vemos en la escena

    public void sumarNumeroID()
    {
        idPersonajeSeleccionado ++;
        idNombrePersonaje ++;
        if (idPersonajeSeleccionado > 3 || idNombrePersonaje >3)
        {
            idPersonajeSeleccionado = 3;
            idNombrePersonaje = 3;
        }


        Personaje.sprite = iconosPersonaje[idPersonajeSeleccionado];
        NombrePersonaje.sprite = iconosNombre[idNombrePersonaje];
    }
    public void restarNumeroID() 
    {
        idPersonajeSeleccionado --;
        idNombrePersonaje --;
        if (idPersonajeSeleccionado < 0 || idNombrePersonaje < 0)
        {
            idPersonajeSeleccionado = 0;
            idNombrePersonaje = 0;
        }
        Personaje.sprite = iconosPersonaje[idPersonajeSeleccionado];
        NombrePersonaje.sprite = iconosNombre[idNombrePersonaje];
    }

    // Este metodo se encarga de cambiar la imagen del mazo, cuando esta se pulsa cambia por otro sprite.

    public void CambiarMazo()
    {
        idMazo++;
        if(idMazo > 1)
        {
            idMazo = 1;
        }

        Baraja.sprite = baraja[idMazo];


    }

    public void aceptar()
    {
        PlayerPrefs.SetString("nombreUsuario", metertexto.text);
        SceneManager.LoadScene("siguiente");
    }
    
}
