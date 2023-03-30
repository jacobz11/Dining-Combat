using System;
using System.Diagnostics;
using UnityEngine;
using System.Collections;

namespace DiningCombat.Player.Offline.Movement
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    internal class OfflinePlayerMovement : PlayerMovementImplementor
    {
        private const string AxisMouseX = "Mouse X";

        void Update()
        {
            m_IsAnyMovement = false;
            RunBoostUpdate();
            MoveVertonta();
            MoveHorizontal();
            MoveRotating();

            if (Jump() && m_IsAnyMovement)
            {
                Ideal();
            }
        }

        private void RunBoostUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                StartCoroutine(BoostRunning());
            }
        }

        public override void MoveVertonta()
        {
            this.m_Vertical = Input.GetAxis("Vertical");
            base.MoveVertonta();
        }
        public override void MoveHorizontal()
        {
            this.m_Horizontal = Input.GetAxis("Horizontal");
            base.MoveHorizontal();
        }

        public override bool Jump()
        {
            if (Input.GetButtonDown("Jump"))
            {
                return base.Jump();
            }

            return false;
        }
        private void MoveRotating()
        {
            m_Movement.Rotate(Input.GetAxis(AxisMouseX));
        }

        private string GetDebuggerDisplay()
        {
            return "OfflinePlayerMovement";
        }
    }
}