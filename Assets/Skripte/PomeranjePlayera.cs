
using UnityEngine;

public class PomeranjePlayera : MonoBehaviour {

    public Rigidbody rb;

    public float JacinaSile = 2000f;
    public float JacinaSileZaSkretanje = 500f;
 
   
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, JacinaSile * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(JacinaSileZaSkretanje * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-JacinaSileZaSkretanje * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<MenadzerIgre>().KrajIgre();
        }

            
        
    }
}
