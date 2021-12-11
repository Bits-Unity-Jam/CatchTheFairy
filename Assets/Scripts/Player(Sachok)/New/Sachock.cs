using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sachock : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed;
    [SerializeField]
    private float _jumpForce;

    public static Sachock Instance { get; private set; }

    private Rigidbody2D _rbSachock;
    private Animator _anim;

    private Vector3 _rotationVector;
    private Vector2 _tempVelocity;

    private float _velocityX;

    private bool _stopMove;

    private PlayerInput _playerInput;

    private BottomSachock _bottomSachock;

    #region Singleton
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    } 
    #endregion

    private void Start()
    {
        _rbSachock = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>();

        _playerInput = GetComponent<PlayerInput>();
        _bottomSachock = GetComponentInChildren<BottomSachock>();

        _bottomSachock.OnPlatformCollision.AddListener(OnPlatformCollision);
    }

    private void Update()
    {
        TurnToDiraction();
    }

    private void FixedUpdate()
    {
        if (!_stopMove)
        {
            RotateSachock(_playerInput.InputeValue);
        }
    }

    private void RotateSachock(float zRotate)
    {
        transform.Rotate(new Vector3(0, 0, zRotate* -_rotationSpeed));
    }

    private void TurnToDiraction()
    {
        if (_playerInput.InputeValue < 0 != _velocityX < 0)// преворот при зміні напрямку повороту
        {
            if (_playerInput.InputeValue == 0) return;
            _velocityX = _playerInput.InputeValue;
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
        
    }

    public void StopMove()
    {
        _stopMove = true;
        _tempVelocity = _rbSachock.velocity;
        _rbSachock.bodyType = RigidbodyType2D.Static;
    }
    public void ContinueMove()
    {
        _stopMove = false;
        _rbSachock.bodyType = RigidbodyType2D.Dynamic;
        _rbSachock.velocity = _tempVelocity;
    }

    private void OnPlatformCollision()
    {
        Jump();
        AnimationBounce();
    }

    private void AnimationBounce()
    {
        _anim.SetTrigger("Bounce");
    }

    private void Jump()
    {
        _rbSachock.velocity= new Vector3(0, 0, 0);
        _rbSachock.AddRelativeForce(Vector3.up * _jumpForce, ForceMode2D.Impulse);
    }
}
