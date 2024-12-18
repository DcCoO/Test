namespace johnny.HexProject.Logic
{
    public interface ICommand {}
    
    public struct MoveCommand : ICommand {}
    
    public struct AttackCommand : ICommand {}
}