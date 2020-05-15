using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class controlador : MonoBehaviour
{
    public void CambiarEscena(string nombre)
    {
       
        print("cambiando de escena" + nombre);
        SceneManager.LoadScene(nombre);
    }
    public void regresar()
    {
        print("SALIENDO DEL JUEGO");
        Application.Quit();//tengo hambre

    }
}
