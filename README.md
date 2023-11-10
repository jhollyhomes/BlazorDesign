# Blazor Design

Basic blazor app using tailwind to test out design options.  Ability to change colours of elements dynamically to get an idea about different themes quickly.

### Using following
- Blazor WASM
  - Cascading Properties
  - Modal Popups
  - State Management
  - Blazor QuickGrid
- Minimal API
  - Simple API to allow searching of tasks
  - Uses Bogus to create fake tasks data
  - Added CORS to allow the Blazor App to connect
- Tailwind
  - Safelists
  - Layer Base (Global settings for elements)
  - Groups - used to control drop down user menu
 
### How to use

- .NET8 but will probably run most versions from 6 >= (those that support the Blazor QuickGrid
- `npm run build-dev` this will create the tailwind css files 
- `dotnet run` will execute client app

### Notes
- As using TailwindCSS used own Pager display when using Blazor Quickgrid
