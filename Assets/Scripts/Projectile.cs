using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed = 0.5f;
    public int maxYPosition = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0f, projectileSpeed));

        if (transform.position.y > maxYPosition) {
            Destroy(gameObject);
        }
    }
}
