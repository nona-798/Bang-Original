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

        // �κ� ĳ���� �������� ���� ���������� �����ͼ� �ν��Ͻ�ȭ ��
        var player = Instantiate(spawnPrefabs[0]);

        // ������ �������� ��ȯ������ �˸���
        // ������ �÷��̾ �����߰�, ���� ������ ������Ʈ�� �ش� �÷��̾��� �������� ������ �˸�
        NetworkServer.Spawn(player, conn); 
    }
}
