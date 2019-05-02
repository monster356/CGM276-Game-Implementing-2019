using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickMove : MonoBehaviour
{   
    public GameObject player;
    public void OnClick(Vector3 position)
    {
        var navPos = player.GetComponent<navigatePosition>();
        navPos.Navigate(position);

        var netMove = player.GetComponent<networkMove>();
        netMove.OnMove(position);
    }
}
