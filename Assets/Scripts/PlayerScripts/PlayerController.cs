using System;
using UnityEngine;

namespace PlayerScripts
{
    [Serializable]
    public class PlayerController : MonoBehaviour
    {

        [SerializeReference]
        private IPlayerState _currentState;

        public float playerSpeed = 5.0f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _currentState = new StandingState();
            
        }

        // Update is called once per frame
        void Update()
        {
            
            IPlayerState newState = _currentState.HandleInput();
            
            //change state if a new state is detected
            if (newState != null)
            {
                _currentState.Exit();
                
                // //debug
                // Debug.Log("Exiting " + _currentState.GetType().Name);
                
                _currentState = newState;
                _currentState.Enter();
                
                // //debug
                // Debug.Log("Entering " + _currentState.GetType().Name);
            }

            //handle game inputs based on current state
            _currentState.Update(this);

        }
    }
}
