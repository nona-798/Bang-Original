using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;   

public class BangRoomManager : NetworkRoomManager
{
    // ������ ���� ���� Ŭ���̾�Ʈ�� �������� �� ������
    public override void OnRoomServerConnect(NetworkConnectionToClient conn)
    {
        base.OnRoomServerConnect(conn);

        // ���� ��ġ ��������
        //Vector3 spawnPos = FindObjectOfType<SpawnPosition>().GetSpawnPos();
        // �κ� ĳ���� �������� ���� ���������� �����ͼ� �ν��Ͻ�ȭ ��
        // + ���� ��ġ�� �������� �����ϵ��� ����
        var player = Instantiate(spawnPrefabs[0] , new Vector3(0,0,0), Quaternion.identity);

        // ������ �������� ��ȯ������ �˸���
        // ������ �÷��̾ �����߰�, ���� ������ ������Ʈ�� �ش� �÷��̾��� �������� ������ �˸�
        NetworkServer.Spawn(player, conn); 
    }
}
