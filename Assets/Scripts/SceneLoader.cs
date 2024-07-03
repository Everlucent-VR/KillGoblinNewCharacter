using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class SceneLoader : MonoBehaviourPunCallbacks
{
    [SerializeField] private Slider progressBar;

    private void Start()
    {
        // Set automatic scene synchronization
        PhotonNetwork.AutomaticallySyncScene = true;
        
        if (PhotonNetwork.IsMasterClient)
        {
            StartCoroutine(LoadTargetScene());
        }
    }

    private IEnumerator LoadTargetScene()
    {
        PhotonNetwork.LoadLevel(2);

        while (PhotonNetwork.LevelLoadingProgress < 1)
        {
            progressBar.value = PhotonNetwork.LevelLoadingProgress;
            yield return new WaitForEndOfFrame();
        }
    }
}