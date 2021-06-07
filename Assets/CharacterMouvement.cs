using System;
using System.Collections;
using System.Collections.Generic;
using Input;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMouvement : MonoBehaviour
{
    public Camera m_camera;
    
    private CustomInputSystem m_controls;
    private Animator m_animator;

    private Vector3 m_directionOfMove;
    
    private static readonly int m_speed = Animator.StringToHash("Forward");
    
    [SerializeField]
    private float m_turnSpeed=.4f;

    private float velocity;

    private void Awake()
    {
        m_controls = new CustomInputSystem();
        m_animator = GetComponent<Animator>();
    }
    
    
    // Update is called once per frame
    void Update()
    {
        var value = m_controls.Gameplay.Move.ReadValue<Vector2>();
        
        var speed = Mathf.Abs(value.x) + Mathf.Abs(value.y);
        speed = Mathf.Clamp(speed, 0f, 1f);
        speed = Mathf.SmoothDamp(m_animator.GetFloat(m_speed), speed, ref velocity, 0.1f);
        
        m_animator.SetFloat(m_speed, speed);

        m_directionOfMove = ExtractDirectionFromCamera();

        if (!(value.magnitude > 0.1f)) return;
        
        var moveVector = new Vector3(value.x, 0, value.y);
        var rotation = Quaternion.LookRotation(m_directionOfMove, Vector3.up)*Quaternion.LookRotation(moveVector);
        var lerpRotation = Quaternion.Lerp(transform.rotation, rotation, m_turnSpeed * Time.deltaTime);

        transform.rotation = lerpRotation;

    }

    private Vector3 ExtractDirectionFromCamera()
    {
        return Vector3.ProjectOnPlane(m_camera.transform.forward, Vector3.up);
    }

    private void OnEnable()
    {
        m_controls.Enable();
    }

    private void OnDisable()
    {
        m_controls.Disable();
    }
}
