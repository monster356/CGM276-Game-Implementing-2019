using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class networkMove : MonoBehaviour
{
   public SocketIOComponent socket;

   public void OnMove(Vector3 position)
   {
       print("sending position to server!");
       JSONObject jsonObj = new JSONObject(Vecter3ToJson(position));
       socket.Emit("move",jsonObj);
   }

   string Vecter3ToJson(Vector3 vector)
   {
       string jsonString = string.Format(@"{{""x"":""{0}"",""y"":""{1}"",""z"":""{2}""}}", vector.x,vector.y,vector.z);
        return jsonString;
   }
}
