/*
Jake Hathaway
DGM 1610: Lab 3: PlayerController Script
6/13/2023
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
// Declare these variables at the top of the script, like so:
private CharacterController controller;
private Vector3 moveDirection;
private bool isJumping;
[SerializeField] private float moveSpeed = 5f;
[SerializeField] private float jumpForce = 5f;
[SerializeField] private float gravity = 9.81f;

    // Start is called before the first frame update
    void Start()
    {
        //Use GetCompnent to get a reference to the CharacterController component attached to the same GameObject as the script.
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //2.  retrieve the player's input for movement using `Input.GetAxis("Horizontal")` and `Input.GetAxis("Vertical")`. Store the values in separate float variables, such as `horizontalInput` and `verticalInput`.
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //3. Calculate the movement direction vector based on the input values and transform it relative to the player's rotation. Multiply it by the `moveSpeed` variable to adjust the speed of movement.
        controller.Move(move * Time.deltaTime * moveSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        //4. If the jump button is pressed and the player is grounded, set the `isJumping` flag to `true`.
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            moveDirection.y += Mathf.Sqrt(jumpForce * -3.0f * gravity);
        }

        //5. Apply gravity by subtracting the `gravity` value multiplied by `Time.deltaTime` from the `moveDirection.y` component. This simulates a constant downward force.
        moveDirection.y -= gravity * Time.deltaTime;

        //6. Move the player character using `controller.Move(moveDirection * Time.deltaTime)` to apply the movement vector to the CharacterController component.
        controller.Move(moveDirection * Time.deltaTime);
    }
}
