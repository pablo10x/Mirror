﻿using Mirror;
using UnityEngine;


public class Room : NetworkRoomManager
{
    private NetworkRoomManager _manager;

    public override void Awake()
    {
        base.Awake();
        _manager = this;
    }

    public override void Start()
    {
        //base.Start();
        _manager.StartHost();
    }

    public override void OnStartHost()
    {
    }

    public override void OnStartClient()
    {
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
    }

    public override void OnRoomClientConnect(NetworkConnection conn)
    {
        base.OnRoomClientConnect(conn);
        conn.isReady = true;
        Debug.Log(conn.address);
    }
}