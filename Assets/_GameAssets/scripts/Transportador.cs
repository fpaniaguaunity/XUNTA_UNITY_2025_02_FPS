using UnityEngine;
using UnityEngine.SceneManagement;

public class Transportador : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
