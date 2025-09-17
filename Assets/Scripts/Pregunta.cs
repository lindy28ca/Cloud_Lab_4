using UnityEngine;

[CreateAssetMenu(fileName = "NuevaPregunta", menuName = "VerdaderoFalso/Pregunta")]
public class Pregunta : ScriptableObject
{
    public string pregunta;
    public bool respuesta;
    public Sprite imagen;
}
