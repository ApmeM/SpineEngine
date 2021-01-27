PluginTemplate
==========
PluginTemplate is a project structure template for MyONez plugin libraries

- Project contatins tests and main project with links to eachother.
- Create nuget package for .net
- Create nuget package for bridge.net

Just replace "PluginTemplate" everywhere (filenames and files content) and push to git.

Once pushed github action will try to build it against .net and bridge.net and run dotnet tests

To create a package add a tag v1.0.0 to git and push it.

To add result package to your solution add new package source at

    Tools -> Options -> NuGet Package Manager -> Package Sources.

with source

    https://nuget.pkg.github.com/username/index.json
