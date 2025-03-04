using UnityEngine;

public class AbridorPuerta : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            GetComponent<Animator>().SetTrigger("abrir");
        }
    }
}
