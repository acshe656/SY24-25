using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
    }

    // Update is called once per frame
    private Vector3 offset = new Vector3(0,5,-20);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
