using Godot;
using System;
using System.Linq;
using System.Numerics;
using Plane = Godot.Plane;
using Vector2 = Godot.Vector2;
using Vector3 = Godot.Vector3;

public partial class Player : CharacterBody3D
{
	private Vector3 _mousePos3D;
	private Vector2 _mousePos2D;
	private Vector3 _targetVelocity = Vector3.Zero;
	private const float RAY_LENGTH = 1000.0f;

	// Don't forget to rebuild the project so the editor knows about the new export variable.

	// How fast the player moves in meters per second.
	[Export]
	public int Speed { get; set; } = 14;
	// The downward acceleration when in the air, in meters per second squared.
	[Export]
	public int FallAcceleration { get; set; } = 75;

	public override void _PhysicsProcess(double delta)
	{
		var direction = Vector3.Zero;

		if (Input.IsActionPressed("move_right"))
		{
			direction.X += 1.0f;
		}
		if (Input.IsActionPressed("move_left"))
		{
			direction.X -= 1.0f;
		}
		if (Input.IsActionPressed("move_back"))
		{
			direction.Z += 1.0f;
		}
		if (Input.IsActionPressed("move_forward"))
		{
			direction.Z -= 1.0f;
		}

		// Ground velocity
		_targetVelocity.X = direction.X * Speed;
		_targetVelocity.Z = direction.Z * Speed;

		// Vertical velocity
		if (!IsOnFloor())
		{
			_targetVelocity.Y -= FallAcceleration * (float)delta;
		}

		// Moving the character
		Velocity = _targetVelocity;
		MoveAndSlide();
		//LookAtCursorRayCast();
		LookAtCursorAngle();
	}

	public void LookAtCursorRayCast()
	{
		Plane planeState = new Plane(Vector3.Up, Position.Y);
		var cam = GetNode<Camera3D>("../PlayerCamera3D");
		_mousePos2D = GetViewport().GetMousePosition();

		var origin = cam.ProjectRayOrigin(_mousePos2D);
		var end = origin + cam.ProjectRayNormal(_mousePos2D) * RAY_LENGTH;
		var query = PhysicsRayQueryParameters3D.Create(origin, end);
		var result = planeState.IntersectsRay(origin, end);

		if (result != null)
		{
			_mousePos3D = (Vector3)result;
		}

		LookAt(_mousePos3D, Vector3.Up, false);
	}

	private Vector2 _playerPos;
	private float _mouseAngle;
	public void LookAtCursorAngle()
	{
		Plane planeState = new Plane(Vector3.Up, Position.Y);
		//_mousePos2D = GetViewport().GetMousePosition();
		var cam = GetNode<Camera3D>("../PlayerCamera3D");
		_playerPos = cam.UnprojectPosition(Position);
		_mousePos2D = GetViewport().GetMousePosition();

		_mouseAngle = _playerPos.AngleToPoint(_mousePos2D);

		_mousePos3D = Rotation;
		_mousePos3D.Y = _mouseAngle;
		Rotation = _mousePos3D;
	}
}
