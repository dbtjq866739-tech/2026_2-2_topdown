using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        Key,
        Gold
    }

    public ItemType itemType;
    public int goldAmount = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Inventory inventory = other.GetComponent<Inventory>();

            if (inventory == null) return;

            if (itemType == ItemType.Key)
            {
                inventory.AddKey();
            }
            else if (itemType == ItemType.Gold)
            {
                inventory.AddGold(goldAmount);
            }

            Destroy(gameObject);
        }
    }
}