
## TicTacToeEngine
###### Made by: [@matheusfladislau](https://github.com/matheusfladislau) and [@julianafidalgo](https://github.com/julianafidalgo)
##

  ![Issues](https://img.shields.io/github/issues/matheusfladislau/TicTacToeEngine?style=flat&color=FFFFFF)
  ![PRs](https://img.shields.io/github/issues-pr/matheusfladislau/TicTacToeEngine?style=flat&color=FFFFFF)
  ![Stars](https://img.shields.io/github/stars/matheusfladislau/TicTacToeEngine?style=flat&color=FFFFFF)
  ![Contributors](https://img.shields.io/github/contributors/matheusfladislau/TicTacToeEngine?style=flat&color=FFFFFF)


**TicTacToeEngine** is a game engine class library developed in C# with a sole focus on the logic of the Tic-Tac-Toe game, allowing developers to focus exclusively on building UI. By separating the game logic from the visual elements, the engine streamlines the process of creating Tic-Tac-Toe games across different .NET projects, such as desktop or web applications.
This small project was created for study purposes to separate game logic from the UI.


TicTacToeEngine is a free software: 
* ![License](https://img.shields.io/badge/license-GPLv2-FFFFFF)


## Installation

This project was developed using .NET 8.0. For Windows, use Visual Studio 2022 or install via the [Microsoft website](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0). On Linux, we recommend the [asdf](https://asdf-vm.com/guide/getting-started.html) package for a simple setup. Verify installation with ```dotnet --version.```

- Clone the engine locally:
```bash
# Whole repo:
git clone https://github.com/matheusfladislau/TicTacToeEngine

# Or only the Engine/ folder:
git clone --filter=blob:none --no-checkout https://github.com/matheusfladislau/TicTacToeEngine
cd TicTacToeEngine
git sparse-checkout init --cone
git sparse-checkout set Engine/
git checkout main
```

- Generate engine's .dll by running:
```bash
cd TicTacToeEngine/Engine
dotnet build
```

- Reference the engine's .dll on your own ```.csproj``` file:
```cs
<ItemGroup>
	<Reference Include="TicTacToeEngine">
        <!-- Relative path to Engine's .dll according to your file. -->
		<HintPath>..\Engine\bin\Debug\net8.0\TicTacToeEngine.dll</HintPath>
	</Reference>
</ItemGroup>
```


## Usage
The engine assigns numbers 1-9 to each field in the matrix initially. 
Players alternate turns, selecting an available spot marked by a number.

![illustration](https://github.com/matheusfladislau/TicTacToeEngine/blob/main/excalidraw/tictactoe_example.png)


The engine abstracts the core game mechanics, allowing you to use them without worrying about how implement their logic. For examples, check the `ConsoleGame` and `WinFormsGame` projects, which demonstrate different platform implementations using the same engine.

| Method | Parameter | Returns | Description |
| --- | --- | --- | --- |
| SetPlayerOne | string playerOneSymbol | void | Sets player one symbol ("X" or "O"). |
| SetPlayerTwo | string playerTwoSymbol | void | Sets player two symbol ("X" or "O"). |
| Ended | --- | bool | Checks if the game has ended. |
| Start | --- | void | Starts the game (populates the matrix). |
| GetCurrentMatrix | --- | string[3,3] | Gets the current game matrix. |
| NextRound | --- | void | Checks for a winner or draw, and switches players. |
| GetCurrentPlayerSymbol | --- | string | Gets the current player's symbol. |
| SubstituteFieldMatrix | int number | bool | Places the current player's symbol on the matrix at the given number (if available). |
| Result | --- | string | Gets the result of the game. |
| Restart | --- | void | Restarts the game. |

## Contributing
Here’s how you can get started:

- Browse open issues. You can also suggest your own ideas or enhancements.

- Fork this repository to your GitHub account and clone it to your local machine.

- Create a new branch for each issue or feature you’re working on to keep changes isolated and make reviewing easier.

- Submit a pull request to the main repository. Provide a clear description of what your PR addresses, including relevant context or testing steps.
