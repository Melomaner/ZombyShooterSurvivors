using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class PlayerGunSelector : MonoBehaviour
{
    [SerializeField]
    private GunType Gun;
    [SerializeField]
    private Transform GunParent;
    [SerializeField]
    private List<GunScriptableObject> Guns;
    //[SerializeField]
    //private PlayerIK InverseKinematics;

    [Space]
    [Header("Runtime Filled")]
    public GunScriptableObject ActiveGun;

    private void Start()
    {
        SpawnGun();
    }
    public void SpawnGun()
    {
        GunScriptableObject gun = Guns.Find(gun => gun.Type == Gun);

        if (gun == null)
        {
            Debug.LogError($"No GunScriptableObject found for GunTupe: {gun}");
            return;
        }
        ActiveGun = gun;
        gun.Spawn(GunParent, this);
    }
    
    public void TakeNewArm()
    {
        if (ActiveGun == null)
        {
            Debug.LogError($"No ActiveGun found for GunTupe: {ActiveGun}");
            return;
        }
        Gun = GunType.M4A1;
        ActiveGun.Remove();
        SpawnGun();

    }
}
