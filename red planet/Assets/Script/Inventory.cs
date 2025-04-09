using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    public bool isInvetoryOpened;

    [SerializeField] private GameObject _InventoryPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !isInvetoryOpened)
        {
            _InventoryPrefab.SetActive(true);
            isInvetoryOpened = true;
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && isInvetoryOpened)
        {
            _InventoryPrefab.SetActive(false);
            isInvetoryOpened = false;
        }
    }

    void SlotSelection()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {

        }
    }
}
