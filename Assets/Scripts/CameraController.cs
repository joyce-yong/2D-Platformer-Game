using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform player;

    private void Update()
    {
        // low case transform because this refer to the camera controller it self
        //transform.position.z means keep own camera z value
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
