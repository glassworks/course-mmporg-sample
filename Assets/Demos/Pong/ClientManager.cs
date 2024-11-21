using UnityEngine;

public class ClientManager : MonoBehaviour
{
    public UDPSender udpSender;
    
    void Awake()
    {
        if (Global.IsServer)
        {
            gameObject.SetActive(false);
        }
        
    }

    void Start()
    {
        // On envoie au receiver
        udpSender.SendUDPMessage("Hello World");
    }
}
