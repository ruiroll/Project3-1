using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum CharacterType
{
    Knight,
    Elf
}

[System.Serializable]
public class Character
{
    public CharacterType characterType;
    public Sprite CharacterSprite;
    public RuntimeAnimatorController AnimatorController;
    
}
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public List<Character> CharacterList = new List<Character>();
    
    public Text playerName;
    public Animator PlayerAnimator;
    private void Awake()
    {
        if(instance == null)
            instance =this;
        else
            Destroy(gameObject);

    }

    public void SetCharacter(CharacterType characterType, string name)
    {
        var character = GameManager.instance.CharacterList.Find(item => item.characterType == characterType);
        PlayerAnimator.runtimeAnimatorController = character.AnimatorController;
        playerName.text = name;
    }

}
