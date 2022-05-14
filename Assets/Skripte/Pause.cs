using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {


    public static bool IgrajePauzirana = false;
    public GameObject PauzirajIgru;
	
	void FixedUpdate () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IgrajePauzirana)
            {
                Resume();

            }

            else

            {

                Pausee();

            }
        }

    }
    public void Resume()
    {
        PauzirajIgru.SetActive(false);
        Time.timeScale = 1f;
        IgrajePauzirana = false;
    }
    void Pausee()
    {
        PauzirajIgru.SetActive(true);
        Time.timeScale = 0f;
        IgrajePauzirana = true;
    }
    public void UcitajMeni()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("PocetnaStrana");
    }
    public void IzadjiIzIGre()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
