using Godot;
using System;

public partial class Menu : Node
{
	private Button _playButton;
	private Button _settingsButton;
	private Button _quitButton;

	public override void _Ready()
	{
		_playButton = GetNode<Button>("Play");
		_settingsButton = GetNode<Button>("Settings");
		_quitButton = GetNode<Button>("Quit");

		_playButton.Pressed += OnPlayPressed;
		_settingsButton.Pressed += OnSettingsPressed;
		_quitButton.Pressed += OnQuitPressed;
	}

	private void OnPlayPressed()
	{
		GD.Print("Lancement du jeu...");
		GetTree().ChangeSceneToFile("res://Game.tscn");
	}

	private void OnSettingsPressed()
	{
		GD.Print("Ouverture des paramètres...");
		GetTree().ChangeSceneToFile("res://Settings.tscn");
	}

	private void OnQuitPressed()
	{
		GD.Print("Quitter le jeu...");
		GetTree().Quit(); // Ferme le jeu
	}
}
