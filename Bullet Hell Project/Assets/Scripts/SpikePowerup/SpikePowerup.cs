using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikePowerup : MonoBehaviour
{
    public GameObject player;
    public GameObject[] spikes;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startPowerup());
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = player.transform.position;
        temp.y = 0;
        transform.position = temp;
    }

    public void launchSpike(int spikeNum){
        spikes[spikeNum].GetComponent<MoveForward>().enabled = true;
        spikes[spikeNum].transform.SetParent(null, true);
    }

    IEnumerator startPowerup(){
        yield return new WaitForSeconds(1f);
        launchSpike(0);
        yield return new WaitForSeconds(1f);
        launchSpike(1);
        yield return new WaitForSeconds(1f);
        launchSpike(2);
        yield return new WaitForSeconds(1f);
        launchSpike(3);
        yield return new WaitForSeconds(1f);
        launchSpike(4);
    }
}
