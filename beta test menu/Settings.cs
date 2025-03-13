using Godot;
using System;

public partial class Settings : Node
{
	private Button _menuButton;

	public override void _Ready()
	{
		_menuButton = GetNode<Button>("Menu");

		_menuButton.Pressed += OnMenuPressed;
	}
	
	private void OnMenuPressed()
	{
		GD.Print("Retour au menu...");
		GetTree().ChangeSceneToFile("res://Menu.tscn");
	}
}
