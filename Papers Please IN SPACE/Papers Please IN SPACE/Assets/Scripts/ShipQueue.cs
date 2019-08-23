using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipQueue : MonoBehaviour
{
    [SerializeField]
    private int queueSize = 3;
    private GameObject[] queue = null;

    void Start()
    {
        queue = new GameObject[queueSize];
    }

    void Update()
    {
        MoveQueuedShipsToPosition();
    }

    //Find the first open slot in the queue. Returns -1 if there are none
    private int FindFirstOpenSlot()
    {
        for(int i = 0; i < queue.Length; i++)
        {
            if (queue[i] == null)
                return i;
        }
        return -1;
    }

    //Adds ship to queue in the first open slot available. If none are available, does nothing.
    public void AddShip(GameObject newShip)
    {
        int firstOpenSlot = FindFirstOpenSlot();
        if(firstOpenSlot != -1)
        {
            queue[firstOpenSlot] = newShip;
        }
    }

    //Teleports all queued ships to waiting position. In the future this should be rewritten to animate them into position
    private void MoveQueuedShipsToPosition()
    {
        for (int i = 0; i < queue.Length; i++)
        {
            GameObject queuedShip = queue[i];
            if(queuedShip != null)
            {
                queuedShip.transform.position = new Vector3(10, 0, i * 10);
            }
        }
    }
}
