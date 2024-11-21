using UnityEngine;
using UnityEngine.SceneManagement;

public class PomeMenuUI : MonoBehaviour
{
    public void SetRole(bool isServer)
    {
        Global.IsServer = isServer;
        StartGame();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Pong");
    }
}
