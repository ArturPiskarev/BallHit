using UnityEngine;
using UnityEngine.UI;
using Zenject;
using MP.SCRIPTABLEOBJ;

namespace MP.UI
{
    public class JupiterButton : MonoBehaviour
    {
        [SerializeField] private Button buttonJupiter;
        [Inject] private SOJupiter sOJupiter;
        [Inject] private BackGround backGround;
        [Inject] private UI ui;

        void Start()
        {
            buttonJupiter.onClick.AddListener(ButtonJupiterCLick);
        }

        public void ButtonJupiterCLick()
        {
            Physics2D.gravity = new Vector2(0, -sOJupiter.Gravity);
            backGround.BackGroundColor(sOJupiter.skyColor);
            ui.IsPlayMode = true;
            ui.IsJupiter = true;
            ui.IsMenu = false;
        }
    }
}