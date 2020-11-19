using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void loadScene(int index = 0)
    {
        SceneManager.LoadScene(index);
    }
}
