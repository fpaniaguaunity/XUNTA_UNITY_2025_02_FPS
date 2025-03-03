using UnityEngine;

public class CajaSalud : MonoBehaviour
{
    public int salud = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameObject.Find("GameManager").GetComponent<GameManager>().agregarSalud(this.salud);
        }
    }
}