# fume.net

## What is fume.net?

The fume.net is framework for writing automated UI tests using C# and .Net.
Framework is the result of synergized work of software and test developers in one mission:
Give community solution for open-source, modern, flexible and awesome testing framework.

## Which pattern is the best to use with FumeLab?

With fume.net you do not have to choose between Page Object and Page Factory patterns.
Custom page factory and element builder mechanism will provide you possibility to generate Page Objects and Elements with minimum code and in an easy and neat way.
Still, you can organize your test project using Page Object pattern.

**Example:**

```csharp
//Make an instance of page factory  
var driver = new ChromeDriver();
var commandRouter = new CommandRouter(new CommandHandlerFactory(), driver);
var pageFactory = new PageFactory(commandRouter);

//Instantiate Page Object   
var gitHubPage pageFactory.CreatePage<GitHubPage>();
```

## Defining Elements##

Define elements trough attributes by defining selector and selector values. 

**Example:**

```csharp
[Selector(Type = typeof(Css), Value = "a[class='button']")]
public Clickable VisitGitHub { get; set; }

[Selector(Type = typeof(XPath), Value = "//a[@title='https://fumelab.github.io']")]
public Clickable FumeSiteLink { get; set; }

[Selector(typeof(Name), "username")]
public Input Username { get; set; }
```

fume.net has modern interface implementation which will define possible actions depending which element you choose to create.
In previous example we showed how to declare Clickable and Input element, other than that you can also create Checkbox, RadioButton, FileUpload, Text and Select element. These elements can be located by either Id, Name, TagName, ClassName, CssSelector, LinkText, or XPath.

## Is FumeLab based on Selenium Webdriver?##

Goal of fume.net is to be driver agnostic, which means you can choose Selenium Webdriver or any other driver implementation.

## Wait Helper

Wait helper implementation is based on check whether state of an element is in the same as expected to be.
Conditions for the elements can be selected between Exists, NotExists, Visible, NotVisible, Clickable and many more.

**Example:**

```csharp
//Wait until element is clikable 
homePage.ClickMeButton.WaitFor(TimeSpan.FromSeconds(5)).Until(Until.Clickable);
```
