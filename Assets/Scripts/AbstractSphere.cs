using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public abstract class AbstractSphere : MonoBehaviour
{
    private ParticleSystem _particalSphere;
    private AudioSource _audSphere;
    private float _particalPlayTime = 0.5f;
    protected ParticleSystem _particSysPlayer;
    protected OnColliPlatform _onCollisionPlat;


    public abstract float sphereActionTime { set; get; }
    protected void Start()
    {
        _audSphere = GetComponent<AudioSource>();
        _particalSphere = GetComponentInChildren<ParticleSystem>();

        _particSysPlayer = PlayerController._playerInstance._PlayerConPartical;
        _onCollisionPlat = OnColliPlatform.instanceOnColl;
    }
    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //_player = collision.gameObject.GetComponent<PlayerController>();

            //_energyPartical = _player._energyPartical;
            //_particSysPlayer?.Play();
            //_player.maxSpeed = 15;

            _audSphere.Play();
            _particalSphere.Play();
            AffectOnPlayer();
            EndAffectOnPlayer();
            //OnColliPlatform.instanceOnColl._forceUP = _boostSpeed;

            Invoke("DisappearSpher", _particalPlayTime);
            Invoke("DestroySphere", sphereActionTime);
        }
    }

    public abstract void AffectOnPlayer();
    public abstract void EndAffectOnPlayer();
    private void DisappearSpher()
    {
        gameObject.SetActive(false);
    }
    private void DestroySphere()
    {
        Destroy(gameObject);
        EndAffectOnPlayer();
    }


}
