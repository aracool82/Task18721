using UnityEngine;

public class ResourceGenerator : MonoBehaviour
{
    [Range (1,5)]
    [SerializeField] private int _minValue = 1;

    [Range(6, 20)]
    [SerializeField] private int _maxValue = 10;

    public IResourceble GetResources(IResourceble resource)
    {
        int randomValue = Random.Range(_minValue, _maxValue);
        resource.Add(randomValue);
        return resource;
    }
}
