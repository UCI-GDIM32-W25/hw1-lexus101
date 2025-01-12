using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        // Initialize the number of seeds left when game starts
        _numSeedsLeft = _numSeeds;
        // Update the UI using the int of how many seeds left and how many planted
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted); 
    }

    private void Update()
    {
        //get unity's default input manager on the horizontal axis. giving a value of -1 when press a and 1 when press d
        float moveInputHorizontal = Input.GetAxis("Horizontal");
        //same as horizontal but used for vertical: w and s.
        float moveInputVertical = Input.GetAxis("Vertical");

        //declaring a vector3 variable for position
        Vector3 move = new Vector3(moveInputHorizontal, moveInputVertical, 0) * _speed * Time.deltaTime;

        //player's transform position transforms base on the vector3 Move
        _playerTransform.position += move;

        //when space is pressed, call the plantseed function
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        //as long as seeds number is greater then 0, if will run.
        if (_numSeedsLeft > 0)
        {
            //instantiate/creates a new _plantPrefab object in the player's transform position and rotation.
            Instantiate(_plantPrefab, _playerTransform.position, _playerTransform.rotation);

            //minus the numbers
            _numSeedsLeft -= 1;
            _numSeedsPlanted += 1;

            //update the numbers in the ui so player can see the number decreasing.
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

        }
    
}
}
