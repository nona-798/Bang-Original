using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;   

public class BangRoomManager : NetworkRoomManager
{
    // 서버에 새로 들어온 클라이언트를 감지했을 때 동작함
    public override void OnRoomServerConnect(NetworkConnectionToClient conn)
    {
        base.OnRoomServerConnect(conn);

        // 스폰 위치 가져오기
        //Vector3 spawnPos = FindObjectOfType<SpawnPosition>().GetSpawnPos();
        // 로비 캐릭터 프리팹을 스폰 프리팹으로 가져와서 인스턴스화 함
        // + 스폰 위치에 프리팹을 스폰하도록 만듬
        var player = Instantiate(spawnPrefabs[0] , new Vector3(0,0,0), Quaternion.identity);

        // 서버에 프리팹이 소환됐음을 알리고
        // 서버에 플레이어가 접속했고, 새로 생성한 오브젝트는 해당 플레이어의 소유임을 서버에 알림
        NetworkServer.Spawn(player, conn); 
    }
}
