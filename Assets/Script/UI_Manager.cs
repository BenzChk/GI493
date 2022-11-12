using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    public GameObject scorePanel;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
    
    public void ResetScene()
    {
        // find all the cards and remove them
        UpdateSprites[] cards = FindObjectsOfType<UpdateSprites>();
        foreach (UpdateSprites card in cards)
        {
            Destroy(card.gameObject);
        }
        ClearTopValues();
        // deal new cards
        FindObjectOfType<Solitaire>().PlayCards();
    }
    
    public void PlayAgain()
    {
        scorePanel.SetActive(false);
        ResetScene();
    }

    
    void ClearTopValues()
    {
        Selectable[] selectables = FindObjectsOfType<Selectable>();
        foreach (Selectable selectable in selectables)
        {
            if (selectable.CompareTag("Top"))
            {
                selectable.suit = null;
                selectable.value = 0;
            }
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("SolitaireGame");
    }
}
