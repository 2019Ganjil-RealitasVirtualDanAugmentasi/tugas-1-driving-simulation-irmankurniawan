using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float power = 100.0f;

    private float _horizontalInput;
	private float _verticalInput;

    private float turnSpeedMultiplier = 25f;
    private float baseTurnSpeed = 200f;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0.0f, 0.0f, _verticalInput);
        rb.AddForce(transform.forward * -_verticalInput * power);

        float rotation = _horizontalInput * power * turnSpeedMultiplier * Time.fixedDeltaTime;
        transform.Rotate(0, rotation, 0);
    }
}
