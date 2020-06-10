using System;
using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.Tutorials.Collections
{
    public class CollectionsExample : MonoBehaviour
    {
        private Stack<string> names = new Stack<string>();

        private void Start()
        {
            names.Push("Nathan");
            names.Push("awidawd");

            Debug.Log(names.Peek());
            Debug.Log(names.Pop());
        }
    }
}
