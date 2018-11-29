using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall : MonoBehaviour {

    public GameObject wallPoofPrefab;
    public static int numWallDestroys = 0;
    Coin coin = new Coin();

    public void OnWallClicked()
    {
        /// Called when the 'Coin' game object is clicked
        /// - Displays a poof effect (handled by the 'CoinPoof' prefab)
        /// - Plays an audio clip (handled by the 'CoinPoof' prefab)
        /// - Removes the coin from the scene

        // Prints to the console when the method is called
        Debug.Log("'OnWallClicked()' was called");

        // TODO: Display the poof effect and remove the coin from the scene
        // Use Instantiate() to create a clone of the 'CoinPoof' prefab at this coin's position and with the 'CoinPoof' prefab's rotation
        // Use Destroy() to delete the coin after for example 0.5 seconds
        // Destroying the gameobject only if there are any coins
        if (coin.CoinCount() > 0)
        {
            Instantiate(wallPoofPrefab, gameObject.transform.position, wallPoofPrefab.transform.rotation);
            Destroy(gameObject, 0.5f);
            coin.CoinUsed();
            numWallDestroys++;
        }
        else
        {
            Debug.Log("No enough coins");
        }
    }
}
