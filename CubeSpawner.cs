using Godot;
using System;

public partial class CubeSpawner : Node3D
{
	private int counter = 1;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		base._Ready();
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		base._Process(delta);
		PackedScene cubeProto = GD.Load<PackedScene>("res://cube.tscn");
		Node3D cube = cubeProto.Instantiate<Node3D>();
		this.AddChild(cube);
		counter++;
		GetNode<Label>("../Label").Text = counter.ToString();
	}
}
