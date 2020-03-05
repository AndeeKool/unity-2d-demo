using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject projectile;
    public float playerSpeed = 0.2f;
    public float fireDelay = 1f;
    private float timeSinceLastFire = 0f;


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

        if (verticalMovement != 0f || horizontalMovement != 0f)
        {
            Vector2 newPosition = new Vector2(horizontalMovement * playerSpeed, verticalMovement * playerSpeed);
            transform.Translate(newPosition);
        }

        //Add time from last frame to elapsed time.
        timeSinceLastFire += Time.deltaTime;

        //Can only shoot after defined time has elapsed.
        if (timeSinceLastFire >= fireDelay)
        {
            //Can shoot
        //Input.GetKeyDown(KeyCode.Space)
        if (Input.GetButton("Fire1")) {
            Debug.Log("Pew");

            Instantiate(projectile, transform.position + new Vector3(0f, 2f, 0f), transform.rotation);
            timeSinceLastFire = 0f;
        }

        }

    }
}
