using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpUpBall : AbstractSphere
{
    //[SerializeField]private float _currentSphereActionTime;
    //public override float sphereActionTime { get ; set ; }
    [SerializeField] private float _boostJumpForce;

    

    public override void AffectOnPlayer()
    {
        _onCollisionPlat._forceUP = _boostJumpForce;
    }

    public override void EndAffectOnPlayer()
    {
        _onCollisionPlat._forceUP = _onCollisionPlat._defaultForceUP;
    }
}
