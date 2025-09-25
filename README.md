# Chess Game - Object-Oriented Programming Project

A console-based chess game implementation in C# that demonstrates object-oriented programming principles including inheritance, polymorphism, interfaces, and encapsulation.

## 🎯 Project Overview

This project is a complete chess game implementation built as part of an Object-Oriented Programming course. The game features a fully functional chess board with all standard pieces, move validation, and an interactive console interface.

## 🏗️ Architecture

### Core Components

- **GamePieces/**: Contains all chess piece implementations
  - `ChessPiece.cs` - Abstract base class for all pieces
  - `Bishop.cs`, `King.cs`, `Knight.cs`, `Pawn.cs`, `Queen.cs`, `Rook.cs` - Individual piece classes
  - `Error.cs` - Error handling piece class

- **Board/**: Chess board management
  - `ChessBoard.cs` - Main board class with setup and display functionality
  - `Position.cs` - Position handling utilities

- **Interface/**: Interface definitions
  - `IMovable.cs` - Interface for movable pieces

- **Utils/**: Utility classes
  - `BoardUtils.cs` - Board coordinate conversion utilities

- **Player.cs**: Player management and scoring
- **Program.cs**: Main game loop and user interaction

## 🚀 Features

- **Complete Chess Implementation**: All standard chess pieces with proper move validation
- **Interactive Console Interface**: User-friendly command-line interface
- **Move Validation**: Comprehensive move checking for each piece type
- **Board Display**: Visual representation of the chess board
- **Game Management**: Reset functionality and move history
- **Object-Oriented Design**: Clean separation of concerns with inheritance and polymorphism

## 🎮 How to Play

1. **Run the Application**:
   ```bash
   dotnet run
   ```

2. **Game Commands**:
   - Enter moves in format: `e2 e4` (from position to position)
   - Type `reset` to reset the board to starting position
   - Type `exit` to quit the game

3. **Chess Notation**:
   - Use standard algebraic notation (e.g., e2, e4, Nf3)
   - Board coordinates: A-H (files) and 1-8 (ranks)

## 🏛️ Object-Oriented Design Principles

### Inheritance
- `ChessPiece` serves as the abstract base class
- All specific pieces (Bishop, King, Knight, etc.) inherit from `ChessPiece`
- Common functionality is implemented in the base class

### Polymorphism
- Each piece implements its own `IsValidMove()` method
- The `MovePiece()` method works with any piece type through polymorphism

### Interface Implementation
- `IMovable` interface defines the contract for movable pieces
- `ChessPiece` implements `IMovable` interface

### Encapsulation
- Private fields and public properties with controlled access
- Utility methods are properly encapsulated in their respective classes

## 🛠️ Technical Details

- **Framework**: .NET 8.0
- **Language**: C#
- **Platform**: Cross-platform (Windows, macOS, Linux)
- **Dependencies**: None (pure C# implementation)

## 🎯 Learning Objectives

This project demonstrates:
- Abstract classes and inheritance
- Interface implementation
- Method overriding and polymorphism
- Encapsulation and data hiding
- Console application development
- Game logic implementation
- Code organization and modularity

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK or later
- A terminal or command prompt

### Installation
1. Clone the repository
2. Navigate to the project directory
3. Run the application:
   ```bash
   dotnet run
   ```

### Building
```bash
dotnet build
```

## 🎮 Game Rules

The implementation follows standard chess rules:
- Each piece moves according to its traditional movement patterns
- Move validation prevents illegal moves
- Pieces cannot move through other pieces (except knights)
- Capturing is handled by moving to occupied squares

## 📝 Future Enhancements

Potential improvements could include:
- Check and checkmate detection
- Castling implementation
- En passant capture
- Pawn promotion
- Game state persistence
- Two-player support with turn management
- GUI implementation

## 👨‍💻 Author

This project was created as part of an Object-Oriented Programming course assignment, demonstrating proficiency in C# and OOP principles.
