using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [Header("Configuracion de vidas y puntajes")]
    [SerializeField] private int vidasMaximas = 3;
    [SerializeField] private int vidasActuales;
    [SerializeField] private int Puntaje = 0;

    [Header("Interfaz de Usuario (UI)")]
    [SerializeField] private TextMeshProUGUI textoVidas;
    [SerializeField] private TextMeshProUGUI textoPuntajes;

    private Vector3 puntosReaparicion;

    private void Start()
    {
        vidasActuales = vidasMaximas;
        puntosReaparicion = transform.position;
        ActualizarUi();
    }

    public void SumarPuntos(int cantidad)
    {
        Puntaje += cantidad;
        ActualizarUi();
    }

    public void SumarVidas(int cantidad)
    {
        if (vidasActuales < vidasMaximas)
        {
            vidasActuales += cantidad;
            ActualizarUi();
        }
    }

    public void Recibirdamage(int damage)
    {
        vidasActuales -= damage;
        ActualizarUi();

        if (vidasActuales <= 0)
        {
            MorirDefinitivamente();
        }
        else
        {
            ReaparecerEnCheckpoint();
        }
    }

    public void ActualizarCheckpoint(Vector3 nuevaPosicion)
    {
        puntosReaparicion = nuevaPosicion;
    }

    public void ReaparecerEnCheckpoint()
    {
        transform.position = puntosReaparicion;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.angularVelocity = Vector2.zero;
        }
    }

    public void ActualizarUi()
    {
        if (textoVidas != null)
        {
            textoVidas.text = "Vidas: " + vidasActuales;
        }

        if (textoPuntajes != null)
        {
            textoPuntajes.text = "Puntos: " + textoPuntajes;
        }
    }
}
