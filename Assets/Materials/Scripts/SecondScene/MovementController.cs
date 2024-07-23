using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

[RequireComponent(typeof(Rigidbody))]
public class MovementController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [Inject] private Rigidbody rb;
    [Inject] private AnimatorController _animatorController;
    private Quaternion targetRotation;

    private void Update()
    {
        float XInput = Input.GetAxis("Horizontal");
        float ZInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(ZInput, 0, -XInput) * moveSpeed;

        rb.velocity = moveDirection;

        if(moveDirection !=  Vector3.zero)
        {
            targetRotation = Quaternion.LookRotation(moveDirection);

            _animatorController.AnimateWalking();

            rb.rotation = Quaternion.Slerp(rb.rotation, targetRotation, moveSpeed);
        }
        else
        {
            _animatorController.StopAnimateWalking();
        }
    }
}
