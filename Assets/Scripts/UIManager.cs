using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text preguntaText;
    public TMP_Text puntajeText;
    public Image preguntaImage;
    public Button trueButton;
    public Button falseButton;
    public Button reiniciarButton;
    public GameManager gameManager;

    void Start()
    {
        trueButton.onClick.AddListener(() => gameManager.Responder(true));
        falseButton.onClick.AddListener(() => gameManager.Responder(false));
        reiniciarButton.onClick.AddListener(ReiniciarJuego);
        reiniciarButton.gameObject.SetActive(false);
    }

    public void MostrarPregunta(string textoPregunta, Sprite imagen)
    {
        preguntaText.text = textoPregunta;
        if (imagen != null)
        {
            preguntaImage.sprite = imagen;
            preguntaImage.gameObject.SetActive(true);
        }
        else
        {
            preguntaImage.gameObject.SetActive(false);
        }
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
        reiniciarButton.gameObject.SetActive(true);
    }

    private void ReiniciarJuego()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
