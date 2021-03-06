using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class SpawnIn : NetworkBehaviour
{
    void OnGUI() {
        GUILayout.BeginArea(new Rect(10,10,300,300));
        if (!NetworkManager.Singleton.IsClient && !NetworkManager.Singleton.IsServer)
        {
            StartButtons();
        }
        GUILayout.EndArea();
    }
    public void StartButtons() {
        if (GUILayout.Button("Client")) {
            NetworkManager.Singleton.StartClient();
            //ulong? prefabHash = NetworkObject.GetPrefabHashFromGenerator("player2");
            //callback(true, prefabHash, Quaternion.identity);
        }
        
        if (GUILayout.Button("Host")) {
            NetworkManager.Singleton.StartHost();
        }

        if (GUILayout.Button("Server")) {
            NetworkManager.Singleton.StartServer();
        } 
    }
}
