using UnityEngine;

public class PlayerControler : MonoBehaviour 
{
    [Header("Movement Speed")]
    public float ForwardSpeed = 15f, ControlSpeed = 10f;

    [Header("Rotation Settings")]
    public float PitchFactor = -2f, WingsRotation = -4f;

    void Update()
    {
        float HorizontalMove = Input.GetAxis("Horizontal");
        float VerticalMove = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(HorizontalMove * ControlSpeed, VerticalMove * ControlSpeed, ForwardSpeed);
        transform.Translate(movement * Time.deltaTime, Space.World);

        float Pitch = PitchFactor * VerticalMove;
        float Roll = WingsRotation * HorizontalMove;

        transform.localRotation = Quaternion.Euler(Pitch, 0f, Roll);
    }
}