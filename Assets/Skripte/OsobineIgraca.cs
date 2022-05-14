using UnityEngine;

public class OsobineIgraca : MonoBehaviour {

    public PomeranjePlayera pomeranje;
    void OnCollisionEnter(Collision collisionInfo)
        
    {
       

        if (collisionInfo.collider.tag == "Prepreke")
        {
            pomeranje.enabled = false;
            FindObjectOfType<MenadzerIgre>().KrajIgre();
        }
    }
}
