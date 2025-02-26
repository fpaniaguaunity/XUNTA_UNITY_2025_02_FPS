using UnityEngine;

public class EnemigoExplosivo : MonoBehaviour
{
    [Header("Distancia a que va a explotar el enemigo")]
    public float explosionDistance;

    [Header("Prefab de la explosión que se va a generar cuando se destruya")]
    public GameObject prefabExplosion;

    [Header("Tag del GameObject al que va a seguir")]
    public string targetTag = "Player";

    //Al ser private no aparece en el inspector
    private Transform transformPlayer;
    private float distanciaAPlayer;

    void Start()
    {
        transformPlayer = GameObject.FindGameObjectWithTag(targetTag).transform;
    }

    void Update()
    {
        //El atributo magnitude nos proporciona la distancia que separa los dos transform
        distanciaAPlayer = (transformPlayer.position - transform.position).magnitude;
        if (distanciaAPlayer <= explosionDistance)
        {
            Destroy(gameObject);
            Instantiate(prefabExplosion, transform.position, transform.rotation);
        }
    }
}
