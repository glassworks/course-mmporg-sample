using UnityEngine;
using UnityEngine.SceneManagement;

public class PomeMenuUI : MonoBehaviour
{
    public void SetRole(bool isServer)
    {
        Global.IsServer = isServer;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
