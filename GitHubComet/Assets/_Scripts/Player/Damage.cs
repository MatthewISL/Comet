using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ProjectileScript projectile = collision.GetComponent<ProjectileScript>();
        if(projectile != null)
        {
            if (projectile.isEnemy)
            {
                Destroy(gameObject);
                Destroy(projectile.gameObject);
                SceneManager.LoadScene("Main Menu");
            }
        }
        Destruction destruction = collision.GetComponent<Destruction>();
        if (destruction != null)
        {
            Destroy(gameObject);
            Destroy(destruction.gameObject);
            SceneManager.LoadScene("Main Menu");
        }
    }
}
