using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField] private Transform player;
    [SerializeField] private float offsetY;
    private float posZinit;

    private void Start()
    {
        posZinit = transform.position.z;

    }

    private void Update()
    {
        transform.position = new Vector3( player.position.x,player.position.y + offsetY, posZinit);
    }
}
