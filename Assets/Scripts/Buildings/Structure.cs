using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Structurecost
{
    public int food;
    public int wood;
    public int gold;
    public int stone;
}
public abstract class Structure : MonoBehaviour
{
    [SerializeField]
    protected string structureName;
    public string StructureName { get { return structureName; } }

    [SerializeField] protected Sprite structurePic;
    public Sprite StructurePic { get { return structurePic; } }

    [SerializeField]
    protected int curHP;
    public int CurHP { get { return curHP; } set { curHP = value; } }

    [SerializeField]
    protected int maxHP;
    public int MaxHP { get { return maxHP; } set {  maxHP = value; } }

    [SerializeField]
    protected Factions faction;
    public Factions Factions { get { return faction; } set { faction = value; } }

    [SerializeField]
    protected GameObject selectionVisual;
    public GameObject SelectionVisual { get { return selectionVisual; } }

    [SerializeField] 
    private Structurecost structureCost; 
    public Structurecost StructureCost { get { return structureCost; } set { structureCost = value; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
