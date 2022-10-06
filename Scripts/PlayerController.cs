using Godot;

namespace Platformer.Scripts
{
    public class PlayerController : KinematicBody2D
    {

        public override void _Ready()
        {
        
        }

        public override void _Process(float delta)
        {
            Vector2 velocity = new Vector2();
            
            if(Input.IsActionPressed("ui_left"))
            {
                velocity.x -= 50;
            }
            if(Input.IsActionPressed("ui_right"))
            {
                velocity.x += 50;
            }
            MoveAndSlide(velocity, Vector2.Up);
        }
    }
}
