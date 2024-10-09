using Godot;
using System;

public partial class PlayerCamera3d : Camera3D
{
	Vector3 target = new Vector3();
	private const float OFFSET = 13.435f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var player = GetNode<Player>("../Player");

		target.Y = player.Position.Y + OFFSET; target.Z = player.Position.Z + OFFSET;
		target.X = player.Position.X;
		Position = target;
	}
}
