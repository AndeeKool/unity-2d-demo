using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = Input.GetAxis("Vertical");
        float horizontalMovement = Input.GetAxis("Horizontal");

        // if (verticalMovement != 0f || horizontalMovement != 0f) {
        //     Vector2 newPosition = new Vector2(0f, (verticalMovement * 0.1f));
        //     transform.Translate(newPosition);
        // }

        // if (horizontalMovement != 0f) {
        //     Vector2 newPosition = new Vector2((horizontalMovement * 0.1f), 0f);
        //     transform.Translate(newPosition);
        // }

        if (verticalMovement != 0f || horizontalMovement != 0f) {
            Vector2 newPosition = new Vector2(horizontalMovement * 0.1f, verticalMovement * 0.1f);
            transform.Translate(newPosition);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Pew");

            Instantiate(projectile, transform.position + new Vector3(0f, 2f, 0f), transform.rotation);
        }
    }
}
