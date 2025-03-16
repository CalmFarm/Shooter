using UnityEngine;

public class WeaponPickUp : Pick
{
    [SerializeField] WeaponSO weaponSO;

    protected override void OnPickup(ActiveWeapon activeWeapon)
    {
        activeWeapon.SwtichWeapon(weaponSO);
    }
}
