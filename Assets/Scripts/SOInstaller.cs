using UnityEngine;
using Zenject;
using MP.SCRIPTABLEOBJ;

namespace MP.ZENJECT
{
    [CreateAssetMenu(fileName = "SOInstallers", menuName = "Create SO Installers")]
    public class SOInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private SOEarth soEarth;
        [SerializeField] private SOMoon soMoon;
        [SerializeField] private SOJupiter soJupiter;

        public override void InstallBindings()
        {
            Container.BindInstance(soEarth);
            Container.BindInstance(soMoon);
            Container.BindInstance(soJupiter);
        }
    }

}