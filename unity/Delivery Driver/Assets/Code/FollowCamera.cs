using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // this things position (camera) should be the same as the car's position

    [SerializeField] private GameObject thingToFollow;
    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
