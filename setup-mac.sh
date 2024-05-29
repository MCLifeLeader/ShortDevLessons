#!/bin/bash

/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install.sh)"

brew install --cask dotnet-sdk-8.0

dotnet --version

brew install --cask visual-studio-code

