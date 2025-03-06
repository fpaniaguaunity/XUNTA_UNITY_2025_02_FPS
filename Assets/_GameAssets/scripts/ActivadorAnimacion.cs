using UnityEngine;

public class ActivadorAnimacion : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            GetComponentInChildren<Animator>().SetTrigger("Saltar");
        } 
    }
}
