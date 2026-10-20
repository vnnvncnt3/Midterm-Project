# Vestige: Heritage Walking Tours (Blazor Web App + Tailwind)

## Setup
```powershell
dotnet new blazor -n Vestige -int Server --all-interactive
cd Vestige
```
1. Copy this folder's files over the generated project (overwrite `Components/App.razor`, `Components/_Imports.razor`).
2. Delete the template files you do not need: `Components/Pages/Counter.razor`, `Weather.razor`, `Home.razor` (template one), `Components/Layout/NavMenu.razor*`, `MainLayout.razor.css`, `wwwroot/bootstrap`, `wwwroot/app.css`.
3. In `Program.cs`, add before `builder.Build()`:
   `builder.Services.AddSingleton<Vestige.Services.ReviewService>();`
4. Install and build Tailwind, then run:
```powershell
npm install
npm run css:build
dotnet watch
```
Use `npm run css:watch` in a second terminal while editing.

## Structure (PascalCase for C#/Razor files and folders, lowercase for wwwroot assets)
```
Components/ Layout/ Pages/ Shared/   Models/   Services/   Styles/   wwwroot/ css/ images/
```
Photos go in `wwwroot/images`: `hero.jpg`, `story.jpg`, `tour-old-town.jpg`, `tour-landmarks.jpg`, `tour-food.jpg`. The page shows a terracotta block until they exist.
