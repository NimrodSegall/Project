using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public float xMovement, zMoveMent, mouseX, mouseY;

    [SerializeField]
    private float skyRotationSpeed = 1f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        GetInput();
        RotateSky();
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

    private void RotateSky()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyRotationSpeed);
    }
}
