using UnityEngine;
using System.Collections;

public class LevelBehaviour : MonoBehaviour
{
    public GameObject[] PossibleNextLevels;

    public Vector3 GetNextLevelPosition(LevelBehaviour nextLevelBehaviour)
    {
        float nextLevelXPosition = transform.Find("LevelEnd").transform.position.x +
            nextLevelBehaviour.transform.Find("LevelEnd").transform.localPosition.x;
        Vector3 currentLevelPosition = transform.position;
        return new Vector3(nextLevelXPosition, currentLevelPosition.y, currentLevelPosition.z);
    }

    public GameObject GetPossibleNextLevel()
    {
        int index = Random.Range(0, PossibleNextLevels.Length);
        GameObject nextLevel = PossibleNextLevels[index];
        return nextLevel;
    }
}
