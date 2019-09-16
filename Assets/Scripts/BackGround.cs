using UnityEngine;

namespace MP.UI
{
    public class BackGround : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer = null;

        public SpriteRenderer SpriteRenderer
        {
            get { return spriteRenderer; }
            set { spriteRenderer = value; }
        }
        //Change Color
        public void BackGroundColor(Color color)
        {
            spriteRenderer.color = new Color(color.r, color.g, color.b);
        }
    }
}