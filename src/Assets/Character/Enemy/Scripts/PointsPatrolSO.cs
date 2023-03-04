using UnityEngine;

namespace Assets.Character.Enemy.Scripts
{
    [CreateAssetMenu(fileName = "EnemyPointsPatrol", menuName = "ScriptableObjects/Enemy/PointsPatrol", order = 0)]
    public class PointsPatrolSO : ScriptableObject
    {
        public Vector2 InitialPoint;
        public Vector2 FinalPoint;
    }
}
