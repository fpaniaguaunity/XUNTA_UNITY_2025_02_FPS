using UnityEngine;

public class EnemigoManager : MonoBehaviour
{
    public int energia = 10;
    public GameObject prefabDestruccion;
    public void RecibirDanyo(int cantidad)
    {
        this.energia -= cantidad;
        if (this.energia<=0)
        {
            Instantiate(prefabDestruccion, transform.position, transform.rotation);
            Destroy(gameObject);//Destruye el objeto en el que está el script
        }
    }
}