using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Selectable[] topStacks;
    public GameObject scorePanel;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        if (HasWin())
        {
            Win();
        }
    }
    
    public bool HasWin()
    {
        int i = 0;
        foreach (Selectable topstack in topStacks)
        {
            i += topstack.value;
        }
        if (i >= 52)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    void Win()
    {
        scorePanel.SetActive(true);
        print("You have won!");
    }
}
