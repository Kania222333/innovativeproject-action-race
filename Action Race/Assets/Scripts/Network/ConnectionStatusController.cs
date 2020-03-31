﻿using UnityEngine;
using Photon.Pun;
using System.Collections;

public class ConnectionStatusController : MonoBehaviourPunCallbacks
{
    [SerializeField] ConnectionStatusPanel connectionStatusPanel;

    [SerializeField] string joinRandomMessage = "Searching the available room...";
    [SerializeField] string joinRandomFailedMessage = "No room available!";
    [SerializeField] string createRoomMessage = "Creating the room ...";
    [SerializeField] string createRoomFailedMessage = "Create Room Fail";
    [SerializeField] string joinRoomMessage = "Joining to the room ...";

    public void ShowConnectionStatus()
    {
        connectionStatusPanel.SetActive(true);
    }

    public IEnumerator HideConnectionStatus()
    {
        yield return new WaitForSeconds(1.5f);
        connectionStatusPanel.SetActive(false);
    }

    public void SetJoinRandomFailedMessage()
    {
        connectionStatusPanel.Message = joinRandomFailedMessage;
    }
    public void SetJoinRandomMessage()
    {
        connectionStatusPanel.Message = joinRandomMessage;
    }

    public void SetCreateRoomMessage()
    {
        connectionStatusPanel.Message = createRoomMessage;
    }

    public void SetJoinRoomMessage()
    {
        connectionStatusPanel.Message = joinRoomMessage;
    }

    public void SetCreateRoomFailedMessage()
    {
        connectionStatusPanel.Message = createRoomFailedMessage;
    }
}