#region

using Engine.Component;

#endregion

namespace RogueLikeGame.Data.Components
{
  public enum GameAction
  {
    None,
    Move,
    Attack,
  }

  public class Player : Component
  {
    public Player(string name)
    {
      Name = name;
    }
    public string Name;
  }

  public class Actor : Component
  {
    public GameAction action = GameAction.None;
    public EDirection direction = EDirection.None;
  }

  public class Health : Component
  {
    public int current;
    public int max;
  }

  public class Attack : Component
  {
    public int damage;
    public int hitChance;
  }

  public class Defense : Component
  {
    public int armor;
    public int dodgeChance;
  }
}