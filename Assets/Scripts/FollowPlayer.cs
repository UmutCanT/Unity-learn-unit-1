using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    Vector3 mainCamOffset = new Vector3(0, 7, -7);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + mainCamOffset;
    }
}
