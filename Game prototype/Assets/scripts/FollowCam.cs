using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    Vector3 cameraLookAt;
    Vector3 offset;

    Quaternion camRotation;

    [SerializeField]
    Transform playerposition;
    Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 9, 1);
        cameraTransform = transform;
        cameraLookAt = new Vector3(playerposition.position.x, playerposition.position.y, playerposition.position.z);
        camRotation = Quaternion.Euler(84, -9, -9);
    }

    // Update is called once per frame
    void Update()
    {
        cameraTransform.LookAt(playerposition);
        cameraTransform.position = playerposition.position + offset;
        cameraTransform.rotation = camRotation;
    }
}
