using UnityEngine;

namespace Assets.Character.Enemy.Scripts.Fear
{
    public class FearEnemyController : EnemyController
    {
        Rigidbody2D Rb;

        [SerializeField] bool IsRightPatrol;

        private void Start()
        {
            Rb = GetComponent<Rigidbody2D>();
            IsRightPatrol = false;   
        }

        private void FixedUpdate()
        {
            Patrol();
        }

        protected override void Patrol()
        {
            if(!IsRightPatrol)
            {
                MoveEnemyLeft();

                VerifyPatrolLeft();
            }

            else
            {
                MoveEnemyRight();

                VerifyPatrolRight();
            }

        }

        private void MoveEnemyLeft()
        {
            if (gameObject.transform.position.x >= PointsPatrol.InitialPoint.x)
                Rb.velocity = -(Speed * Time.deltaTime * PointsPatrol.InitialPoint);
        }
        private void MoveEnemyRight()
        {
            if (gameObject.transform.position.x <= PointsPatrol.FinalPoint.x)
                Rb.velocity = (Speed * Time.deltaTime * PointsPatrol.InitialPoint);
        }
        private void VerifyPatrolLeft()
        {
            if (gameObject.transform.position.x <= PointsPatrol.InitialPoint.x)
                IsRightPatrol = true;
        }
        private void VerifyPatrolRight()
        {
            if (gameObject.transform.position.x >= PointsPatrol.FinalPoint.x)
                IsRightPatrol = false;
        }

    }

}
