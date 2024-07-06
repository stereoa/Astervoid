using Godot;
using System;

namespace Astervoid
{
	public partial class Asteroid : RigidBody2D
	{
		[Export]
		public int NumSides = 16;
		[Export]
		public float Radius = 50;
		[Export]
		public float Bumpiness = 10;


		public override void _Ready()
		{
			GenerateEdges(Radius, NumSides, Bumpiness);
		}

		private void GenerateEdges(float radius, int numSides, float bumpiness)
		{
			var random = new Random();
			var points = new Vector2[numSides];
			for (int i = 0; i < numSides; i++)
			{
				var angle = Mathf.Tau * i / numSides;
				var currentRadius = radius + (float)random.NextDouble() * bumpiness - bumpiness / 2;
				points[i] = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * currentRadius;
			}
			var shape = new Polygon2D();
			shape.Polygon = points;
			AddChild(shape);

			var hitbox = new CollisionPolygon2D();
			hitbox.Polygon = points;
			AddChild(hitbox);

		}
	}
}