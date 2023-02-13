using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public List<Weapon> weapons;
    public int firstWeapon = 0;
    private Weapon _currentWeapon;
    // Start is called before the first frame update
    void Start()
    {
        if (weapons != null)
        {
            _currentWeapon = weapons[firstWeapon];
        }
    }

        // Update is called once per frame
        void Update()
    {
    }
}
