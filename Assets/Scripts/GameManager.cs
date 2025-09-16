using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Pregunta> preguntas; // Asignar las 10 preguntas en inspector
    private int indicePreguntaActual = 0;
    private int puntaje = 0;

    public UIManager uiManager;

    void Start()
    {
        puntaje = 0;
        indicePreguntaActual = 0;
        uiManager.MostrarPregunta(preguntas[indicePreguntaActual].pregunta);
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
            uiManager.MostrarPregunta(preguntas[indicePreguntaActual].pregunta);
        }
        else
        {
            uiManager.MostrarResultadoFinal(puntaje);
        }
    }
}
