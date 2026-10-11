using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
public class GameControllerItems : MonoBehaviour
{

    public int ItemsCollected;
    public int totalItems;

    public TextMeshProUGUI collectedItemsText;
    public GameObject winPanel;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalItems = GameObject.FindGameObjectsWithTag("Item").Length;
        UpdateUI();
        winPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectedItems()
    {
        ItemsCollected++;
        Debug.Log("Items Collected: " + ItemsCollected + "/" + totalItems);
        UpdateUI();
        

        if (ItemsCollected >= totalItems)
        {
            WinGame();
        }

    }


    public void WinGame()
    {
        Debug.Log("You Win!");
        winPanel.SetActive(true);
    }

    private void UpdateUI()
    {
        collectedItemsText.text = "Items Collected: " + ItemsCollected + "/" + totalItems;
    }
}




