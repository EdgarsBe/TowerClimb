using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ContinuousMovementPhysics : MonoBehaviour
{
    public float speed = 1;
    public float turnSpeed = 60;
    public InputActionProperty turnInputSource;
    public InputActionProperty moveInputSource;
    public Rigidbody rb;
    public Transform rotationSource;
    public Transform directionSource;
    private Vector2 inputMoveAxis;
    public CapsuleCollider bodyColider;
    public LayerMask ground;
    private float inputTurnAxis;

    void Update()
    {
        inputMoveAxis = moveInputSource.action.ReadValue<Vector2>();
        inputTurnAxis = turnInputSource.action.ReadValue<Vector2>().x;
    }

    private void FixedUpdate()
    {
        bool isGrounded = CheckIfGrounded();

        if (isGrounded)
        {
            Quaternion yaw = Quaternion.Euler(0, directionSource.eulerAngles.y, 0);
            Vector3 direction = yaw * new Vector3(inputMoveAxis.x, 0, inputMoveAxis.y);

            rb.MovePosition(rb.position + direction * Time.fixedDeltaTime * speed);

            Vector3 axis = Vector3.up;
            float angle = turnSpeed * Time.fixedDeltaTime * inputTurnAxis;

            Quaternion q = Quaternion.AngleAxis(angle, axis);

            rb.MoveRotation(rb.rotation * q);

            Vector3 newPosition = q*(rb.position-rotationSource.position) + rotationSource.position;

            rb.MovePosition(newPosition);
        }
    }

    public bool CheckIfGrounded()
    {
        Vector3 start = bodyColider.transform.TransformPoint(bodyColider.center);
        float rayLength =  bodyColider.height / 2 - bodyColider.radius + 0.05f;

        bool hasHit = Physics.SphereCast(start, bodyColider.radius, Vector3.down, out RaycastHit hitinfo, rayLength, ground);

        return hasHit;
    }
}
