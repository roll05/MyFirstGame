using UnityEngine.SceneManagement;
using UnityEngine;

public class Unmute : MonoBehaviour {

    bool Zvuk = false;
    public GameObject AudioClip;

    public void Zvukovi()
    {
        AudioClip.SetActive(true);
    }

    public void Mutiraj()
    {
        if (Zvuk == false)
        {
            Zvuk = true;
        }

    }

}
