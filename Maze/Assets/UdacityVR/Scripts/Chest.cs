using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour {

    public GameObject chestTop;
    public GameObject treasurePoof;

    public AudioSource chestOpenMusic;

    public Text winText;

    bool opening = false;

    Quaternion chestTopStartRotation;
    Quaternion chestTopEndRotation;

    float timer = 0f;
    float rotationTime = 10f;
    float prevTimer = 0f;

	// Use this for initialization
	void Start () {

        chestTopStartRotation = chestTop.transform.rotation;
        chestTopEndRotation = chestTopStartRotation * Quaternion.Euler(60f, 0f, 0f);

    }
	
	// Update is called once per frame
	void Update () {

        if (opening)
        {
            chestTop.transform.rotation = Quaternion.Slerp(chestTopStartRotation, chestTopEndRotation, timer / rotationTime);
            timer += Time.deltaTime;
            if (timer - prevTimer >= 1)
            {
                Instantiate(treasurePoof, transform.position, treasurePoof.transform.rotation);
                prevTimer = timer;
            }
        }
		
	}

    public void OnChestClicked()
    {
        Debug.Log("OnChestClicked Called");
        chestOpenMusic.Play();
        opening = true;
        winText.text = "You WIN!!!\n Replay";
    }
}
