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
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1f || Mathf.Abs(Input.GetAxis("Vertical")) > 0.1f)
        {
            hAxis = Input.GetAxis("Horizontal");
            vAxis = Input.GetAxis("Vertical");
            if(Mathf.Abs(hAxis) > Mathf.Abs(vAxis))
            {
                vAxis = 0;
            }
            else
            {
                hAxis = 0;
            }
        }
        else if(Mathf.Abs(Input.GetAxis("Horizontal")) < 0.1 && Mathf.Abs(Input.GetAxis("Vertical")) < 0.1f)
        {
            hAxis = 0.0f;
            vAxis = 0.0f;
        }
    }

}
