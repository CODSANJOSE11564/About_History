using UnityEngine;

public class AttackCode : MonoBehaviour
{
    [SerializeField] private bool _comboIsActivated = default;
    private AnimationManager _animationManager = default;
    [SerializeField] private GameObject _normalKick = default;
    [SerializeField] private GameObject _comboKick = default;
    [SerializeField] private GameObject _normalFist = default;
    [SerializeField] private GameObject _comboFist = default;
    void Start()
    {
        _animationManager = GetComponent<AnimationManager>();
    }
    void Update()
    {
        ActionList();
    }
    private void ActionList()
    {
        _comboIsActivated = Input.GetKey(KeyCode.LeftShift) ? true : false;
        if (Input.GetKeyDown(KeyCode.Q) )
        {
            PatadaList();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            GolpeList();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Joke();
        }
    }
    
    private void PatadaList()
    {
        var StringParameter = _comboIsActivated ? "PatadaCombo" : "PatadaNormal";
        var GameAction = _comboIsActivated ? _comboKick : _normalKick;
        _animationManager.AnimationsKick(StringParameter);
        StartCoroutine(GetComponent<DisableScript>().Disablescript(GameAction));
    }

    private void GolpeList()
    {
        var StringParameter = _comboIsActivated ? "Codazo" : "GolpeNormal";
        var GameAction = _comboIsActivated ? _comboFist : _normalFist;
       _animationManager.AnimationsFist(StringParameter);
       StartCoroutine(GetComponent<DisableScript>().Disablescript(GameAction));
    }

    private void Joke()
    {
        _animationManager.JokeAnimation();
    }
    
}
