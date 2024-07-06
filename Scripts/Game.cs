using Godot;
using System;

namespace Astervoid
{
	public partial class Game : Node2D
	{
		[Export]
		public Player Player;
		[Export]
		public ParallaxBackground Background;
		[Export]
		public PackedScene Asteroid;
		[Export]
		public int MinAsteroids = 5;
		[Export]
		public int MaxAsteroids = 10;
		[Export]
		public float SpawnRadius = 1000;

		public override void _Ready()
		{
			GenerateAsteroids();
		}

		private void GenerateAsteroids()
		{
			Random random = new Random();
			int numAsteroids = random.Next(MinAsteroids, MaxAsteroids);

			// Find the player node to position asteroids around it
			Vector2 playerPosition = Player.GlobalPosition;

			for (int i = 0; i < numAsteroids; i++)
			{
				// Instance a new asteroid
				RigidBody2D asteroid = (RigidBody2D)Asteroid.Instantiate();

				// Randomize the asteroid's properties
				asteroid.Set("NumSides", random.Next(10, 20));
				asteroid.Set("Radius", random.Next(30, 60));
				asteroid.Set("Bumpiness", random.Next(5, 15));

				// Position the asteroid around the player
				float angle = (float)(random.NextDouble() * Math.PI * 2);
				float distance = (float)(random.NextDouble() * SpawnRadius);
				Vector2 offset = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * distance;
				asteroid.Position = Player.GlobalPosition + offset;

				// Add the asteroid to the scene
				AddChild(asteroid);
			}
		}
		public override void _Process(double delta)
		{
			// Adjust the ParallaxBackground offset based on the player's position
			Background.ScrollOffset = Player.Position * 0.1f;
		}
	}
}