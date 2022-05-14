using UnityEngine;
using UnityEngine.SceneManagement;

public class Mute : MonoBehaviour {
    bool  Zvuk = true;
    public GameObject AudioClip;

    public void Zvukovi()
    {
        AudioClip.SetActive(true);
    }

    public void Mutiraj()
    {
        if (Zvuk == true)
        {
            Zvuk = false;
        }
      
    }
}
