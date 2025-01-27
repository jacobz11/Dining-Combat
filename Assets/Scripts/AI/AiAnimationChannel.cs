﻿using DiningCombat.Player;
using Unity.Netcode;
using UnityEngine;

namespace DiningCombat.AI
{
    public class AiAnimationChannel : NetworkBehaviour
    {
        [SerializeField]
        private PlayerMovmentDataSO m_PlayerMovmentDataSO;
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
                }
            }
        }
        private void Awake()
        {
            IsRunnig = false;
            IsRunnigBack = false;
            m_Channel = GetComponentInChildren<PlayerAnimationChannel>();
            Debug.Assert(m_Channel is not null, "Player animation channel not found");
        }

        private void LateUpdate()
        {
            const float k_ScaleMovment = 10.0f;
            UpdateIsGrounded();
            Vector3 movment = Position - m_Position;
            m_Position = Position;
            if (IsGrounded && movment != Vector3.zero)
            {
                bool isRunForde = movment.z < float.Epsilon;
                IsRunnig = isRunForde;
                IsRunnigBack = !isRunForde;

                m_Channel.AnimationFloat(PlayerAnimationChannel.AnimationsNames.k_Forward, movment.x * k_ScaleMovment);
                m_Channel.AnimationFloat(PlayerAnimationChannel.AnimationsNames.k_Sides, movment.z * k_ScaleMovment);
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
            IsGrounded = !Physics.Raycast(Position, -Vector3.up, (float)(distToGround + 0.1), m_PlayerMovmentDataSO.m_Ground, QueryTriggerInteraction.UseGlobal);
        }
    }
}