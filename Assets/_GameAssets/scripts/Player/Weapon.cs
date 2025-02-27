using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private int municion = 1;

    [SerializeField]
    private GameObject prefabProyectil;

    [SerializeField]
    private int fuerza;

    [SerializeField]
    private Transform spawnPoint;

    public void ApretarGatillo()
    {
        if (this.municion > 0)
        {
            this.municion--;
            Disparar();
        } else 
        {
            print("Gatillazo...");
        }
    }

    private void Disparar()
    {
        //Instancia un prefabProyectil en la posición spawnPoint.position con la rotaicón spawnPoint.rotation
        GameObject proyectil = Instantiate(prefabProyectil, spawnPoint.position, spawnPoint.rotation);
        proyectil.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * fuerza);
    }
}
