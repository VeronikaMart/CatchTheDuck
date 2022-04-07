using UnityEngine;

namespace Platforms
{
    public class PlatformSpawner : MonoBehaviour, IBorder
    {
        [Tooltip("Spawn location in the hierarchy")]
        [SerializeField] private Transform spawnLocation;
        [SerializeField] private float distanceBetweenPlatforms = 5f;
        [SerializeField] private GameObject[] platformPrefabs;

        private const float START_POSITION = 0f;
        private float minX, maxX;
        private float lastPositionY;
        private float controlX;

        private void Start()
        {
            controlX = START_POSITION;

            SetBoundaries();
            CreatePlatforms(START_POSITION);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Platform"))
            {
                if (collision.transform.position.y == lastPositionY)
                {
                    CreatePlatforms(lastPositionY - distanceBetweenPlatforms);
                }
            }
        }

        public void SetBoundaries()
        {
            Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

            maxX = bounds.x - 0.5f; // Small offset between borders and the center of the platform 
            minX = -bounds.x + 0.5f;
        }

        private void CreatePlatforms(float positionY)
        {
            ShufflePlatforms(platformPrefabs);

            for (int i = 0; i < platformPrefabs.Length; i++)
            {
                Vector3 currentPos = platformPrefabs[i].transform.position;
                currentPos.y = positionY; // first element start from 0 

                switch (controlX) 
                {
                    case 0:
                        currentPos.x = Random.Range(0f, maxX);
                        controlX = 1f;
                        break;
                    case 1:
                        currentPos.x = Random.Range(0f, minX);
                        controlX = 2f;
                        break;
                    case 2:
                        currentPos.x = Random.Range(1f, maxX);
                        controlX = 3f;
                        break;
                    default:
                        currentPos.x = Random.Range(-1f, minX);
                        controlX = START_POSITION;
                        break;
                }

                lastPositionY = positionY;
                platformPrefabs[i].transform.position = currentPos;

                positionY -= distanceBetweenPlatforms;
                Instantiate(platformPrefabs[i], spawnLocation);
            }
        }

        private void ShufflePlatforms(GameObject[] arrayToShuffle)
        {
            for (int i = 0; i < arrayToShuffle.Length; i++)
            {
                GameObject current = arrayToShuffle[i];
                int random = Random.Range(0, arrayToShuffle.Length);
                arrayToShuffle[i] = arrayToShuffle[random];
                arrayToShuffle[random] = current;
            }
        }
    }
}