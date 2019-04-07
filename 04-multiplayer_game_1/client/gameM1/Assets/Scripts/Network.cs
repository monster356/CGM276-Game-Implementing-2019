using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SocketIO;
public class Network : MonoBehaviour
{
    static SocketIOComponent socket;
    public GameObject playerPrefab;



    // Start is called before the first frame update
    void Start()
    {

        socket = GetComponent<SocketIOComponent>();
        socket.On("open", OnConnected);

        socket.On("spawn", OnSpawn);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnConnected(SocketIOEvent e)
    {
        print("connected");

        socket.Emit("move");

    }
    void OnSpawn(SocketIOEvent e)
    {
        // Vector3 position = new Vector3(Random.Range(-5.0f, 5.0f), 1, Random.Range(-5.0f, 5.0f));
        print("spawned");

        Instantiate(playerPrefab);

        //socket.Emit("move");

    }
}
