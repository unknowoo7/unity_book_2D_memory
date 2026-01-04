using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private MemoryCard originalCard;
    [SerializeField] private Sprite[] images;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        var id = Random.Range(0, images.Length);
        originalCard.SetCard(id, images[id]);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}