using UnityEngine;
using UnityEngine.UI;
using Zenject;
using MP.SCRIPTABLEOBJ;

namespace MP.UI
{
    public class MoonButton : MonoBehaviour
    {
        [SerializeField] private Button buttonMoon;
        [Inject] private SOMoon sOMoon;
        [Inject] private BackGround backGround;
        [Inject] private UI ui;

        void Start()
        {
            buttonMoon.onClick.AddListener(ButtonMoonCLick);
        }

        public void ButtonMoonCLick()
        {
            Physics2D.gravity = new Vector2(0, -sOMoon.Gravity);
            backGround.BackGroundColor(sOMoon.skyColor);
            ui.IsPlayMode = true;
            ui.IsMoon = true;
            ui.IsMenu = false;
        }
    }
}