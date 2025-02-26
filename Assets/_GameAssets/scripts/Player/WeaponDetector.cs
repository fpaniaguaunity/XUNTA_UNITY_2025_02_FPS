using UnityEngine;

public class WeaponDetector : MonoBehaviour
{
    public GameObject weapon;
    public string weaponTag = "WeaponPoint";

    private void Start()
    {
        weapon.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(weaponTag))
        {
            weapon.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
