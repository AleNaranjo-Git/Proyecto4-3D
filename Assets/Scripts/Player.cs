using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    public CharacterController player;

    public float playerSpeed;

    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        player.Move(new Vector3(horizontalMove, 0 , verticalMove) * Time.deltaTime * playerSpeed);
    }
}
