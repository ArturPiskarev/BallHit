using UnityEngine;
using UnityEngine.UI;
using Zenject;
using MP.PlATFORM;
namespace MP.BALL
{
    public class BallController : MonoBehaviour
    {
        [Inject] private Ball ball;
        [Inject] private UI.UI ui;
        [SerializeField] private GameObject platform;
        

        private void Start()
        {
          // platformScript= platform.GetComponent<Platform>();
        }

        private void FixedUpdate()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                ball.Horizontal = Input.acceleration.x;
            }
            else
            {
                ball.Horizontal = Input.GetAxis("Horizontal");
            }

            
        }

        private void OnCollisionEnter2D(Collision2D platformColl)
        {
            if (platform.gameObject.tag == "Platform")
            {
                //Score in Menu
                ui.Score.GetComponent<Text>().text="Ball Hit: "+ Platform.Score;}
            }
        }
}

