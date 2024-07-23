using UnityEngine;
using UnityEngine.ResourceManagement;
public class AssetWebDestroyer : MonoBehaviour
{
    [SerializeField] private PlayButton _playButton;
    [SerializeField] private bool _rightButton;
    [SerializeField] private MenuDebug _menuDebug;
    public void DeleteUnuseAssets()
    {
        Resources.UnloadUnusedAssets();

        if (_rightButton)
        {
            DataHolder.DeleteAssetsForSecondGame();
        }
        else
        {
            DataHolder.DeleteAssetsForFirstGame();
        }

        _playButton.ResourcesBeenDeleted();
        _menuDebug.Message("Ресурсы удалены!");
    }
}
