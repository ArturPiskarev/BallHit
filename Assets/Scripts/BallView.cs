using UnityEngine;
using Zenject;

namespace MP.BALL
{
    public class BallView : MonoBehaviour
    {
        [Inject] public Ball ball;
        private Vector2 velocity;

        //Jump on axis Y
        private void OnCollisionEnter2D(Collision2D coll)
        {
            if (coll.gameObject.tag == "Platform"||coll.gameObject.tag=="Ground")
            {
                if (ball != null)
                {
                    velocity = ball.Rigidbody.velocity;
                    velocity.y = ball.SpeedY;
                    ball.Rigidbody.velocity = velocity;
                }

     
            }
        }

        //Move on horizontal axis
        private void FixedUpdate()
        {
            velocity = ball.Rigidbody.velocity;
            velocity.x = ball.Horizontal * ball.SpeedX;
            ball.Rigidbody.velocity = velocity;
        }
    }
}