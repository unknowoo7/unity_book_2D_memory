using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private GameObject cardBack;
    [SerializeField] private SceneController controller;

    public int Id { get; private set; }

    private void OnMouseDown()
    {
        if (cardBack.activeSelf) cardBack.SetActive(false);
    }

    public void SetCard(int id, Sprite img)
    {
        Id = id;
        GetComponent<SpriteRenderer>().sprite = img;
    }
}
