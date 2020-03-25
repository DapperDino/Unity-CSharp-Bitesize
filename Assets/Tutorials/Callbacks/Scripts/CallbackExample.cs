using UnityEngine;

namespace DapperDino.Tutorials.Callbacks
{
    public class CallbackExample : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log($"Awake: {name}");

            // Used to initialise where something must happen before
            // the initialisation of another script
        }

        private void OnEnable()
        {
            Debug.Log($"OnEnable: {name}");

            // Mainly used to subscribe to events
        }

        private void Start()
        {
            Debug.Log($"Start: {name}");

            // Used to initialise
        }

        private void FixedUpdate()
        {
            Debug.Log($"FixedUpdate: {name}");

            // Used when applying continuous force or other physics related
            // logic due to being in sync with the physics engine
            // 
            // Doesn't necessarily get called every frame
        }

        private void Update()
        {
            Debug.Log($"Update: {name}");

            // Used to run logic every frame for things that need
            // to be constantly updated
            // 
            // Will definitely be called every frame
        }

        private void LateUpdate()
        {
            Debug.Log($"LateUpdate: {name}");

            // Used to run logic every frame that has to happen after all
            // other scripts have had their Update method called. Such as
            // moving a camera to follow a player
            // 
            // Will definitely be called every frame
        }

        private void OnDisable()
        {
            Debug.Log($"OnDisable: {name}");

            // Mainly used to unsubscribe to events
        }

        private void OnDestroy()
        {
            Debug.Log($"OnDestroy: {name}");

            // Used to clean up anything that is no longer needed
            // now that either the script is being removed or the
            // gameobject is being destroyed
        }
    }
}
