using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : MonoBehaviour {

    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public int amountOfShipsKilled = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
	}
	
    public void SpawnObject() {
        MysteryShip ship = Instantiate(spawnee, transform.position, transform.rotation).GetComponent<MysteryShip>();
        ship.killedShip += killShip;
        if(stopSpawning) {
            CancelInvoke("SpawnObject");
        }
    }

    public void killShip(){
        amountOfShipsKilled++;
    }
}