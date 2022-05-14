using UnityEngine;
using UnityEngine.SceneManagement;
public class MenadzerIgre : MonoBehaviour {

    bool IgraJeZavrsena = false;
    public float VremeRestarta = 2f;
    public GameObject ZavrsenLevel;

    public void CompleteLevel()
    {
        ZavrsenLevel.SetActive(true);
    }

    public void KrajIgre()
        {
            if (IgraJeZavrsena == false)
            {
                IgraJeZavrsena = true;
                Debug.Log("GAME OVER");
                Invoke("Restart", VremeRestarta);
            }
        }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
