using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPl : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        transform.position = player.transform.position + new Vector3(3f,0f,-3f);
    }
}
