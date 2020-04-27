using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

namespace DapperDino.Tutorials.WebRequest
{
    public class WebRequestExample : MonoBehaviour
    {
        [SerializeField] private TMP_Text text = null;
        [SerializeField] private string myName = string.Empty;

        private void Start() => GetRequest();

        [ContextMenu("Get Request")]
        private void GetRequest() => StartCoroutine(GetRequestCoroutine());

        private IEnumerator GetRequestCoroutine()
        {
            using (UnityWebRequest webRequest = UnityWebRequest.Get($"https://api.agify.io/?name={myName}"))
            {
                yield return webRequest.SendWebRequest();

                var prediction = JsonUtility.FromJson<Prediction>(webRequest.downloadHandler.text);

                text.text = $"Your age: {prediction.age}";
            }
        }
    }

    public class Prediction
    {
        public string name;
        public int age;
        public int count;
    }
}
