using MP.BALL;
using UnityEngine;
using Zenject;

namespace MP.UI
{
    public class UIView : MonoBehaviour
    {
        [Inject] private UI ui;
        [Inject] private BackGround backGround;
        [Inject] private Ball ball;

        void Start()
        {
            ui.IsMenu = true;
        }

        void Update()
        {
            if (ui.IsEarth || ui.IsMoon || ui.IsJupiter && ui.IsPlayMode)
            {
                SetActiveMenu(false,-1);
                ui.IsPlayMode = true;
            }

            if (ui.IsMenu)
            {
                SetActiveMenu(true,1);
                ball.gameObject.SetActive(false);
                backGround.SpriteRenderer.color=new Color(160,160,160);
            }

            if (ui.IsPlayMode)
            {
                ball.gameObject.SetActive(true);
            }
        }
        //Set active or not MainMenu
        private void SetActiveMenu(bool isActive,int orderInLayer)
        {
            ui.Earth.SetActive(isActive);
            ui.Moon.SetActive(isActive);
            ui.Jupiter.SetActive(isActive);
            ui.Score.gameObject.SetActive(isActive);
            backGround.SpriteRenderer.sortingOrder = orderInLayer;
        }
    }
}