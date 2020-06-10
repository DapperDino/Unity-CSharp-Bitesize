using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace DapperDino.Tutorials.SavingLoading
{
    public class SavingLoadingSimpleExample : MonoBehaviour
    {
        [SerializeField] private ExampleData exampleData = new ExampleData();

        [ContextMenu("Save")]
        private void Save()
        {
            //string json = JsonUtility.ToJson(exampleData);

            //File.WriteAllText($"{Application.persistentDataPath}/save.dap", json);

            var bf = new BinaryFormatter();

            FileStream file = File.Create($"{Application.persistentDataPath}/save.dap");

            bf.Serialize(file, exampleData);

            file.Close();
        }

        [ContextMenu("Load")]
        private void Load()
        {
            if (!File.Exists($"{Application.persistentDataPath}/save.dap")) { return; }

            //string json = File.ReadAllText($"{Application.persistentDataPath}/save.dap");

            //exampleData = JsonUtility.FromJson<ExampleData>(json);

            var bf = new BinaryFormatter();

            FileStream file = File.Open($"{Application.persistentDataPath}/save.dap", FileMode.Open);

            exampleData = (ExampleData)bf.Deserialize(file);

            file.Close();
        }
    }

    [Serializable]
    public class ExampleData
    {
        [SerializeField] private string name = "Nathan";
        [SerializeField] private int age = 19;
        [SerializeField] private bool hasWon = true;
    }
}
