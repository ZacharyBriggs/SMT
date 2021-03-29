using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldManager : MonoBehaviour
{
    public static OverworldManager instance;
    public EncounterTable encounters;
    public GameObject playerGC;
    public PlayerBattleScriptable playerScriptable;
    public List<Demon> playerDemons = new List<Demon>();
    public Room currentRoom;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            if (playerGC.transform.eulerAngles.y == 0)
            {
                if (currentRoom.connectedRoomN != null)
                {
                    currentRoom = currentRoom.connectedRoomN;
                    playerGC.transform.position = currentRoom.playerMovePoint.position;
                    playerGC.transform.position += new Vector3(0, 1, 0);
                }
            }
            else if (playerGC.transform.eulerAngles.y == 180)
            {
                if (currentRoom.connectedRoomS != null)
                {
                    currentRoom = currentRoom.connectedRoomS;
                    playerGC.transform.position = currentRoom.playerMovePoint.position;
                    playerGC.transform.position += new Vector3(0, 1, 0);
                }
            }
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            playerGC.transform.Rotate(Vector3.up,90);
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            if (playerGC.transform.eulerAngles.y == 0)
            {
                if (currentRoom.connectedRoomS != null)
                {
                    currentRoom = currentRoom.connectedRoomS;
                    playerGC.transform.position = currentRoom.playerMovePoint.position;
                    playerGC.transform.position += new Vector3(0, 1, 0);
                }
            }
            else if (playerGC.transform.eulerAngles.y == 180)
            {
                if (currentRoom.connectedRoomN != null)
                {
                    currentRoom = currentRoom.connectedRoomN;
                    playerGC.transform.position = currentRoom.playerMovePoint.position;
                    playerGC.transform.position += new Vector3(0, 1, 0);
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            playerGC.transform.Rotate(Vector3.up, -90);
        }
    }
}
