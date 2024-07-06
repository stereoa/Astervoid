# Astervoid


## Description
A **Godot Asteroids-like** used as a learning project.  
Inspired by classic asteroid games and top down space shooters, as well as bullet hells. The player navigates a ship through a void, aiming to reach its center. They will be sucked towards the core as they try to survive by manueavering, blasting, and adapting to enemies, obstacles, and resources. As the player progresses, the environment becomes increasingly unpredictable and challenging. Physics and changes to visuals as well as inputs and even rules to the game stack providing growing challenges to pushing deeper and surviving. Focus on replayability, depth, and accessibility. Psychedelic, minimalistic, monochrome visuals.

## Features
- **Player-controlled spaceship with procedural game world**: Move, rotate, and thrust to navigate. Camera, collisions, and input implemented.
- **Starry background**: Dynamic particle based background that moves with the player's input.
- **Asteroids**: Randomly generated, bumpy asteroids with collision physics.

## Getting Started

### Prerequisites
- [Godot Engine 4.2](https://godotengine.org/download) or later.
- Basic knowledge of C# and Godot.

### Installation
1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/godot-asteroid-like.git
   ```
2. **Open the project in Godot**:
   - Launch Godot.
   - Click on "Import" and select the project.godot file from the cloned repository.

### Running the Project
1. **Set the Main Scene**:
   - Ensure that the `Game` scene is set as the main scene in the Project Settings.
2. **Run the Project**:
   - Click the play button or press `F5` to run the project.

## Project Structure
- **Scenes**:
  - `Game.tscn`: Manages the game state and asteroid generation.
  - `Asteroid.tscn`: Represents an asteroid with dynamic, bumpy shapes.
  - `Player.tscn`: Represents the player-controlled spaceship.
  - `Stars.tscn`: Represents the particle-based parallax background.
- **Scripts**:
  - `Game.cs`: Controls game initialization, including asteroid generation.
  - `Asteroid.cs`: Handles asteroid properties and collision shape.
  - `Player.cs`: Manages player movement, input handling, and screen wrapping.

## Controls
- **Arrow Keys**: Rotate and thrust the spaceship.

## Customization
- The vision and current implementation makes heavy use of Godot Exports, paired with procedural design. Aiming for rapid testing, fine tuning, unique gameplay and easy experimentation.

## Contributing
1. **Fork the repository**.
2. **Create a new branch**:
   ```bash
   git checkout -b feature-branch
   ```
3. **Commit your changes**:
   ```bash
   git commit -m "Description of changes"
   ```
4. **Push to the branch**:
   ```bash
   git push origin feature-branch
   ```
5. **Open a Pull Request**.

## License
This project is licensed under the MIT License. See the `LICENSE` file for details.

## Acknowledgments
- [Godot Engine](https://godotengine.org) for providing an excellent game development platform.
- Community tutorials and documentation that have aided in the learning process.
- Original Asteroidsarcade video game designed by Lyle Rains and Ed Logg released in November 1979 by Atari, Inc
  
## Author
- stereoa - [GitHub Profile](https://github.com/stereoa)

Feel free to modify this README to better suit the specifics of your project.
