using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private float cameraSensitivity = 1f;
    [SerializeField]
    private GameObject chair = null;

    private GameState state = null;
    private Camera mainCam = null;
    private Rigidbody rb = null;

    // Start is called before the first frame update
    void Start()
    {
        state = GetComponent<GameState>();
        mainCam = transform.parent.GetComponentInChildren<Camera>();
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        LookAround();
    }

    private void Move()
    {
        rb.velocity = transform.forward * moveSpeed * state.zMoveMent + transform.right * moveSpeed * state.xMovement;
        chair.transform.localPosition = transform.localPosition;
    }

    private void LookAround()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * cameraSensitivity * state.mouseX, Space.World);
        mainCam.transform.Rotate(Vector3.right, Time.deltaTime * cameraSensitivity * -state.mouseY, Space.Self);
        chair.transform.eulerAngles = transform.eulerAngles;
    }
}
