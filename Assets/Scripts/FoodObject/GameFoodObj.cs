﻿using Assets.DataObject;
using Assets.Scripts.Util.Channels.Abstracts;
using System;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

internal class GameFoodObj : NetworkBehaviour, IStateMachine<IFoodState, int>, IViewingElementsPosition
{
    public enum eThrowAnimationType { Throwing, Falling }

    public event Action OnCollect;
    public event Action Destruction;

    private ActionStateMachine m_Collector;

    protected Rigidbody m_Rigidbody;
    protected eThrowAnimationType m_AnimationType;

    [SerializeField]
    private Vector3 m_OffsetOnPlayerHande;
    [SerializeField]
    protected ThrownActionTypesBuilder m_TypeBuild;

    #region State
    protected IFoodState[] m_FoodStates;
    private int m_StatuIndex;
    public IFoodState CurrentState
    {
        get => m_FoodStates[m_StatuIndex];
    }

    public int Index
    {
        get => m_StatuIndex;
        protected set
        {
            CurrentState.OnStateExit();
            m_StatuIndex = value;
            tag = CurrentState.TagState;
            CurrentState.OnStateEnter();
        }
    }
    #endregion
    #region Pool
    public void Hide() => this.gameObject.SetActive(false);
    public void Show() => this.gameObject.SetActive(true);
    #endregion
    public bool IsUsed => throw new NotImplementedException();

    public bool IsUesed => throw new NotImplementedException();

    public bool Unused() => false;
    public void OnEndUsing() { /* Not-Implemented */}
    protected virtual void CollectInvoke() => OnCollect?.Invoke();
    internal bool CanCollect() => Index == UncollectState.k_Indx;
    internal eThrowAnimationType StopPowering() => m_AnimationType;
    internal Vector3 GetCollectorPosition() => m_Collector is null ? transform.position : m_Collector.PickUpPoint.position + m_OffsetOnPlayerHande;
    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        UncollectState uncollect = new UncollectState(this);
        IThrownState thrownState = m_TypeBuild.SetRigidbody(m_Rigidbody).SetTransform(transform);
        CollectState collectState = new CollectState(m_Rigidbody, transform, this);

        uncollect.Collect += Uncollect_Collect;
        m_AnimationType = m_TypeBuild.m_AnimationType;
        thrownState.OnReturnToPool += thrownState_OnReturnToPool;

        m_FoodStates = new IFoodState[]
        {
            uncollect,
            collectState,
            thrownState,
        };
    }

    protected void thrownState_OnReturnToPool()
    {
        ManagerGameFoodObj.Instance.ReturnToPool(this);
        CurrentState.OnStateExit();
    }

    private void OnEnable()
    {
        Index = 0;
    }
    #region Uncollect 
    protected void Uncollect_Collect(ActionStateMachine i_Collector)
    {
        if (i_Collector is not null)
        {
            m_Collector = i_Collector;
            this.transform.position = m_Collector.PickUpPoint.position;
            Index = CollectState.k_Indx;
            CollectInvoke();
        }
    }
    #endregion
    #region Collact
    #endregion
    #region Throwing
    public virtual void ThrowingAction(Vector3 i_Direction, float i_PowerAmount)
    {
        if (CurrentState.IsThrowingAction())
        {
            Index = ThrownState.k_Indx;
            IThrownState thrownState = CurrentState as IThrownState;
            thrownState.SetCollector(m_Collector);
            thrownState.SetThrowDirection(i_Direction, i_PowerAmount);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        IDamaging damaging = CurrentState as IDamaging;
        if (damaging is not null)
        {
            damaging.Activation(collision);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        IDamaging damaging = CurrentState as IDamaging;
        if (damaging is not null)
        {
            damaging.Activation(other);
        }
    }
    #endregion

    public void ViewElement(List<Vector3> elements)
    {
        if (CanCollect())
        {
            elements.Add(transform.position);
        }
    }

    private void Update()
    {
        CurrentState.Update();
    }

    public bool Unsed()
    {
        throw new NotImplementedException();
    }
}