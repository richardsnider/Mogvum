using UnityEngine;
using Assets.Scripts.Testing;

namespace Assets.Scripts.Components
{
    class UnitTestRunner : MonoBehaviour
    {
        void Start()
        {
            Tests tests = new Tests();

            tests.GamePersistence();

            Debug.Log("Finished tests");
        }
    }
}
