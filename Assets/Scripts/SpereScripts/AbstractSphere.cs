using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public abstract class AbstractSphere : MonoBehaviour
{
    private ParticleSystem _particalSphere;
    private AudioSource _audSphere;
    private float _particalPlayTime = 0.4f;
    protected ParticleSystem _particSysPlayer;
    protected PhysicsOfJump _onCollisionPlat;
    [SerializeField] private float _currentSphereActionTime;


    private float sphereActionTime;
    protected void Start()
    {
        sphereActionTime = _currentSphereActionTime;

        _audSphere = GetComponent<AudioSource>();
        _particalSphere = GetComponentInChildren<ParticleSystem>();

        _particSysPlayer = PlayerController._playerInstance._PlayerConPartical;
        _onCollisionPlat = PhysicsOfJump.instanceOnColl;
    }
    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _particSysPlayer?.Play();
            _audSphere.Play();
            _particalSphere.Play();
            AffectOnPlayer();
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
        _particSysPlayer?.Stop();
        EndAffectOnPlayer();
        Destroy(gameObject);
    }



}
