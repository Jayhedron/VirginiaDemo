# VirginiaDemo

Blazor application created for the purposes of learning Blazor and Radzen Blazor Components.

Initial project structure from command: dotnet new blazorserver -n VirginiaDemo -f net7.0

Data was derived from virginiageneralassembly.gov and Wikipedia and stored as json files within the project and accessed using HttpClient.

Info component contains layout Radzen component use of cards and stacks, Reps component contains Radzen component use of Datagrid, and PieChart component shows Radzen component use of pie chart and line chart.

# Folder and file explanation:

## Project structure:

	**bin and obj:**

	These folders are created during the build process and contain compiled binary files and build artifacts.

	**Pages:**

	Folder where you organize your Blazor pages. Each Razor component in this folder corresponds to a route in the application. For example, Index.razor will be accessible at the root URL ("/").
	Shared:

	**Properties:**

	In a Blazor application (or any ASP.NET Core application), the launchSettings.json file is a configuration file that helps define settings for launching and debugging the application during development. It provides information about the hosting environment, application URLs, and various launch profiles.

	**Properties/launchSettings.json:**

	Configuration settings for launching the application, including environment variables and application URLs. It's used during development to specify how the application should be started.

	**Shared:**

	Folder typically contains Razor components that are shared across multiple pages or components. Common UI elements, layout components, or components that are used across different parts of the application can be placed here.

	**wwwroot:**

	Public root directory for static assets, such as CSS files, JavaScript files, images, that are intended to be directly accessible by clients, such as web browsers. This folder is a convention in ASP.NET Core web applications, including Blazor, and its primary purpose is to store static files that are served directly to users without any processing or interpretation by the server.

	**wwwroot/css/site.css:** The default CSS file for styling the application. You can customize or add additional CSS files as needed.
	**wwwroot/css/bootstrap:** Bootstrap is a popular open-source front-end framework, the css files contained here provide consistent and mobile-friendly styling.
	**wwwroot/css/custom.css:** Custom CSS file for specific styling outside site.css, bootstrap.css, and Radzen styling.

## Files:
	
	Radzen styling uses [Default Theme](https://blazor.radzen.com/themes?theme=default). Found in razor files.
	
	**_Imports.razor:**

	This file contains global @using directives that are automatically applied to all Razor files in the project. It helps avoid repetition by importing common namespaces.

	**App.razor:** This is the root component of the Blazor application. It specifies the layout and the initial route for the application. The Router component is responsible for routing and rendering the appropriate page based on the current URL.

	**Program.cs:** The entry point for the application, where you configure services and middleware for the application. Utilizing top-level statements to avoid the need for a Main method or a class declaration. 

	**RepHistory.cs:** Data object used for serialization for data related to historical data (by party affiliation), used in the context of graphs page.
	
	**Representative.cs:** Data object used for serialization for data related to current House of Delegates, used in the context of datagrid page.
	
	**TextSource:** Data object used for serialization for data related to text, used in the context of the info page.
	
	**VirginiaDemo.csproj:** Contains configuration settings for the project, including its type, framework, and other project-specific settings. For this project, the target framework is .NET 7.0 and includes package Radzen.Blazor.
	
	**VirginiaDemo.slm:** Used by the Visual Studio IDE and other development tools to organize and manage multiple projects as part of a solution. For this project only VirginiaDemo exists.
	
	**Pages/_Host.cshtml:** defining the structure and layout of the application's entry point. It is a Razor file used to customize the HTML content surrounding the Blazor component(s) when the application is rendered on the client side. Modified to include <link rel="stylesheet" href="_content/Radzen.Blazor/css/default.css" /> and <link href="css/custom.css" rel="stylesheet" />.
	
	**Pages/Error.cshtml:** Default Razor page that is used to customize the appearance and behavior of error pages when an unhandled exception occurs 
	
	**Error.cshtml.cs:** Inherits PageModel, used for data object for Error.cshtml.
	
	**Pages/Index.razor:** Default route, using RadzenText to display info from the beginning of this readme file.
	
	**Pages/Info.razor:** Route for informational page. Uses Radzen cards and stacks to contain sections. Top section is divided using Radzen row and columns. Code behind creates an HttpClient and sets the base address from the NavigationManager to access the absolute path of the textsource.json file. JsonSerializer deserializes to create a TextSource which is used for data binding within the Radzen components. 
	
	**Pages/PieChart.razor:** Route for graphs page. Uses Radzen cards to contain a RadzenPieSeries and RadzenLineSeries. Similar to Info.razor for getting data, this time from the repHistory.json file. Nested classes DataItem and HistoryItem represent the data used in the pie chart and line chart respectively. GetCurrentPartyBreakdown and GetHistoryPartyBreakdown generate the arrays of these data types.
	
	**Pages/Reps.razor:** Route for the RadzenDataGrid of current representatives. Similar to Info.razor for getting data, this time from the representatives.json file. RadzenCard for the top of page informational text. Straightforward data grid implementation, little quirky as not all data represents well on sorting. 
