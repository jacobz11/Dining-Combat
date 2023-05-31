﻿using DiningCombat.Environment;
using DiningCombat.Player;
using DiningCombat.Util.DesignPatterns;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DiningCombat.Manger
{
    //TODO : arrange the code
    //TODO : Delete what you don't need
    public class GameManger : Singleton<GameManger>
    {
        [SerializeField]
        private AllPlayerSkinsSO m_Skins;
        [SerializeField]
        private GameObject m_AiPrifab;
        [SerializeField]
        private Room m_RoomDimension;
        [SerializeField]
        private NetworkBtnStrting m_NetworkBtn;
        [SerializeField]
        private GameStrting m_GameStrting;
        public GameOverLogic GameOverLogic { get; private set; }
        public int Cuntter { get; private set; }
        protected override void Awake()
        {
            base.Awake();
            GameOverLogic = gameObject.GetComponent<GameOverLogic>();
            Cuntter = 0;
        }

        private void Start()
        {
            TryStartOffline();
        }

        private void TryStartOffline()
        {
            GameObject[] data = GameObject.FindGameObjectsWithTag(GameGlobal.TagNames.k_DontDestroyOnLoad);

            if (data.Length == 0)
            {
                Debug.LogWarning($"No tagged object found in {GameGlobal.TagNames.k_DontDestroyOnLoad}");
                return;
            }

            if (!data[0].TryGetComponent<StaringData>(out StaringData o_StaringData))
            {
                Debug.Log("StaringData cant get");
                return;
            }

            if (!o_StaringData.IsOnline)
            {
                m_NetworkBtn.StartHost();
                GameStrting.Instance.AddNumOfPlyers(o_StaringData.m_NumOfAi);

                // instint Ai
                for (int i = 0; i < o_StaringData.m_NumOfAi; i++)
                {
                    GameObject ai = GameObject.Instantiate(m_AiPrifab, GameStrting.Instance.GatIntPosForPlayer(), Quaternion.identity);
                    ai.GetComponentInChildren<Renderer>().material = m_Skins;
                }
            }
            else
            {
                m_GameStrting.AddNumOfPlyers(1);
            }
        }

        public void AddCamera(GameObject i_Player)
        {
            Camera cam = i_Player.AddComponent<Camera>();
            cam.targetDisplay = Cuntter++;
        }

        public int GetTargetDisplay()
        {
            int targetDisplay = Cuntter;
            Cuntter++;
            return targetDisplay;
        }

        public IEnumerable<Vector3> GetPlayerPos(Transform i_Player)
        {
            return GameObject.FindGameObjectsWithTag(GameGlobal.TagNames.k_Player).Where(player => player.transform.position != i_Player.position).Select(player => player.transform.position);
        }
    }
}
