using UnityEngine;

namespace PlayerScripts
{
    public interface IPlayerState
    {

        //Changes state based in input detected
        IPlayerState HandleInput();

        //Called at every frame from the base player class
        void Update(PlayerController player);

        void Enter();

        void Exit();


    }
}
