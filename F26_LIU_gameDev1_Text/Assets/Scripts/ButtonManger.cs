using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManger : MonoBehaviour
{
    //Variables

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
