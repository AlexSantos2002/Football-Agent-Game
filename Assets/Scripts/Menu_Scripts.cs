using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Scripts : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void OnLoadGameButtonClicked()
    {
        SceneManager.LoadScene("LoadGame");
    }

    public void OnCreateGameButtonClicked()
    {
        SceneManager.LoadScene("CreateGame");
    }
}
