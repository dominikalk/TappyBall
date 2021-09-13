using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]

public class PipeController : MonoBehaviour {

    public float speed;
    public float UpDownSpeed;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        movePipe();
        //InvokeRepeating("SwitchUpDown", 0.1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SwitchUpDown()
    {
        UpDownSpeed = -UpDownSpeed;
        rb.velocity = new Vector2(speed, UpDownSpeed);
    }

    void movePipe()
    {
        //rb.velocity = new Vector2(speed, UpDownSpeed);
        rb.velocity = new Vector2(speed, 0);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "PipeRemover")
        {
            Destroy(gameObject);
        }
    }
}
