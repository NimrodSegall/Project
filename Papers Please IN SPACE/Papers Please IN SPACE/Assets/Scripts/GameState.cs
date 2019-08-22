using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public float xMovement, zMoveMent, mouseX, mouseY;

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        xMovement = Input.GetAxis("Horizontal");
        zMoveMent = Input.GetAxis("Vertical");

        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
    }

    public bool PlayerIsTryingToMove()
    {
        return (xMovement != 0 || zMoveMent != 0);
    }
}
