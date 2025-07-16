using UnityEngine;

public class Consts
{

  public struct SceneNames
  {
    public const string GAME_SCENE = "GameScene";
  }
  public struct Layers
  {
    public const string GROUND_LAYER = "Ground";
    public const string FLOOR_LAYER = "Floor";
  }
  public struct PlayerAnimations
  {
    public const string IS_MOVING = "IsMoving";
    public const string IS_JUMPING = "IsJumping";
    public const string IS_SLIDING = "IsSliding";
    public const string IS_SLIDING_ACTIVE = "IsSlidingActive";

  }

  public struct OtherAnimations
  {
    public const string IS_SPATULA_JUMPING = "IsSpatulaJumping";
  }
  public struct WheatTypes
  {
    public const string GOLD_WHEAT = "GoldWheat";
    public const string HOLY_WHEAT = "HolyWheat";
    public const string ROTTEN_WHEAT = "RottenWheat";


  }
}
