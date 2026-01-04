using UnityEngine;

public class SceneController : MonoBehaviour
{
    public const int gridRows = 2;
    public const int gridColumns = 4;
    public const float offsetX = 2f;
    public const float offsetY = 2.5f;
    
    [SerializeField] private MemoryCard originalCard;
    [SerializeField] private Sprite[] images;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Vector3 startPos = originalCard.transform.position;

        for (int i = 0; i < gridColumns; i++)
        {
            for (int j = 0; j < gridRows; j++)
            {
                MemoryCard card;
                if (i == 0 && j == 0)
                    
                {
                    card = originalCard;
                }
                else
                {
                    card = Instantiate(originalCard) as MemoryCard;
                }
                
                var id = Random.Range(0, images.Length);
                card.SetCard(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = (offsetY * j) + startPos.y;
                
                card.transform.position = new Vector3(posX, posY, startPos.z);
            }
        }
        

    }

    // Update is called once per frame
    private void Update()
    {
    }
}