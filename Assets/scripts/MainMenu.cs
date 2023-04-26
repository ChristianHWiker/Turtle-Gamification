using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OpenScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

}
