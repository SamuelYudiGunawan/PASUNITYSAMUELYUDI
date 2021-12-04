using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovements : MonoBehaviour
{

    [Header("Movement")]
    [SerializeField] private float moveSpeed = 50f;

    [Header("Jumping")]
    [SerializeField] private float jumpForce = 500;
    [SerializeField] private int maxJump = 1;


    public Vector3 jump;
    public float jumpforce = 10.0f;
    public bool isGround = true;
    public bool IsGrounded
    {
        get
        {
            bool isGrounded = false;
            if (_collider && _rigidBodyComp) {

                isGrounded = Physics.Raycast(transform.position, -Vector3.up, (_collider.radius + 0.1f));

            }
            return isGrounded;
        }
    }

    int currentJump;
    Rigidbody _rigidBodyComp;
    SphereCollider _collider;

    private void Awake()
    {
        _rigidBodyComp = GetComponent<Rigidbody>();
        _collider = GetComponent<SphereCollider>();

        jump = new Vector3(0.0f, 6.0f, 0.0f);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement System
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        Vector3 dirMove = new Vector3(hAxis, 0f, vAxis);

        if (_rigidBodyComp)
            _rigidBodyComp.AddForce((dirMove * moveSpeed) * Time.deltaTime);
        //===================================================================

        //if (Input.GetKeyDown(KeyCode.Space) && isGround)
        //{ 
         //       isGround = false;
          //      _rigidBodyComp.AddForce(jump * jumpforce, ForceMode.Impulse)
        //}
            

        if (IsGrounded)
            currentJump = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
        }
    }
    public void Jump(float force)
    {

        currentJump++;

        if (_rigidBodyComp)
            _rigidBodyComp.AddForce((Vector3.up * force));

        Debug.Log("Jump Count : " + currentJump);

    }

    private void OnCollisionStay(Collision collision)
    {
        isGround = true;
    }

}
