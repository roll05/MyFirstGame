using UnityEngine;

public class KrajIgre : MonoBehaviour {
    public MenadzerIgre menadzerIgre;

    void OnTriggerEnter()
    {
        menadzerIgre.CompleteLevel();
    }
}
