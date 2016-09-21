using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class ActorController : MonoBehaviour {

    public Rigidbody2D rb;
    public Collider2D col;
    public SpriteRenderer sr;

    public float speed = 1.0f;
    public string direction = "up";
    public
	void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
    }
	void Update () {
	    
	}
    void FixedUpdate()
    {
        if(speed > 0 && gameObject.tag != "Player")
        {
            switch (direction)
            {
                case "up":
                    rb.velocity = new Vector2(0, speed);
                    break;
                case "down":
                    rb.velocity = new Vector2(0, -speed);
                    break;
                case "left":
                    rb.velocity = new Vector2(-speed, 0);
                    break;
                case "right":
                    rb.velocity = new Vector2(speed, 0);
                    break;
            }
        }
    }
}
