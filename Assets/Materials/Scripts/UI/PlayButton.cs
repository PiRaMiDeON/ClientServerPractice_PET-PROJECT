using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private int _sceneIndex;
    [SerializeField] private bool _rightButton;
    [SerializeField] private MenuDebug _menuDebug;
    private bool _resourcesLoaded;

    private void Awake()
    {
        if (_rightButton)
        {
            _resourcesLoaded = (DataHolder._secondSceneGameObjects == null);
        }
        else
        {
            _resourcesLoaded = (DataHolder._firstSceneGameObjects == null);
        }
    }
    public void LoadScene()
    {
        if (_resourcesLoaded)
        {
            SceneManager.LoadScene(_sceneIndex);
        }
        else
        {
            _menuDebug.Message("Для начала скачайте требуемые ресурсы!");
        }
    }

    public void ResourcesBeenLoaded()
    {
        if (!_resourcesLoaded)
            _resourcesLoaded = true;
    }

    public void ResourcesBeenDeleted()
    {
        if (_resourcesLoaded)
            _resourcesLoaded = false;
    }
}