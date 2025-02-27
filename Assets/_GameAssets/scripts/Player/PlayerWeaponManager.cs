using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour
{
    public Weapon weapon;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (weapon.gameObject.activeSelf)
            {
                weapon.ApretarGatillo();
            }
        }
    }
}