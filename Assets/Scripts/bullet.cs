using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour {

    public float k = 2;
    public Text info;
    public GameObject plan;

    public float F = 1;

    Rigidbody rb;
    ConstantForce f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        f = GetComponent<ConstantForce>();
		
	}
	
	// Update is called once per frame
	void Update () {
        //info.text = string.Format("V = {0}", rb.velocity.ToString());
        //f.force = 7*Vector3.up;
        


    }


    private void FixedUpdate()
    {

        //plan.transform.rotation = Quaternion.`
        //rb.AddForce(- k * transform.position);

        //rb.AddForce(F * new Vector3(Input.GetAxis("Horizontal"), 0, F * Input.GetAxis("Vertical")));
        if (SystemInfo.supportsAccelerometer)
        {
            Vector3 acc = Input.acceleration;
            rb.AddForce(F * new Vector3(acc.x, 0, acc.y));
            info.text = "Acceleration: " + acc;

        } else
        {

            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            rb.AddForce(F * new Vector3(h, 0, v));
            info.text = "Axis: " + h + "/" + v;

        }



    }


}
