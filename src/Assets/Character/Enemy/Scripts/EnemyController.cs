using Assets.Character.Enemy.Scripts;
using UnityEngine;

public abstract class EnemyController : MonoBehaviour
{
    [SerializeField] protected PointsPatrolSO PointsPatrol;
    [SerializeField] protected float Speed;

    protected abstract void Patrol();
}
