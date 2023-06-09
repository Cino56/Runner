using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("MainGamescence");
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainGamescence");
    }
}
