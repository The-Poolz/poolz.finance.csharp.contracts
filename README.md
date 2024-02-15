# Contract Code Generator

This repository contains a GitHub Actions workflow that automatically generates C# code files from an ABI file obtained from an API, using the Nethereum.Generator.Console tool.

## Workflow Overview

The workflow is triggered by opening or editing an issue with a specific format (`make contractName@version`). It performs the following steps:

1. **Parse Issue**: Extracts the contract name and version from the issue title.
2. **Fetch ABI**: Makes an HTTP request to the API endpoint to get the ABI JSON.
3. **Save ABI**: Writes the ABI JSON to a file with the naming convention `contractName.abi`.
4. **Generate Code**: Runs the Nethereum.Generator.Console tool to generate C# code files from the ABI file.
5. **Create Branch**: Creates a new branch with the name `added-contractName`.
6. **Commit and Push**: Commits the generated code files and pushes them to the new branch.
7. **Create Pull Request**: Opens a pull request with the generated code files.
8. **Auto-Merge**: Automatically merges the pull request if it meets the specified conditions.
9. **Close Issue**: Closes the original issue that triggered the workflow.

## Usage

To trigger the workflow, open a new issue in this repository with the title in the format `make contractName@version`. The workflow will automatically generate the C# code files and create a pull request.

## Contributing

Contributions are welcome! Feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT [License](https://github.com/The-Poolz/poolz.finance.csharp.contracts?tab=MIT-1-ov-file) - see the file for details.
