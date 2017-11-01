﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// 遊玩狀態
public class PlayState : ISceneState
{
    public PlayState(SceneStateController Controller) : base(Controller)
    {
        this.StateName = "PlayState";
    }

    // 開始
    public override void StateBegin()
    {
        //PBaseDefenseGame.Instance.Initinal();
    }

    // 結束
    public override void StateEnd()
    {
        //PBaseDefenseGame.Instance.Release();
    }

    // 更新
    public override void StateUpdate()
    {
        // 遊戲邏輯
        //PBaseDefenseGame.Instance.Update();
        // Render由Unity負責

        // 遊戲是否結束
        //if( PBaseDefenseGame.Instance.ThisGameIsOver())
        //	m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuScene" );
    }
}