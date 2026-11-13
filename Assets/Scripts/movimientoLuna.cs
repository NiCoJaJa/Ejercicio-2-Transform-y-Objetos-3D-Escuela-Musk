using UnityEngine;

public class movimientoLuna : MonoBehaviour
{
    public int velocidadRotacionOrbita;
    public int velocidadRotacionEje;

    public Transform Tierra;
    void Update()
    {
        transform.RotateAround(Tierra.position, Vector3.up, velocidadRotacionOrbita * Time.deltaTime);

        transform.Rotate(Vector3.up * velocidadRotacionEje * Time.deltaTime);
    }
}
