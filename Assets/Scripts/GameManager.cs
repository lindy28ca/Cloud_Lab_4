using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public List<Pregunta> preguntas;
    private int indicePreguntaActual = 0;
    private int puntaje = 0;
    public UIManager uiManager;

    void Start()
    {
        puntaje = 0;
        indicePreguntaActual = 0;
        preguntas = preguntas.OrderBy(p => Random.value).ToList();
        uiManager.MostrarPregunta(preguntas[indicePreguntaActual].pregunta, preguntas[indicePreguntaActual].imagen);
        uiManager.ActualizarPuntaje(puntaje);
    }

    public void Responder(bool respuestaUsuario)
    {
        if (preguntas[indicePreguntaActual].respuesta == respuestaUsuario)
        {
            puntaje++;
            uiManager.ActualizarPuntaje(puntaje);
        }

        indicePreguntaActual++;

        if (indicePreguntaActual < preguntas.Count)
        {
            uiManager.MostrarPregunta(
                preguntas[indicePreguntaActual].pregunta,
                preguntas[indicePreguntaActual].imagen
            );
        }
        else
        {
            uiManager.MostrarResultadoFinal(puntaje);
        }
    }

}
