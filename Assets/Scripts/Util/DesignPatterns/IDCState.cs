﻿using System;
namespace DiningCombat.Util.DesignPatterns
{
    public interface IDCState
    {
        public enum eState
        {
            WaitingToEntr = 0,
            EntringToTheState = 1,
            CurrentState = 2,
            ExitingState = 3,
            FinishedState = 4,
        }
        void OnStateExit();

        void OnStateEnter();

        void AddListener(Action<EventArgs> i_Action, eState i_State);
    }
}