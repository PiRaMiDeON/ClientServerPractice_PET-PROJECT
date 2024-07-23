using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AssetWebLoader : MonoBehaviour
{
    [SerializeField] private string _assetAddress;
    [SerializeField] private PlayButton _playButton;
    [SerializeField] private bool _rightButton;
    [SerializeField] private MenuDebug _menuDebug;

    public void LoadPrefab()
    {
        Addressables.LoadAssetAsync<GameObject>(_assetAddress).Completed += OnPrefabLoaded;
    }

    private void OnPrefabLoaded(AsyncOperationHandle<GameObject> handle)
    {
        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            GameObject prefabInstance = handle.Result;

            if (_rightButton)
            {
                DataHolder.LoadAssetsForSecondGame(prefabInstance);
            }
            else
            {

                DataHolder.LoadAssetsForFirstGame(prefabInstance);
            }

            _playButton.ResourcesBeenLoaded();

            _menuDebug.Message("Ресурсы успешно загружены!");
        }
        else
        {
            _menuDebug.Message("Не удалось загрузить ресурсы: " + handle.OperationException);
        }
    }
}
