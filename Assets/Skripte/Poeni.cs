using UnityEngine;
using UnityEngine.UI;

public class Poeni : MonoBehaviour {

    public Transform igrac;
    public Text poeniIgraca;

    
    void FixedUpdate()
    {
        poeniIgraca.text = igrac.position.z.ToString("0");
    }
}
