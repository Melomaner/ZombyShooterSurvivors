using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public CharacterController Ch_Controller;
    public Vector2 Moveble;
    void Start()
    {

    }

    void Update()
    {
        Ch_Controller.Move(Moveble * Time.deltaTime);
    }
}
