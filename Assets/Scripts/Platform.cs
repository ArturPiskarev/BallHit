using UnityEngine;

namespace MP.PlATFORM
{
    public class Platform : MonoBehaviour
    {
        [SerializeField] private int score = 0;

        [SerializeField] private SpriteRenderer spriteRenderer = null;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public SpriteRenderer SpiteRenderer
        {
            get { return spriteRenderer; }
            set { spriteRenderer = value; }
        }

        private void OnCollisionEnter2D(Collision2D ball)
        {
            if (ball.gameObject.tag == "Player")
            {
                Score += 1;
                SpiteRenderer.color = new Color(RandomForColor(), RandomForColor(), RandomForColor(), RandomForColor());
            }
        }

        //random variable as part of random color
        private float RandomForColor()
        {
            return Random.Range(0f, 1f);
        }
    }
}
