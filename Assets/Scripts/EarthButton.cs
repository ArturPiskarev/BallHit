using UnityEngine;
using UnityEngine.UI;
using Zenject;
using MP.SCRIPTABLEOBJ;
namespace MP.UI
{
    public class EarthButton : MonoBehaviour
    {
        [SerializeField] private Button buttonEarth;
        [Inject] private SOEarth sOEarth;
        [Inject] private BackGround backGround;
        [Inject] private UI ui;

        void Start()
        {
            buttonEarth.onClick.AddListener(ButtonEarthCLick);
        }

        public void ButtonEarthCLick()
        {
            //Change gravity
            Physics2D.gravity = new Vector3(0, -sOEarth.Gravity, 0);
            //Change color of BackGround
            backGround.BackGroundColor(sOEarth.skyColor);
            ui.IsPlayMode = true;
            ui.IsEarth = true;
            ui.IsMenu = false;
        }
    }
}
