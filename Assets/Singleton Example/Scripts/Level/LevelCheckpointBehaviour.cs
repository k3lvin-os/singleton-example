using UnityEngine;

public class LevelCheckpointBehaviour : MonoBehaviour {

    private bool _enabled;


    void OnEnable()
    {
        _enabled = true;
    }


    void OnTriggerEnter(Collider other)
    {
        if (!_enabled)
        {
            return;
        }

        if (other.gameObject.CompareTag("Player"))
        {        //////////////////////////////// USING SINGLETON ///////////////////////////////////////
            LevelManagerBehaviour.Instance.SwitchCurrentLevel();
            //////////////////////////////// USING SINGLETON ///////////////////////////////////////

            _enabled = false;
        }
    }
}
