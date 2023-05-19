using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5;

    public Vector3 currentRotation;
    // Start is called before the first frame update
    void Start()
    {
        
        
        currentRotation = new Vector3(currentRotation.x % 0f, currentRotation.y % 0f, currentRotation.z % -90f);

        Quaternion rotationZ = Quaternion.AngleAxis(currentRotation.z, new Vector3(0f, 0f, 1f));
        Quaternion rotationX = Quaternion.AngleAxis(currentRotation.x, new Vector3(1f, 0f, 0f));
        Quaternion rotationY = Quaternion.AngleAxis(currentRotation.y, new Vector3(0f, 1f, 0f));
        this.transform.rotation = rotationX * rotationY * rotationZ;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        Vector2 position = transform.position;

        position.x -= speed * Time.deltaTime;

        transform.position = position;

        
    }
    
}
