using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundery : MonoBehaviour
{
    private Vector2 boundary;
    public float playerWidth;
    public float playerHeight;
    // Start is called before the first frame update
    void Start()
    {
        boundary = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        playerWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        playerHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPosition = transform.position;
        viewPosition.x = Mathf.Clamp(viewPosition.x, boundary.x, boundary.x * -1 -playerWidth);
        viewPosition.y = Mathf.Clamp(viewPosition.y, boundary.y, boundary.y * -1 -playerHeight);
        transform.position = viewPosition;
    }
}
