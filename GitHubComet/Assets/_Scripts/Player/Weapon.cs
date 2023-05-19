using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public ProjectileScript projectile;

    public bool autoShoot = false;
    public float shootInterval = 0.5f;
    public float shootDelay = 2.0f;
    public float shootTimer = 0f;
    public float delayTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < 10.7f)
        {
            if (autoShoot)
            {
                if (delayTimer >= shootDelay)
                {
                    if (shootTimer >= shootInterval)
                    {
                        Shoot();
                        shootTimer = 0;
                    }
                    else
                    {
                        shootTimer += Time.deltaTime;
                    }
                }
                else
                {
                    delayTimer += Time.deltaTime;
                }
            }
        }
        
    }

    public void Shoot()
    {
        GameObject go = Instantiate(projectile.gameObject, transform.position, Quaternion.identity);
    }
}
