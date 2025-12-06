using UnityEngine;

public class Andar : MonoBehaviour
{
    enum State
    {
        parado = 0,
        andando = 1,
    }
    State estado = State.parado;
    public void Mudanca()
    {
        switch (estado)
        {
            case State.parado:
                estado = State.andando; break;
            case State.andando:
                estado = State.parado; break;
        }
    }
    public void Update ()
    {
        switch (estado)
        {
            case State.parado: break;
            case State.andando: break;
                transform.position += Vector3.zero; break;
        }
    }
}
