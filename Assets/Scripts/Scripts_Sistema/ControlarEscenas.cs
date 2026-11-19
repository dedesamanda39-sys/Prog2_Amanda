using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlarEscenas : MonoBehaviour
{
    public void CargarEscenaPorNombre(string nombreEscena)
    {
         SceneManager.LoadScene(nombreEscena);
    }

    public void IniciarJuego()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void IrAlInicio()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void IrAGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }
}
