using UnityEngine;

public class movimientoPlanetas : MonoBehaviour
{
    public int velocidadRotacionOrbita;
    public int velocidadRotacionEje;

    public Transform Sol;
    void Update()
    {
        transform.RotateAround(Sol.position, Vector3.up, velocidadRotacionOrbita * Time.deltaTime);

        transform.Rotate(Vector3.up * velocidadRotacionEje * Time.deltaTime);
    }
}
