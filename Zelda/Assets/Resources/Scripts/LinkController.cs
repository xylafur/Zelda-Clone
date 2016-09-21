using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ActorController))]
public class LinkController : MonoBehaviour {

    private ActorController ac;
    private float hAxis, vAxis;
    private bool horiz = false, vert = false;
	void Awake()
    {
        ac = GetComponent<ActorController>();
    }
	
	// Update is called once per frame
	void Update () {

        CheckInput();
        
	}
    void FixedUpdate()
    {
        ac.rb.velocity = new Vector2(hAxis, vAxis) * ac.speed;
    }

    void CheckInput()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.0f)
        {
            hAxis = Input.GetAxis("Horizontal");
            vAxis = 0.0f;
        }
        else if (Mathf.Abs(Input.GetAxis("Vertical")) > 0.0f)
        {
            vAxis = Input.GetAxis("Vertical");
            hAxis = 0.0f;
        }
        else
        {
            hAxis = 0.0f;
            vAxis = 0.0f;
        }
    }

}
