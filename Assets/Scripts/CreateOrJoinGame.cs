using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateOrJoinGame : MonoBehaviourPunCallbacks
{
    public InputField createName;
    public InputField joinName;

    public void CreateGame()
    {
        PhotonNetwork.CreateRoom(createName.text);
    }

    public void JoinGame()
    {
        PhotonNetwork.JoinRoom(joinName.text);
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
