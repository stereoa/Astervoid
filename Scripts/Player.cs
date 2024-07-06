using Godot;
using System;

namespace Astervoid
{
	public partial class Player : CharacterBody2D
	{
		[Export]
		public float Acceleration = 300;
		[Export]
		public float RotationSpeed = 3;
		[Export]
		public float MaxSpeed = 300;
		[Export]
		public Polygon2D Thruster;

		private Vector2 screenSize = DisplayServer.ScreenGetSize();


		public override void _Ready()
		{
			GD.Print(screenSize);
			// Set the player's position to the middle of the screen
			Position = DisplayServer.ScreenGetSize() / 2;
		}

		public override void _Process(double delta)
		{
		}

		public override void _PhysicsProcess(double delta)
		{
			MoveCharacter((float)delta);
		}

		private void MoveCharacter(float delta)
		{
			float rotationInput = Input.GetActionStrength("turn_right") - Input.GetActionStrength("turn_left");
			float accelerationInput = Input.GetActionStrength("thrust");

			Rotation += rotationInput * RotationSpeed * delta;

			if (accelerationInput > 0)
			{
				Velocity += Vector2.Up.Rotated(Rotation) * Acceleration * delta;
			}

			// Cap the speed
			if (Velocity.Length() > MaxSpeed)
			{
				Velocity = Velocity.Normalized() * MaxSpeed;
			}

			var collision = MoveAndCollide(Velocity * (float)delta);
			if (collision != null)
			{
				Velocity = Velocity.Bounce(collision.GetNormal());
				if (collision.GetCollider().HasMethod("Hit"))
				{
					collision.GetCollider().Call("Hit");
				}
			}

			// Show or hide thruster
			Thruster.Visible = accelerationInput > 0;
		}
	}
}
