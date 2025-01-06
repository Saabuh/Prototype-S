using UnityEngine;

namespace PlayerScripts
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField]
        private IPlayerState _currentState;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

            _currentState = new StandingState();


        }

        // Update is called once per frame
        void Update()
        {

            //handle game inputs based on current state
            _currentState.Update();
            
            IPlayerState newState = _currentState.HandleInput();
            
            //change state if a new state is detected
            if (newState != null)
            {
                _currentState = newState;
            }


        }
    }
}
