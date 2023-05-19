using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeapon : MonoBehaviour
{

    Weapon[] weapons;
    bool shoot;
    // Start is called before the first frame update
    void Start()
    {
        weapons = transform.GetComponentsInChildren<Weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        shoot = Input.GetKeyDown(KeyCode.K);
        if (shoot)
        {
            shoot = false;
            foreach(Weapon weapon in weapons)
            {
                weapon.Shoot();
            }
        }
    }
}
