using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterMovement : MonoBehaviour
{
    public Animator animator;
    public CharacterController characterController;
    public float moveSpeed = 3f;
    public float rotationSpeed = 10f; // New variable for rotation speed

    private bool isMoving = false;
    private Vector3 moveDirection;

    private void Start()
    {
        animator.SetBool("IsMoving", false);
    }

    private void Update()
    {
        if (isMoving)
        {
            // Move the character
            Vector3 movement = moveDirection * moveSpeed * Time.deltaTime;
            characterController.Move(movement);

            // Rotate the character
            Quaternion toRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }

    public void MoveLeft()
    {
        StartMoving(Vector3.left);
    }

    public void MoveRight()
    {
        StartMoving(Vector3.right);
    }

    public void MoveUp()
    {
        StartMoving(Vector3.forward);
    }

    public void MoveDown()
    {
        StartMoving(Vector3.back);
    }

    public void StopMoving()
    {
        isMoving = false;
        animator.SetBool("IsMoving", false);
    }

    private void StartMoving(Vector3 direction)
    {
        isMoving = true;
        animator.SetBool("IsMoving", true);
        moveDirection = direction;
    }
}
