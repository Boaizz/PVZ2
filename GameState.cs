
namespace CustomProgram
{
    public interface GameState //state pattern
    {
        void NextState();
        void PreviousState();
        void Update();
        void FreeAllSprites();
        void FreeAllMusics();

    }
}
