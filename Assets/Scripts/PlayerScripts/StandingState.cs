using UnityEngine;

namespace PlayerScripts
{

   public class StandingState : IPlayerState
   {
      
       //Changes state based on input detected
      public IPlayerState HandleInput()
      {

          //change to walk state if movement is detected
          if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
          {
              return new WalkState();
          }

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