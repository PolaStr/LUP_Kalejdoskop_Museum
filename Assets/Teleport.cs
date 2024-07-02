using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player, destination;
    public GameObject VRplayer;

    void onTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            VRplayer.SetActive(false);
            player.position = destination.position;
            VRplayer.SetActive(true);
        }
    }
}