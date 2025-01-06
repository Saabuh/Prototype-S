using UnityEngine;

namespace PlayerScripts
{

   public class WalkState : IPlayerState
   {
       
       //Changes state based on input detected
      public IPlayerState HandleInput()
      {

          //change to standing state if no movement is detected
          if (Input.GetAxisRaw("Horizontal") == 0 || Input.GetAxisRaw("Vertical") == 0)
          {
              //change to standing state
              return new StandingState();
          }

          //stay in current state
          return null;
      }

      public void Update()
      {
        
      }

      public void Enter()
      {
      }

      public void Exit()
      {
      }
   } 
    
}
