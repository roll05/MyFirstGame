using UnityEngine;

public class PracenjeIgraca : MonoBehaviour {

    public Transform igrac;
    public Vector3 pozicija;
	
	void Update ()
    {
        transform.position = igrac.position + pozicija;
	}
}
