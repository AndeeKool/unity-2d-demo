using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject projectile;
    public float fireDelay = 1f;
    private float timeSinceLastFire = 0f;
    public int onFireProjectileCount = 3;
    private float maxPositionX = 1f;
    private float minPositionX = 0f;
    private bool movingRight = true;
    public float movementSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //Screen size
        //Screen.width

        //Sprite size
        // SpriteRenderer sr = GetComponent<SpriteRenderer>();
        // float spriteWidth = sr.sprite.rect.width;

        // maxPositionX = Screen.width - (spriteWidth / 2);
        // minPositionX = 0 + (spriteWidth / 2);
    }

    // Update is called once per frame
    void Update()
    {
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);

        if (movingRight)
        {
            Debug.Log("Moving Right");
            //move right
            transform.Translate(new Vector2(movementSpeed, 0f));
            //Check if reaches the top limit in X.
            if (pos.x >= maxPositionX)
            {
                //Now move to left
                movingRight = false;
            }
        }
        else
        {
            Debug.Log("Moving Left");
            //move left
            transform.Translate(new Vector2(-movementSpeed, 0f));
            //Check if reaches the bottom limit in X.
            if (pos.x <= minPositionX)
            {
                //Now move to right
                movingRight = true;
            }
        }

        //Add time from last frame to elapsed time.
        timeSinceLastFire += Time.deltaTime;

        if (timeSinceLastFire >= fireDelay) {
            //Shoot 3 times.
            for(int i = 0; i <= onFireProjectileCount; i++){
            Instantiate(projectile, transform.position + new Vector3(0f, -2f, 0f), Quaternion.Euler(new Vector3(0, 0, 180)));
            i++;
            //projectile.maxYPosition = -100;
            }
            timeSinceLastFire = 0f;
        }
    }
}
