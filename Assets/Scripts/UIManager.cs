using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text preguntaText;
    public Text puntajeText;
    public Button trueButton;
    public Button falseButton;

    public GameManager gameManager;

    void Start()
    {
        trueButton.onClick.AddListener(() => gameManager.Responder(true));
        falseButton.onClick.AddListener(() => gameManager.Responder(false));
    }

    public void MostrarPregunta(string textoPregunta)
    {
        preguntaText.text = textoPregunta;
    }

    public void ActualizarPuntaje(int puntaje)
    {
        puntajeText.text = "Puntaje: " + puntaje;
    }

    public void MostrarResultadoFinal(int puntajeFinal)
    {
        preguntaText.text = "Juego terminado!";
        puntajeText.text = "Puntaje final: " + puntajeFinal;
        trueButton.interactable = false;
        falseButton.interactable = false;
    }
}
