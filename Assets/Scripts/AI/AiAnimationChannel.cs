﻿using Unity.Netcode;
using UnityEngine;

namespace Assets.Scripts.AI
{
    internal class AiAnimationChannel : NetworkBehaviour
    {
        public LayerMask m_Ground;

        private bool m_IsRunnig;
        private bool m_IsRunnigBack;

        private Vector3 m_Position;
        private PlayerAnimationChannel m_Channel;
        public bool IsGrounded { get; private set; }
        public Vector3 Position => transform.position;
        public bool IsRunnig
        {
            get => m_IsRunnig;
            private set
            {
                if (value ^ m_IsRunnig)
                {
                    m_IsRunnig = value;
                    m_Channel.SetPlayerAnimationToRun(m_IsRunnig);
                }
            }
        }
        public bool IsRunnigBack
        {
            get => m_IsRunnigBack;
            private set
            {
                if (value ^ m_IsRunnigBack)
                {
                    m_IsRunnigBack = value;
                    m_Channel.SetPlayerAnimationToRunBack(m_IsRunnig);
                }
            }
        }
        private void Awake()
        {
            IsRunnig = false;
            IsRunnigBack = false;
            m_Channel = GetComponentInChildren<PlayerAnimationChannel>();
            Debug.Assert(m_Channel is not null, "m_Channel is not null");
        }

        private void LateUpdate()
        {
            #region Position Update
            UpdateIsGrounded();
            Vector3 movment = Position - m_Position;
            m_Position = Position;
            #endregion
            if (IsGrounded && movment != Vector3.zero)
            {
                bool isRunForde = movment.z < float.Epsilon;
                IsRunnig = isRunForde;
                IsRunnigBack = !isRunForde;
            }
            else
            {
                IsRunnig = false;
                IsRunnigBack = false;
            }

        }
        private void UpdateIsGrounded()
        {
            float distToGround = 3f;
            IsGrounded = !Physics.Raycast(Position, -Vector3.up, (float)(distToGround + 0.1), m_Ground, QueryTriggerInteraction.UseGlobal);
        }
    }
}