
```markdown
<img src="Logo.png" alt="Kavez.PKCE Logo" width="200" />
# Kavez.PKCE

A lightweight and secure .NET library for generating PKCE code verifiers and challenges. Built for OAuth 2.0 flows in mobile, desktop, CLI, and web applications.

## ✨ Features

- Generate `code_verifier` with customizable length
- Generate `code_challenge` using `S256` or `plain` method
- No external dependencies
- Compatible with .NET 6, 7, and 8
- Designed for modular integration in any client-side OAuth flow

## 📦 Installation

Install via NuGet:

```bash
dotnet add package Kavez.PKCE
```

Or manually add reference to the project in your solution.

## 🚀 Usage

```csharp
using Kavez.PKCE.Core;

var verifier = PKCEHelper.GenerateCodeVerifier();
var challenge = PKCEHelper.GenerateCodeChallenge(verifier, "S256");

// Use verifier and challenge in your OAuth 2.0 flow
```

Supported methods:
- `"S256"`: Recommended for security
- `"plain"`: Legacy fallback (not recommended)

## 🧪 Testing

Unit tests are written using xUnit. To run tests:

```bash
dotnet test
```

Or use Visual Studio's Test Explorer:
- Build the solution (`Ctrl + Shift + B`)
- Open Test Explorer (`Ctrl + E, T`)
- Click `Run All`

## 📁 Project Structure

```
Kavez.PKCE/
├── Core/
│   └── PKCEHelper.cs
├── Utils/
│   └── CryptoUtils.cs
├── Kavez.PKCE.csproj
```

## 📚 License

MIT © Kavez

## 🌍 About

Created by [Mohammad](https://www.linkedin.com/in/mgolikhatir) to support secure, scalable OAuth flows across platforms.  
For contributions, issues, or feature requests, feel free to open a GitHub issue or pull request.
```
