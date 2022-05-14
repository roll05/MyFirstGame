using UnityEngine;
using UnityEngine.SceneManagement;

public class ZavrsenLevel : MonoBehaviour {

    public void UcitajNovLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
