using System.Configuration;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Event/SceneLoadEventSO")]
public class SceneLoadEventSO : ScriptableObject
{
    public UnityAction<GameSceneSO, Vector3, bool> LoadRequestEvent;

    //�˴���posToGo������ʵ�����壬ֻ������fallback
    public void RaiseLoadRequestEvent(GameSceneSO locationToLoad, Vector3 posToGo, bool fadeScreen)
    {
        LoadRequestEvent?.Invoke(locationToLoad,posToGo,fadeScreen);
    }
}
