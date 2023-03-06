using UnityEngine;
using UnityEngine.InputSystem;

[DisallowMultipleComponent]
public class PlayerAction : MonoBehaviour
{
    [SerializeField]
    private PlayerGunSelector GunSelector;

    private void Update()
    {
        if (Mouse.current.leftButton.isPressed && GunSelector.ActiveGun != null)
        {
            GunSelector.ActiveGun.Shoot();
        }

        if (Mouse.current.rightButton.isPressed && GunSelector.ActiveGun != null)
        {
            GunSelector.TakeNewArm();
        }

    }
}
