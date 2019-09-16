using UnityEngine;

namespace MP.BALL
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private float speedY=0f;
        [SerializeField] private float horizontal=0f;
        [SerializeField] private Rigidbody2D rigidbody=null;
        [SerializeField] private float speedX=0f;

        public float SpeedX
        {
            get { return speedX; }
            set { speedX = value; }
        }
        public float SpeedY
        {
            get { return speedY; }
            set { speedY = value; }
        }
        public float Horizontal
        {
            get { return horizontal; }
            set { horizontal = value; }
        }

        public Rigidbody2D Rigidbody
        {
            get { return rigidbody; }
            set { rigidbody = value; }
        }
    }
}