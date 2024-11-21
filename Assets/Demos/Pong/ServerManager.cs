using UnityEngine;

public class ServerManager : MonoBehaviour
{
    public UDPReceiver udpReceiver;
    
    void Awake()
    {
        if (!Global.IsServer)
        {
            gameObject.SetActive(false);
        }
    }
    
    void Start()
    {
        udpReceiver.Listen((string message) =>
        {
            // do something with the message that arrived
            Debug.Log("From ServerManager : " + message);
        });
    }
}
