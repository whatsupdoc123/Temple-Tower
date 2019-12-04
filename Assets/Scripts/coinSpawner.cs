using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{
    public Rigidbody[] coin;
    public GameObject spawnPoint;
    public int coinType;

    private PotteryController PotteryController;

    // Start is called before the first frame update
    void Start()
    {
        PotteryController = GetComponent<PotteryController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PotteryController.isCollided == true)
        {
            Rigidbody clone = Instantiate(coin[coinType], spawnPoint.transform.position, spawnPoint.transform.rotation);
            clone.AddRelativeForce(Vector3.forward * 200);
            PotteryController.isCollided = false;
        }
    }
}
