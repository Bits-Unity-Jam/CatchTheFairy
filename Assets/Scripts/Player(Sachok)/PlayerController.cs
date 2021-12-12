using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    //public float maxSpeed;
    private Vector3 _rotation;
    [HideInInspector]public Rigidbody2D _rb;
    [HideInInspector]public Animator _anim;
    public ParticleSystem _PlayerConPartical;
    private SpriteRenderer _spriteRend;
    public static PlayerController _playerInstance { get; private set; }
    //public ControlType controlType;
    public GameObject btnLeft;
    public GameObject btnRight;

    //public enum ControlType { PC, Android };

    private Vector2 _velocity;
    private bool _stopMove;
    private Vector3 _inputMovePC;
    private Vector3 _inputMoveAndroid;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();

        //controlType = AndroidControl.GetControlType();

        //if (controlType == ControlType.PC)
        //{
        //    btnLeft.gameObject.SetActive(false);
        //    btnRight.gameObject.SetActive(false);
        //}
        _playerInstance = this;
    }

    void Start()
    {
        _spriteRend = GetComponentInChildren<SpriteRenderer>();
        //_PlayerConPartical = GetComponentInChildren<ParticleSystem>();
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {

        //controlType = AndroidControl.GetControlType();

        if (_rb.velocity.x < 0)
        {
            _spriteRend.flipX = true;
        }
        else
        {
            _spriteRend.flipX = false;
        }
    }
    private void FixedUpdate()
    {
         _inputMovePC = new Vector3(0, 0, Input.GetAxis("Horizontal"));
         _rotation = _inputMovePC * -_rotationSpeed;
        
        if (Input.GetAxis("Horizontal") == 0)
        {
            _rotation = _inputMoveAndroid * -_rotationSpeed;
        }

        if (!_stopMove)
        {
            transform.Rotate(_rotation);
        }
        
    }

    public void OnBtnLeftDown()
    {
        _inputMoveAndroid = new Vector3(0, 0, -1);
    }
    public void OnBtnRightDown()
    {
        _inputMoveAndroid = new Vector3(0, 0, 1);
    }

    public void OnBtnUp()
    {
        _inputMoveAndroid = new Vector3(0, 0, 0);
    }

    public void StopMove()
    {
        _stopMove = true;
        _velocity = _rb.velocity;
        _rb.bodyType = RigidbodyType2D.Static;
    }
    public void ContinueMove()
    {
        _stopMove = false;
        _rb.bodyType = RigidbodyType2D.Dynamic;
         _rb.velocity = _velocity ;
    }

}

