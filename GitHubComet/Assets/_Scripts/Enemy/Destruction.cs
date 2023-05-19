using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destruction : MonoBehaviour
{
    public int score = 0;
    public int scoreValue = 100;

    bool Active = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < 9.5f)
        {
            Active = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!Active)
        {
            return;
        }
        ProjectileScript projectile = collision.GetComponent<ProjectileScript>();
        if(projectile != null)
        {
            if (!projectile.isEnemy)
            {
                Score.scorePoints += scoreValue;
                Destroy(gameObject);
                Destroy(projectile.gameObject);
            }
            
        }
    }
    
}
