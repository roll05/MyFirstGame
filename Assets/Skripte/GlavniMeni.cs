using UnityEngine;
using UnityEngine.SceneManagement;

public class GlavniMeni : MonoBehaviour {

    public void PocetakIgre()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void KrajIgre()
    {
        Debug.Log("Izlaz");
        Application.Quit();
    }
}
