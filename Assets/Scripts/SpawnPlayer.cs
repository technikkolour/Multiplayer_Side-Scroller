using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        Invoke("Spawn", 3);
    }

    [PunRPC]
    public void Spawn()
    {
        Vector3 first = new Vector3(0, 0, 0);

        if (PhotonNetwork.CountOfPlayersInRooms > 1)
            PhotonNetwork.Instantiate(player.name, this.transform.position, Quaternion.identity);
        else
            PhotonNetwork.Instantiate(player.name, first, Quaternion.identity);
    }

}
