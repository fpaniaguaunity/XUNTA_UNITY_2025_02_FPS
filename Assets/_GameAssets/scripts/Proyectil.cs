using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public int danyo = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")){
            /*
            //No haría falta, sirve para comprobar que el enemigo tiene el script EnemigoManager
            if (collision.gameObject.GetComponent<EnemigoManager>() == null)
            {
                throw new System.Exception("Hemos encontrado un enemigo sin script EnemigoManager");
            }
            */
            collision.gameObject.GetComponent<EnemigoManager>().RecibirDanyo(this.danyo);
        }
    }
}