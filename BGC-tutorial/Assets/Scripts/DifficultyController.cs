using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DifficultyController", menuName = "ScriptableObjects/DifficultyController", order = 1)]
public class DifficultyController : ScriptableObject
{
    public enum Difficulty{easy, hard}
    public Difficulty difficulty;

    public float speed;

public void SetDifficultyHard()
{
    difficulty = Difficulty.hard;
}

public void SetDifficultyEasy()
{
    difficulty = Difficulty.easy;
}

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */

    //go to button component
    //on click, difficulty setting
    //drag scriptable object into object
    //select method
}
