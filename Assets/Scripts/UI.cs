using UnityEngine;


namespace MP.UI
{
    public class UI : MonoBehaviour
    {
        [SerializeField] private GameObject btnEarth;
        [SerializeField] private GameObject btnMoon;
        [SerializeField] private GameObject btnJupiter;
        [SerializeField] private GameObject score;
        [SerializeField] private bool isEarth;
        [SerializeField] private bool isMoon;
        [SerializeField] private bool isJupiter;
        [SerializeField] private bool isMenu;
        [SerializeField] private bool isPlayMode;

        public GameObject Earth
        {
            get { return btnEarth; }
            set { btnEarth = value; }
        }
        public GameObject Moon
        {
            get { return btnMoon; }
            set { btnMoon = value; }
        }
        public GameObject Jupiter
        {
            get { return btnJupiter; }
            set { btnJupiter = value; }
        }
        public GameObject Score
        {
            get { return score; }
            set { score = value; }
        }
        public bool IsEarth
        {
            get { return isEarth; }
            set { isEarth = value; }
        }
        public bool IsMoon
        {
            get { return isMoon; }
            set { isMoon = value; }
        }
        public bool IsJupiter
        {
            get { return isJupiter; }
            set { isJupiter = value; }
        }
        public bool IsMenu
        {
            get { return isMenu; }
            set { isMenu = value; }
        }
        public bool IsPlayMode
        {
            get { return isPlayMode; }
            set { isPlayMode = value; }
        }
    }
}