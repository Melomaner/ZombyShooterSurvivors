using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public CharacterController Ch_Controller;
    public float Speed;
    private Vector3 _moveble = new Vector3();
    private string _axisConstantX;
    private string _axisConstantY;

    void Start()
    {
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Move();
    }
    public void Move()
    {
        _moveble.x = Input.GetAxis("Horizontal");
        _moveble.z = Input.GetAxis("Vertical");
        Ch_Controller.Move(_moveble * Speed * Time.deltaTime);
    }
}
