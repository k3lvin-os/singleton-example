using UnityEngine;
using System.Collections;
using System;

public class LevelManagerBehaviour : MonoBehaviour
{

    public GameObject FirstLevel;
    public GameObject CurrentLevel { get; private set; }
    public GameObject PreviousLevel { get; private set; }
    public GameObject NextLevel { get; private set; }

    /// <summary>
    ///  Main component of Singleton Pattern
    /// </summary>
    public static LevelManagerBehaviour Instance { get; private set; }

    /// <summary>
    /// On Game Start
    /// </summary>
    public void Awake()
    {
        ///////////////////////////////////// SINGLETON PATTERN ////////////////////////////////////////////////
        if (Instance == null)
        {
            Instance = this;
        }
        ///////////////////////////////////// SINGLETON PATTERN ////////////////////////////////////////////////

        CurrentLevel = FirstLevel;
        CurrentLevel = Instantiate(CurrentLevel);
    }

    public void SwitchCurrentLevel()
    {
        if (PreviousLevel == null)
        {
            PreviousLevel = CurrentLevel;
        }
        else
        {
            PreviousLevel.SetActive(false);
            CurrentLevel = NextLevel;
        }
        LevelBehaviour levelBehaviour = CurrentLevel.GetComponent<LevelBehaviour>();
        GameObject nextLevel = levelBehaviour.GetPossibleNextLevel();
        LevelBehaviour nextLevelBehaviour = CurrentLevel.GetComponent<LevelBehaviour>();
        Vector3 nextLevelPosition = levelBehaviour.GetNextLevelPosition(nextLevelBehaviour);
        NextLevel = Instantiate(nextLevel);
        NextLevel.transform.position = nextLevelPosition;

        //////////////////////////////// USING SINGLETON ///////////////////////////////////////
        ScoreBehaviour.Instance.UpdateScore();
        //////////////////////////////// USING SINGLETON ///////////////////////////////////////

    }





}
