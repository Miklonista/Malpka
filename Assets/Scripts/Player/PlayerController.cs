using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region sfields

    [SerializeField]
    private CharacterController controller;
    [SerializeField]
    private Transform cam;
    [SerializeField]
    private float speed = 6f;
    [SerializeField]
    private float jumpVelocity = 2.0f;
    [SerializeField]
    private float jumpHeight = 2.0f;
    [SerializeField]
    private float g = 4 * 9.81f;

    #endregion
    private Animator playerAnimator;
    private bool isJump;
    private bool Ground;
    #region fields

    private readonly float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;
    private float groundedTimer;
    private Rigidbody rb;
    #endregion


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        GameEvents.Instance.onEnemyHeadTriggerEnter += PlayerBounce;
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        Movement();
        GroundCheck();
        Jump();
    }

    private void Movement()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");

        var direction = new Vector3(x, 0f, z).normalized;

        if (direction.magnitude >= 0.1f)
        {
            var targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            var angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            var moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
            playerAnimator.SetBool("run", true);
        }
        else
        {
            playerAnimator.SetBool("run", false);
        }
    }

    private void Jump()
    {
        jumpVelocity -= g * Time.deltaTime;
        if (Input.GetButtonDown("Jump"))
            if (groundedTimer > 0)
            {
                groundedTimer = 0;
                jumpVelocity += Mathf.Sqrt(jumpHeight * 2 * g);
                playerAnimator.SetBool("isJumping", true);

            }
            else
            {
                playerAnimator.SetBool("isJumping", false);


            }

        controller.Move(new Vector3(0f, jumpVelocity * Time.deltaTime, 0f));
    }

    private void PlayerBounce()
    {
        rb.AddForce(1000f * transform.up, ForceMode.Force);
    }
    private void GroundCheck()
    {
        var groundedPlayer = controller.isGrounded;
        if (groundedPlayer) groundedTimer = 0.2f;

        if (groundedTimer > 0) groundedTimer -= Time.deltaTime;
        {
            playerAnimator.SetBool("Ground", true);
            playerAnimator.SetBool("Float", false);
            playerAnimator.SetBool("isJumping", false);


        }
        if (groundedPlayer && jumpVelocity < 0) jumpVelocity = 1;
        
        if (jumpVelocity >2f) 
        {
            playerAnimator.SetBool("Float", true);
        }


    }
}