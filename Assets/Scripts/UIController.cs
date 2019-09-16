using UnityEngine;
using Zenject;

namespace MP.UI
{
    public class UIController : MonoBehaviour
    {
        [Inject] private UI ui;

        private void FixedUpdate()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                if (Input.GetKey(KeyCode.Home) || Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Menu))
                {
                    ui.IsMenu = true;
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.Escape))
                {
                    ui.IsMenu = true;
                }
            }
        }
#if UNITY_EDITOR
        void OnValidate()
        {
            //ui.Score= transform.Find("Score").gameObject;
            //ui.Earth = transform.Find("Earth").gameObject;
            //ui.Moon = transform.Find("Moon").gameObject;
            //ui.Jupiter = transform.Find("Jupiter").gameObject;

        }
#endif
    }
}