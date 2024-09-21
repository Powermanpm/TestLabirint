
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{   
    [SerializeField] private int keyMax = 5;
    private int keys = 0;
    public void AddKeys(int newKeys){

        keys += newKeys;
        Debug.Log("Keys = " + keys);

    } 

    public int Keys() => keys; 
    public int KeyMax() => keyMax;

}
